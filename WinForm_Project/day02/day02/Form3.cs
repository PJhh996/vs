using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace day02
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            click();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("点击了");
        }

        public void click()
        {
            button1.Click += button1_Click;
        }

    }
}
