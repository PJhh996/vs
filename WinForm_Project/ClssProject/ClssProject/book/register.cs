using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ClssProject.book
{
    public partial class register : Form
    {
        private MySql Mysql = new MySql("test");
        public register()
        {
            InitializeComponent();
            //初始化设置
            inputNumber1.Minimum = 1;
            inputNumber1.Maximum = 120;
            select1.Items = ["01班", "02班", "03班", "04班"];//下拉框下拉数据
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            //点击按钮注册
            //校验 用户名 是否符合 格式
            string username = input1.Text;
            if (!Regex.IsMatch(username, @"^[0-9a-zA-Z_]{4,15}$"))
            {
                MessageBox.Show("用户名格式有误！");
                return;
            }
            //校验 密码 是否符合 格式
            string password = input2.Text;
            if (password.Length < 4 || password.Length > 16)//或
            {
                MessageBox.Show("密码输入格式有误！");
                return;
            }
            //看看 确认密码 是否与 密码一致
            string isPassword = input3.Text;
            if (isPassword != password)
            {
                MessageBox.Show("请保证密码与确认密码一致！");
                return;
            }
            //获取年龄
            int age = (int)inputNumber1.Value; //inputNumber 控件 获取值
            //获取性别
            string gender = radio1.Checked ? "男" : "女";//三元表达式，如果选中 reido1,那么赋值“男”给gender
            //获取班级
            //先查看select1 文本框内是否有值
            if (select1.SelectedValue == null)
            {
                MessageBox.Show("请选择班级！");
                return;
            }
            //有值，然后再获取值
            string banji  = select1.SelectedValue.ToString();

            //校验这名用户是否已经注册
            //在数据库中查找
            string sql = "select * from user where username = @username";
            //调用连接操作方法
            bool sqlName = await Mysql.ConAndHandler(sql, cmd =>
            {
                cmd.Parameters.AddWithValue("@username",username);
                //MySqlDataReader 是MySQL 数据读取器,专门用来 读 查询结果
                MySqlDataReader reader = cmd.ExecuteReader();//读取到一个对象
                //判断是否读取到
                bool isRead = reader.Read();
                if (isRead) return false;
                return true;
            });
            if (!sqlName) 
            {
                MessageBox.Show("用户名已被使用！");
                return;
            }
            //数据校验完毕 写入数据库
            string writeSql = "insert into user(username,password,age,gender,banji) value(@username,@password,@age,@gender,@banji)";
            await Mysql.ConAndHandler(writeSql, cmd => {
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@age", age);
                cmd.Parameters.AddWithValue("@gender", gender);
                cmd.Parameters.AddWithValue("@banji", banji);
                int row = cmd.ExecuteNonQuery();//受影响的函数
                if (row > 0)
                {
                    MessageBox.Show("注册成功！请前往登录");
                    this.Close();
                }
                else {
                    MessageBox.Show("注册失败!");
                }

                return true;
            });


        }







    }
}
