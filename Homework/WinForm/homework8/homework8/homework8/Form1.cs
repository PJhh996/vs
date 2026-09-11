using homework8.Models;
using Modbus.Device;
using System.ComponentModel;
using System.IO.Ports;

namespace homework8
{
    public partial class Form1 : Form
    {
        //定义数据
        private BindingList<DeviceTempRecord> DTRs = new ();// 数据表格 的数据源
        private SerialPort MyPort;//需要下载第三方包 System.IO.Port 串口对象
        private IModbusSerialMaster Master; // 主站 串口
        private System.Windows.Forms.Timer TempTimer; // 温度变化定时器（模拟温度变化）
        private System.Windows.Forms.Timer DataTimer; // 数据记录定时器（用于定时记录数据）
        private bool isHeating = true; //定义开关  true 为升温 ， false 为降温，用来模拟温度变化用的开关
        private int RecordDataBase = 0; // 主页数据每隔500ms记录一次，记录六次也就是3000ms数据记录，写入数据库

        public Form1()
        {
            InitializeComponent();
            //初始化
            this.Shown += TCMInit;
        }

        private void TCMInit(object? sender, EventArgs e)
        {
            //初始化
            //设置表头
            SetDataColumns();
            //设定 定时器
            TempTimer = new System.Windows.Forms.Timer();
            TempTimer.Interval = 400;
            TempTimer.Tick += moniTemp;

            //设定 记录数据 定时器
            DataTimer = new System.Windows.Forms.Timer();
            DataTimer.Interval = 500;
            DataTimer.Tick += DataRecorde;
            // 温度表绘制
            panel8.Paint += TempPaint;
        }

        private void TempPaint(object? sender, PaintEventArgs e)
        {
            // 获取画图对象
            Graphics g = e.Graphics;
            //设置抗锯齿
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            using (var pen = new Pen(Color.Green, 2))
            {
                //圆弧矩形起点
                float sx = 0;
                float sy = 0;
                float r = 140;//半径
                float locationX = sx + r;
                float locationY = sy + r;
                //画个弧
                g.DrawArc(pen, sx, sy, (float)r * 2, (float)r * 2, 180, 180);
                // 温度0~600° ===>  分为120次  温度5度一个刻度
                for (int i = 0; i <= 120; i++)
                {
                    var lineLen = 5;
                    if (i % 10 == 0) lineLen = 10;
                    //开始结束坐标  1.5====>180度/120份,每个刻度是角度1.5
                    double startX = locationX - r * Math.Cos(1.5 * i * Math.PI / 180);
                    double startY = locationY - r * Math.Sin(1.5 * i * Math.PI / 180);
                    //结束坐标
                    double endX = locationX - (r - lineLen) * Math.Cos(1.5 * i * Math.PI / 180);
                    double endY = locationY - (r - lineLen) * Math.Sin(1.5 * i * Math.PI / 180);
                    //画刻度线, 使用笔枚举
                    g.DrawLine(Pens.Black, (int)startX, (int)startY, (int)endX, (int)endY);

                    if (i % 10 == 0) // 文字
                    {
                        using (Brush brushText = new SolidBrush(Color.Black))
                        using (StringFormat sf = new StringFormat())
                        using (Font font = new Font("宋体", 8))
                        {
                            sf.Alignment = StringAlignment.Center;
                            sf.LineAlignment = StringAlignment.Center;
                            //刻度标
                            double fontX = locationX - (r - lineLen - 10) * Math.Cos(-1.5 * i * Math.PI / 180);
                            double fontY = locationY + (r - lineLen - 10) * Math.Sin(-1.5 * i * Math.PI / 180);
                            g.DrawString((5 * i).ToString(), font, brushText, (float)fontX, (float)fontY, sf);
                        }
                    }

                }
                //定义变量 去modbus寄存器地址2中获取实时温度  用来给指针转动的值 
                ushort realTemp = 0;
                if (Master != null)
                {
                    ushort[] realTempushort = Master.ReadHoldingRegisters(1, 2, 1);
                    realTemp = realTempushort[0];
                }

                // 角度 180°/120 ===> 1.5 
                // 温度 600 / 120   ===> 5
                // 所以温度一度 就是 角度 0.3度
                double pointX = locationX - (r - 10) * Math.Cos(realTemp * 0.3 * Math.PI / 180);
                double pointY = locationY - (r - 10) * Math.Sin(realTemp * 0.3 * Math.PI / 180);

                using (Pen penline = new Pen(Color.Green, 2))
                {
                    g.DrawLine(penline, (int)pointX, (int)pointY, (int)locationX, (int)locationY);
                }

            }
        }

        private void DataRecorde(object sender, EventArgs e)
        {
            
        }

        private void moniTemp(object sender, EventArgs e)
        {
            
        }



        private void SetDataColumns()
        {
            //新建一个数据源
            DTRs = new();
            //设置表头
            dataGridView1.AutoGenerateColumns = false;//禁用数据源表头自动生成
            //绑定数据源
            dataGridView1.DataSource = DTRs;// source 是源头的意思，数据源头
            //设置表头
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()//给表格新增一列
            {
                DataPropertyName = "CollectTime",//数据源 名字
                Name = "CollectTime",  // 这列的名字
                HeaderText = "采集时间", // 列表头文字
                DefaultCellStyle = new DataGridViewCellStyle()//单元格样式对象，控制单元格格式、对齐、颜色、字体。
                {
                    Format = "yyyy-MM-dd HH:mm:ss",//单元格数据格式化字符串，专门给DateTime时间类型用
                    Alignment = DataGridViewContentAlignment.MiddleCenter//居中对齐
                }
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()//给表格新增一列
            {
                DataPropertyName = "DeviceStatus",//数据源 名字
                Name = "DeviceStatus",  // 这列的名字
                HeaderText = "设备状态", // 列表头文字
                DefaultCellStyle = new DataGridViewCellStyle()//单元格样式对象，控制单元格格式、对齐、颜色、字体。
                {
                    Alignment = DataGridViewContentAlignment.MiddleCenter//居中对齐
                }
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()//给表格新增一列
            {
                DataPropertyName = "SetTemp",//数据源 名字
                Name = "SetTemp",  // 这列的名字
                HeaderText = "设定温度", // 列表头文字
                DefaultCellStyle = new DataGridViewCellStyle()//单元格样式对象，控制单元格格式、对齐、颜色、字体。
                {
                    Alignment = DataGridViewContentAlignment.MiddleCenter//居中对齐
                }
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()//给表格新增一列
            {
                DataPropertyName = "RealTemp",//数据源 名字
                Name = "RealTemp",  // 这列的名字
                HeaderText = "实时温度", // 列表头文字
                DefaultCellStyle = new DataGridViewCellStyle()//单元格样式对象，控制单元格格式、对齐、颜色、字体。
                {
                    Alignment = DataGridViewContentAlignment.MiddleCenter//居中对齐
                }
            }); 
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()//给表格新增一列
            {
                DataPropertyName = "FaultCode",//数据源 名字
                Name = "FaultCode",  // 这列的名字
                HeaderText = "故障码", // 列表头文字
                DefaultCellStyle = new DataGridViewCellStyle()//单元格样式对象，控制单元格格式、对齐、颜色、字体。
                {
                    Alignment = DataGridViewContentAlignment.MiddleCenter//居中对齐
                }
            });

            // 设置行头
            dataGridView1.RowHeadersVisible = false;
            // 设置表数据为只读
            dataGridView1.ReadOnly = true;
            // 设置表数据不能手动删除添加
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            // 表宽度自适应
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
