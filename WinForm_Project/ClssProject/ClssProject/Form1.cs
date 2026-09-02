using ClssProject.book;

namespace ClssProject
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        private string mark { get; set; }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (mark == "登录中")
            {
                BookShow bShow = new book.BookShow();
                bShow.Show();
                this.Hide();//隐藏当前窗口
                bShow.FormClosed += BShow_FormClosed;
            }
            else {
                Login login = new Login();
                login.Show();
                login.LoginMark += Login_LoginMark;
                this.Hide();
                login.FormClosed += Login_FormClosed;
            }

            
        }

        private void Login_LoginMark(string obj)//这个obj拿到的是 Login 里面的 "登录中" 或 "未登录"
        {
            this.mark = obj;
            label2.Text = mark;
        }

        private void Login_FormClosed(object? sender, FormClosedEventArgs e)
        {
            if (this.mark == "登录中")
            {
                BookShow bShow = new book.BookShow();
                bShow.Show();
                bShow.FormClosed += BShow_FormClosed;
            }
            else { 
                this.Show();
            }
        }

        private void BShow_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
    }
}
