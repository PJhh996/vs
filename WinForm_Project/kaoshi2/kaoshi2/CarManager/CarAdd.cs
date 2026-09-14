using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace kaoshi2.CarManager
{
    public partial class CarAdd : Form
    {
        MySQL my = new MySQL("test");
        public CarAdd()
        {
            InitializeComponent();
            this.Shown += AddInit;
        }

        private async void AddInit(object? sender, EventArgs e)
        {
            //初始化设置
            //新增车辆
            //获取 车辆信息
            //点击按钮  实现新增或编辑
            //获取inp里面的数据
            button1.Click += Add;
        }

        private async void Add(object? sender, EventArgs e)
        {
            string card = textBox1.Text;
            string type = textBox2.Text;
            string price = textBox3.Text;//需要校验,时间允许
            string sql = "";//sql语句

            sql = "insert into car(card,type,price) value(@card,@type,@price)";

            //调用连接数据库方法  连接后 函数内操作
            await my.ConAndHandler(sql, com =>
            {
                com.Parameters.AddWithValue("@card", card);
                com.Parameters.AddWithValue("@type", type);
                com.Parameters.AddWithValue("@price", price);
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
