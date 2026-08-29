using System.Runtime.InteropServices;

namespace day06
{
    public partial class Form1 : Form
    {
        //定义一个 坐标变量
        private Point P ;
        //定义一个开关
        private bool flag = false;
        public Form1()
        {
            InitializeComponent();
            InitMove();
        }
        private void InitMove()
        {
            button1.MouseDown += Button1_MouseDown;//鼠标按下获取 鼠标 坐标 和按钮坐标 之间的关系
            button1.MouseMove += Button1_MouseMove;//锁定鼠标和按钮的相对坐标，让按钮跟着鼠标走
            button1.MouseUp += Button1_MouseUp;//松开鼠标 开关打开，放下按钮
            richTextBox1.GotFocus += RichTextBox1_GotFocus;
        }

        private void RichTextBox1_GotFocus(object? sender, EventArgs e)
        {
            this.Close();
        }

        private void Button1_MouseUp(object? sender, MouseEventArgs e)
        {
            //鼠标松开开关关闭，鼠标移动事件不触发
            flag = false;
        }

        private void Button1_MouseMove(object? sender, MouseEventArgs e)
        {
            if (!flag)//当开关为true 也就是 鼠标按下时候，擦执行下面的移动代码
            {
                return;//开关不开不执行下面的代码
            }
            //将鼠标相对于按钮坐标 转变为 鼠标相对于 屏幕的坐标
            Point m_s = button1.PointToScreen(e.Location);

            //将 鼠标相对于屏幕的坐标 减去 鼠标相对于按钮的坐标P 拿到 按钮 相对于屏幕的坐标
            //这里不能使用e.X和e.Y 因为鼠标每移动一个像素点，e.X和e.Y都会变化，那么按钮相对于 屏幕的坐标就不会变化了
            m_s.Offset(-P.X, -P.Y);

            //将按钮相对于屏幕的坐标 转换为 按钮相对于父容器的坐标
            Point b_parent = this.PointToClient(m_s);

            //限制按钮只能在窗口内移动

            if (b_parent.X <= 0) b_parent.X=0;
            if (b_parent.Y <= 0) b_parent.Y=0;
            if (b_parent.X >= this.Width - button1.Width) b_parent.X= this.Width - button1.Width;
            if (b_parent.Y >= this.Height - button1.Height) b_parent.Y= this.Height - button1.Height;



            //将按钮相对于父容器的坐标 赋值给 button1.Location
            button1.Location = b_parent;

        }

        private void Button1_MouseDown(object? sender, MouseEventArgs e)
        {
            flag = true;
            //鼠标按下 获取 鼠标相对于按键的坐标
            P = e.Location;//固定不变的值
        }




    }
}
