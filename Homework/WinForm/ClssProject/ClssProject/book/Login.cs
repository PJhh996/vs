using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ClssProject.book
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private MySql my = new MySql("test");
        public event Action<string> LoginMark;
        private async void button1_Click(object sender, EventArgs e)
        {
            string name = input1.Text;
            string pwd = input2.Text;
            if (name.Trim() == "" && pwd.Trim() == "")
            {
                MessageBox.Show("用户名和密码不能为空");
                return;
            }
            string sql = "select * from user where username = @username and password = @password";
            await my.ConAndHandler(sql, cmd =>
            {
                cmd.Parameters.AddWithValue("@username", name);
                cmd.Parameters.AddWithValue("@password", pwd);
                MySqlDataReader reader = cmd.ExecuteReader();
                bool res = reader.Read();
                if (res)
                {
                    MessageBox.Show("登录成功");
                    LoginMark.Invoke("登录中");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("登录失败");
                    LoginMark.Invoke("未登录");
                    this.Close();
                }
                return true;
            });

        }

        private void button2_Click(object sender, EventArgs e)
        {
            register reg = new register();
            reg.Show();
            this.Hide();
            reg.FormClosed += reg_FormClosed;
        }

        private void reg_FormClosed(object sender ,EventArgs e) 
        { 
            this.Show();
        }
    }
}
