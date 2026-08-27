using System.Text.RegularExpressions;

namespace day04
{
    public partial class Form1 : Form
    {

        //定义一个开关
        private bool flag = true;
        private DateTime time1 { get; set; }

        public Form1()
        {
            InitializeComponent();
            InitKey();//按键按下时间
            InitOpen();//下拉框获取焦距展开
            InitEnter();//回车提交表单
            InitESC();//退出窗体   
            InitCtrl();//组合键
            InitNum();//限制文本框只能输入数字
        }

        private void InitNum()
        {
            textBox1.KeyPress += TextBox1_KeyPress;
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //获取文本框内容进行判断
            string str = (sender as TextBox).Text;
            //判断内容是否为数字
            if (e.KeyChar < '0' || e.KeyChar >'9')
            { 
                e.Handled = true;
            }



        }
        private void InitCtrl()
        {
            textBox1.KeyDown += textBox1_KeyDown;
        }

        private void textBox1_KeyDown(object sender, EventArgs e)
        { 
            KeyEventArgs ev = (e as KeyEventArgs);
            if (ev.Control && ev.KeyCode == Keys.C)
            {
                MessageBox.Show("复制");
            }
            if (ev.Control && ev.KeyCode == Keys.V)
            {
                MessageBox.Show("粘贴");
            }

        }

        private void InitESC()
        {
            textBox1.KeyUp += Form1_KeyUp1;//光标在text身上才能关闭
        }

        private void Form1_KeyUp1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void InitEnter()
        {
            textBox1.KeyUp += TextBox1_KeyUp;
        }

        private void TextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            
            //获取文本框内容
            string str = (sender as TextBox).Text;
            if (e.KeyCode == Keys.Enter)
            {
                MessageBox.Show(str);
            }

        }

        private void InitOpen()
        {
            comboBox1.GotFocus += ComboBox1_GotFocus;
            comboBox1.Leave += ComboBox1_Leave;
        }

        private void ComboBox1_Leave(object sender, EventArgs e)
        {
            (sender as ComboBox).DroppedDown = false;
        }

        private void ComboBox1_GotFocus(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            cb.DroppedDown = true;
        }

        private void InitKey()
        {
            button1.KeyDown += Form1_KeyDown;
            button1.KeyUp += Form1_KeyUp;
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            flag = true;
            DateTime time2 = DateTime.Now;
            TimeSpan time3 = time2 - time1;
            lab.Text = time3.TotalMilliseconds.ToString();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (flag)
            { 
                time1 = DateTime.Now;
                flag = false;
            }
        }


    }
}
