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
    public partial class BookAddAndEdit : Form
    {

        MySql my = new MySql("test");
        private string title { get; set; }
        private string Id { get; set; }
        public BookAddAndEdit()
        {
            InitializeComponent();
        }

        //重写构造函数
        public BookAddAndEdit(string title)//新增使用
        {
            InitializeComponent();
            label1.Text = "图书" + title;
            button1.Text = title;

            this.title = title;
        }

        public BookAddAndEdit(string title,string id)//编辑使用
        {
            InitializeComponent();
            label1.Text = "图书" + title;
            button1.Text = title;

            this.title= title;
            this.Id = id;
            //回显
            string sql = "select * from book where id = @id";
            my.ConAndHandler(sql, cmd => {
                //参数填充
                cmd.Parameters.AddWithValue("@id", id);
                MySqlDataReader reader = cmd.ExecuteReader();
                bool isRead = reader.Read();
                if (!isRead)
                {
                    MessageBox.Show(this.title + "失败");
                    this.Close();
                    return;
                }
                input1.Text = reader.GetString("name");
                input2.Text = reader.GetString("author");
                inputNumber1.Text = reader.GetDouble("price").ToString();
                input4.Text = reader.GetString("label").Replace(" | ","\n");

            });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //点击按钮  实现新增或编辑
            //获取inp里面的数据
            string name = input1.Text;
            string author = input2.Text;
            double price = double.Parse(inputNumber1.Text);
            string mark = input4.Text.Replace("\n", " | ");
            string sql = "";//sql语句
            if (title == "新增")
            {
                sql = "insert into book(name,author,price,label) value(@name,@author,@price,@label)";
            }
            else {
                sql = "update book set name=@name,author=@author,price=@price,label=@label where id=@id";
            }          

            //调用连接数据库方法  连接后 函数内操作
            my.ConAndHandler(sql, com => 
            { 
                com.Parameters.AddWithValue("@name", name);
                com.Parameters.AddWithValue("@author", author);
                com.Parameters.AddWithValue("@price", price);
                com.Parameters.AddWithValue("@label", mark);
                if (this.title == "编辑") com.Parameters.AddWithValue("@id",Id);                
                int rows = com.ExecuteNonQuery(); 
                if (rows > 0)
                {
                    MessageBox.Show(this.title+"成功");
                    this.Close();

                }
                else {
                    MessageBox.Show(this.title+"失败");
                }

            });


        }
    }
}
