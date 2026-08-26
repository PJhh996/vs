using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace day03
{
    public partial class MouseXY : Form
    {
        public MouseXY()
        {
            InitializeComponent();
            IntnXY();

        }

        private void IntnXY()
        {
            this.MouseMove += this_MouseMove;
            textBox1.Leave += textBox1_Leave;
            textBox1.GotFocus += textBox1_GotFocus;
            textBox2.GotFocus += textBox2_GotFocus;
            textBox2.Leave += textBox2_Leave;

        }

        private void this_MouseMove(object sender ,EventArgs e)//实现光标位置显示
        { 
            // 将事件参数对象转为 鼠标事件参数对象 (只有鼠标事件才行)
            MouseEventArgs ev = e as MouseEventArgs; 
            labX.Text = ev.X.ToString();
            labY.Text = ev.Y.ToString();
        }

        private void textBox1_Leave(object sender, EventArgs e)//输入框校验
        { 
            //先获取文本框的文本数据
            string str = (sender as TextBox).Text;
            //判断文本框中数据是否是数字
            if (Regex.IsMatch(str, @"^1[35789][0-9]{9}$"))
            {
                
                lab1.Visible = true;
                lab2.Visible = false;
            }
            else { 
                lab2.Visible = true;
                lab1.Visible = false;

            }

        }

        private void textBox1_GotFocus(object sender, EventArgs e)//输入框校验
        {
            lab1.Visible = false;
            lab2.Visible=false;
        }

        private void textBox2_GotFocus(object sender, EventArgs e)
        { 
            textBox2.BackColor = Color.Orange;
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            (sender as TextBox).BackColor = Color.White;
            (sender as TextBox).ForeColor = Color.Black;
            (sender as TextBox).BorderStyle = BorderStyle.FixedSingle;
            //textBox2.BackColor = Color.White;
        }

    }
}
