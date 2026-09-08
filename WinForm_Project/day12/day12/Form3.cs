using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;

namespace day12
{
    public partial class Form3 : Form
    {




        public Form3()
        {
            InitializeComponent();

            //演讲           
            string aaa = "asdfhello";
            Class1 Class1 = new Class1();
            Class1 class1 = new Class1(aaa);


            InitFn();
            bbb(aaa);
            panel1.Click += Panel1_Click;
        }

        private void bbb(string aaa)
        {
            
        }

        private void Panel1_Click(object? sender, EventArgs e)
        {
            
        }



        private void InitFn()
        {
            //自动生成的方法框架
            const string str = "登录成功";
            MessageBox.Show(str);

        }




    }



}
