using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace day02
{
    public partial class anli1 : Form
    {
        public anli1()
        {
            InitializeComponent();
            click();
        }

        public void click()
        {
            button1.Click += button1_Click;
        }

        public void button1_Click(object sender ,EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"./images/on.png");
            
            if (button1.Text == "开")
            {
                pictureBox1.Image = Image.FromFile(@"./images/off.png");

                button1.Text = "关";
            }
            else {
                pictureBox1.Image = Image.FromFile(@"./images/on.png");
                button1.Text = "开";
            }

        }

    }
}
