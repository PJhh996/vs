using System.Reflection.Metadata;

namespace kaoshi1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int Num = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            //单击应用参数 按钮 
            //日志 显示 应用参数
            //获取文本
            string name = Nametab.Text;
            //创建label加入日志
            Label lab = new Label();
            lab.Text = "参数已应用";
            lab.Size = new Size(300, 30);
            flowLayoutPanel1.Controls.Add(lab);

            Label labName = new Label();
            labName.Text = "设备名称：" + name;
            labName.Size = new Size(300, 30);
            flowLayoutPanel1.Controls.Add(labName);

            Label labLei = new Label();
            labLei.Text = "设备类型：" + comboBox1.Text;
            labLei.Size = new Size(300, 30);
            flowLayoutPanel1.Controls.Add(labLei);

            Label labYX = new Label();
            labYX.Text = radioButton1.Checked ? "运行模式：" + radioButton1.Text : "运行模式：" + radioButton2.Text;
            labYX.Size = new Size(300, 30);
            flowLayoutPanel1.Controls.Add(labYX);

            Label labBJ = new Label();
            labBJ.Text = checkBox1.Checked ? "温度报警：启用" : "温度报警：未启用";
            labBJ.Size = new Size(300, 30);
            flowLayoutPanel1.Controls.Add(labBJ);

            Label labTemp = new Label();
            labTemp.Text = "温度上限：" + numericUpDown1.Value.ToString() + "℃";
            labTemp.Size = new Size(300, 30);
            flowLayoutPanel1.Controls.Add(labTemp);
            flowLayoutPanel1.ScrollControlIntoView(labTemp);

            //button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //单击启动 设备按钮 实现 日志显示
            //创建lab
            Label labelkong = new Label();
            labelkong.Text = "";
            labelkong.Size = new Size(300, 30);
            flowLayoutPanel1.Controls.Add(labelkong);

            Label label = new Label();
            label.Text = "设备 " + Nametab.Text + " 已启动";
            label.Size = new Size(300, 30);
            flowLayoutPanel1.Controls.Add(label);
            flowLayoutPanel1.ScrollControlIntoView(label);


            //按钮禁用
            button2.Enabled = false;
            button3.Enabled = true;
            //状态lab 改变
            label8.Text = "运行中";
            label8.ForeColor = Color.Green;

            label9.Text = "已连接";
            label9.ForeColor = Color.Green;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //点击 停止按钮
            //显示日志
            //创建label
            Label label = new Label();
            label.Text = "设备 " + Nametab.Text + " 已停止";
            label.Size = new Size(300, 30);
            flowLayoutPanel1.Controls.Add(label);
            flowLayoutPanel1.ScrollControlIntoView(label);


            //按钮禁用
            button3.Enabled = false;
            button2.Enabled = true;
            //改变lab
            label8.Text = "已停止";
            label8.ForeColor = Color.Red;

            label9.Text = "未连接";
            label9.ForeColor = Color.DarkGray;

        }
    }
}
