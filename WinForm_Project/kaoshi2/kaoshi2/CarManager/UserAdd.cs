using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace kaoshi2.CarManager
{
    public partial class UserAdd : Form
    {
        MySQL my = new MySQL("test");

        public UserAdd()
        {
            InitializeComponent();
            this.Shown += AddInit;
        }

        private void AddInit(object? sender, EventArgs e)
        {
            button1.Click += Add;
        }

        private async void Add(object? sender, EventArgs e)
        {
            string name = textBox1.Text;
            string id_card = textBox2.Text;
            string gender = textBox3.Text;//需要校验,时间允许
            string tel = textBox4.Text;//校验***
            string motto = textBox5.Text;
            string reg_time = DateTime.Now.ToString();

            string sql = "";//sql语句

            sql = "insert into user_info(name,id_card,gender,tel,motto,reg_time) value(@name,@id_card,@gender,@tel,@motto,@reg_time)";

            //调用连接数据库方法  连接后 函数内操作
            await my.ConAndHandler(sql, com =>
            {
                com.Parameters.AddWithValue("@name", name);
                com.Parameters.AddWithValue("@id_card", id_card);
                com.Parameters.AddWithValue("@gender", gender);
                com.Parameters.AddWithValue("@tel", tel);
                com.Parameters.AddWithValue("@motto", motto);
                com.Parameters.AddWithValue("@reg_time", reg_time);

                int rows = com.ExecuteNonQuery();
                if (rows > 0)
                {
                    MessageBox.Show("新增成功");
                    this.Close();

                }
                else
                {
                    MessageBox.Show("新增失败");
                }
                return true;
            });
        }
    }
}
