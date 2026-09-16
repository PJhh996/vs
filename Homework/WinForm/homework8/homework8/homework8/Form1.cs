using homework8.Models;
using Modbus.Device;
using System.ComponentModel;
using System.IO.Ports;

namespace homework8
{
    public partial class Form1 : Form
    {
        //定义数据
        private BindingList<DeviceTempRecord> DTRs = new();// 数据表格 的数据源
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
            TempTimer.Tick += MoniTemp;

            //设定 记录数据 定时器
            DataTimer = new System.Windows.Forms.Timer();
            DataTimer.Interval = 500;
            DataTimer.Tick += DataRecorde;
            // 温度表绘制
            panel8.Paint += TempPaint;

            //禁用UI
            closeBtn.Enabled = false;
            startBtn.Enabled = false;
            stopBtn.Enabled = false;
            inpSetTempTb.Enabled = false;
            setTempBtn.Enabled = false;

            //绑定按钮点击事件
            connectBtn.Click += ConnectPLC;//连接PLC按钮
            setTempBtn.Click += SetTemp;// 设定温度按钮
            startBtn.Click += StartDevice; // 启动设备按钮
        }

        private async void StartDevice(object? sender, EventArgs e)
        {
            //点击启动按钮
            //记录数据定时器 开启 数据记录区表格刷新
            //温度变化定时器 开启 模拟现实 中的温度变化
            TempTimer.Start();
            DataTimer.Start();
            //修改 从站寄存器 设备状态
            await Master.WriteSingleRegisterAsync(1, 0, 1);
            //禁用UI
            stopBtn.Enabled = true;
            startBtn.Enabled = false;
            //更新日志
            WriteLog("设备置运行状态");

            Console.WriteLine("======设备运行======");
        }

        //设定温度事件
        private async void SetTemp(object sender, EventArgs e)
        {
            //获取 输入框 内容
            //校验 设定温度是否符合要求
            if (!int.TryParse(inpSetTempTb.Text, out int setTemp) || setTemp > 400 || setTemp < 0)
            {
                MessageBox.Show("输入设定温度有误！");
                return;
            }
            //将 设定温度 写入寄存器
            await Master.WriteSingleRegisterAsync(1, 1, (ushort)setTemp);
            //禁用UI
            setTempBtn.Enabled = false;
            inpSetTempTb.Enabled = false;
            startBtn.Enabled = true;
            //修改 监控画面区 实际温度显示
            settempLab.Text = $"设定温度：{setTemp}℃";
            //更新日志
            WriteLog($"设置目标温度：{setTemp}℃");

        }


        //点击连接按钮 连接PLC
        private async void ConnectPLC(object? sender, EventArgs e)
        {
            //连接PLC方法
            if (Master != null) return;
            try
            {
                //创建串口，打开串口，创建主站对象；写入寄存器数据（初始值），设置禁用UI
                //串口名称、波特率、校验位、数据位、停止位 ==> "COM1",9600,Parity.None,8,StopBits.One
                MyPort = new SerialPort("COM1", 9600, Parity.None, 8, StopBits.One); //创建窗口通信对象
                MyPort.Open();//打开串口
                Master = ModbusSerialMaster.CreateRtu(MyPort);//创建主站对象
                Master.Transport.ReadTimeout = 2000;//读超时
                Master.Transport.Retries = 3; // 重试次数

                // 初始化设置 从站寄存器，
                // 0-设备状态 1-设定温度 2-实际采集温度 3-故障码
                //寄存器地址1 是设定温度，是通过输入框 输入后设定的
                await Master.WriteSingleRegisterAsync(1, 0, 0);//第一个参数是从站的地址
                await Master.WriteSingleRegisterAsync(1, 2, 30);//我们写代码拟定的基础温度
                await Master.WriteSingleRegisterAsync(1, 3, 0);
                Console.WriteLine("===设备连接(PLC)成功===");
            }
            catch (Exception err)
            {
                MessageBox.Show($"设备连接失败-{err.Message}");
                return;
            }
            //设置UI
            closeBtn.Enabled = true;
            inpSetTempTb.Enabled = true;
            setTempBtn.Enabled = true;
            connectBtn.Enabled = false;

            //连接成功 修改状态
            label7.Text = "当前状态：已连接";
            //日志输出 方法
            WriteLog("连接设备成功，开始采集");
        }

        //日志输出 方法
        private void WriteLog(string msg)
        {
            //创建label
            Label lab = new Label();
            lab.Text = DateTime.Now.ToString() + " " + msg;
            lab.AutoSize = true;
            lab.ForeColor = msg.Contains("警告") ? Color.Red : Color.Black;
            flowLayoutPanel1.Controls.Add(lab);
        }

        //温度表绘制
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


        //
        private async void DataRecorde(object sender, EventArgs e)
        {
            //记录数据变化
            //去从站 寄存器中获取 当前数据
            ushort[] ResArr = await Master.ReadHoldingRegistersAsync(1, 0, 4);//四个数据全要
            //记录数据 到表中
            //实例化创建 DeviceTempRecord 对象并添加到 DTRs的list中
            DeviceTempRecord DTR = new DeviceTempRecord(ResArr);
            DTRs.Add(DTR);
            //记录到表中 ，利用计数器，每过3000毫秒，记录一次，也就是计数器触发6次时记录一次
            RecordDataBase++;
            if (RecordDataBase == 6)
            {
                //dataGridView1
            }


        }

        //模拟 温度变化 定时器
        private async void MoniTemp(object sender, EventArgs e)
        {
            //定时器启动
            //温度变化写入 寄存器
            //温度变化在 监控画面区 动态显示
            //模拟最高温度为150度
            // 温度模拟逻辑设定: 到达150度后温度下降,下降到30度后升温, 升降温都1度1度来
            //获取 寄存器中的 数据
            ushort[] Temps = Master.ReadHoldingRegisters(1, 1, 2);//从站地址1，从寄存器下标1，开始拿到2个寄存器数据
            ushort CurrTemp = Temps[1];//当前温度
            //判断当前是升温还是 降温
            if (isHeating)
            {
                CurrTemp++;
                if (CurrTemp >= 150)
                {
                    CurrTemp = 150;
                    isHeating = false;
                }
            }
            else
            {
                CurrTemp--;
                if (CurrTemp <= 30)
                {
                    CurrTemp = 30;
                    isHeating = true;
                }
            }
            //判断 发生 超温还是  故障已消除
            if (Temps[0] == Temps[1])
            {
                string str = isHeating ? $"【警告】发生超温故障，实际温度={Temps[1]}，目标温度={Temps[0]}" : "超温故障已消除";
                //更新日志
                WriteLog(str);
                //设备状态 写回寄存器
                Master.WriteSingleRegister(1, 0, isHeating ? (ushort)2 : (ushort)1);
                Master.WriteSingleRegister(1, 3, isHeating ? (ushort)1 : (ushort)0);
            }
            //实际温度显示 监控画面区
            tempLab.Text = "实时温度" + CurrTemp + "℃";
            //将 实际温度写入 寄存器
            Master.WriteSingleRegister(1, 2, CurrTemp);
            //重新绘制 温度表
            panel8.Invalidate();

        }


        //设置表头
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