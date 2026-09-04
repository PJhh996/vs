using ClssProject.book;
using System.Windows.Forms.VisualStyles;

namespace ClssProject
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            //初始化 设置
            AntdUI.Config.ShowInWindow = true;
            //初始状态为 “未登录”
            状态ToolStripMenuItem.Text = "未登录";
            退出登录ToolStripMenuItem.Visible = false;//未登录时 隐藏起来
            切换用户ToolStripMenuItem.Visible = false;
        }
        //private string mark { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            if (状态ToolStripMenuItem.Text == "登录中")
            {
                BookShow bShow = new book.BookShow();
                bShow.Show();
                this.Hide();//隐藏当前窗口
                bShow.FormClosed += BShow_FormClosed;
            }
            else
            {
                AntdUI.Message.warn(this, "请登录后重试！", autoClose: 3);
            }


        }

        private void Login_LoginMark(string obj)//这个obj拿到的是 Login 里面的 "登录中" 或 "未登录"
        {
            //this.mark = obj;
            //label2.Text = mark;
            状态ToolStripMenuItem.Text = obj;
        }

        private void Login_FormClosed(object? sender, FormClosedEventArgs e)
        {
            if (状态ToolStripMenuItem.Text == "登录中")
            {
                登录ToolStripMenuItem.Visible = false;
                退出登录ToolStripMenuItem.Visible = true;
                切换用户ToolStripMenuItem.Visible = true;
                注册ToolStripMenuItem.Visible = false;

                BookShow bShow = new book.BookShow();
                bShow.Show();
                bShow.FormClosed += BShow_FormClosed;
            }
            else
            {
                this.Show();
            }
        }

        private void BShow_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void 登录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //点击登录按钮触发事件
            //展示 登录窗口
            Login login = new Login();
            login.Show();
            login.LoginMark += Login_LoginMark;
            this.Hide();
            login.FormClosed += Login_FormClosed;

        }

        private void 切换用户ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //点击登录按钮触发事件
            //展示 登录窗口
            Login login = new Login();
            login.Show();
            login.LoginMark += Login_LoginMark;
            this.Hide();
            login.FormClosed += Login_FormClosed;
        }

        private void 退出登录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //将状态 改变
            状态ToolStripMenuItem.Text = "未登录";
            登录ToolStripMenuItem.Visible = true;
            注册ToolStripMenuItem.Visible = true;

        }
    }
}
