using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace day02
{
    public partial class anli2 : Form
    {
        public anli2()
        {
            InitializeComponent();
            init();
        }

        public string[] picArr = [@"./images/cat.jpg", @"./images/bird.jpg", @"./images/eagle.jpg"];


        public void init()
        {
            pictureBox1.Image = Image.FromFile(picArr[0]);
            panel1.Controls[0].BackColor = Color.Green;
            panel1.Controls[0].ForeColor = Color.Blue;

            for (int i = 0; i < panel1.Controls.Count; i++)
            {
                panel1.Controls[i].Click += click;
            }
        }

        public void click(object sender,EventArgs e)
        {
            for (int i = 0; i < panel1.Controls.Count; i++)
            {
                panel1.Controls[i].BackColor = Color.DarkGray;
                panel1.Controls[i].ForeColor = Color.Black;
            }

            // 将当前这个按钮的高亮添加
            Button btn = (Button)sender;
            btn.BackColor = Color.Green;
            btn.ForeColor = Color.Blue;
            // 修改图片地址: 当前按钮和对应的图片地址的索引一致
            // 获取 btn按钮在容器中的下标
            int index = panel1.Controls.IndexOf(btn);
            pictureBox1.Image = Image.FromFile(picArr[index]);

        }


    }
}
