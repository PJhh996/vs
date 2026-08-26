using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace day03
{
    public partial class Link : Form
    {
        public Link()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            label1.MouseEnter += label1_MouseEnter;
            label1.MouseLeave += label1_MouseLeave;

        }

        private void label1_MouseEnter(object sender ,EventArgs e) 
        { 
            label1.ForeColor = Color.Purple;
            label1.Font = new Font("Microsoft YaHei UI",9F,FontStyle.Underline,GraphicsUnit.Point);
        }
        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Blue;
            label1.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
        }

    }
}
