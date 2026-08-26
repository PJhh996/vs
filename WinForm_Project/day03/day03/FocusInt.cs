using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace day03
{
    //焦点拦截
    public partial class FocusInt : Form
    {
        public FocusInt()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            textBox1.Leave += textBox1_Leave;
            textBox1.TextChanged += textBox1_TextChanged;

        }

        private void textBox1_TextChanged(object sender,EventArgs e)
        {
            TextBox tt = (sender as TextBox);
            string conent = tt.Text;
            if (!string.IsNullOrEmpty(conent))
            { 
                label1.Visible = false;
            }
        }


        private void textBox1_Leave(object sender ,EventArgs e)
        {
            TextBox tb = (sender as TextBox);
            string str = tb.Text;
            if (string.IsNullOrEmpty(str))
            {
                tb.Focus();
                label1.Text = "内容不能为空";
                label1.Visible = true;
            }
        }


    }
}
