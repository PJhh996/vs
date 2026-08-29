using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace day06
{
    public partial class Form2 : Form
    {
        private Form3 ff = new Form3();
        public Form2()
        {
            InitializeComponent();
            InitForm();
        }
        private void InitForm()
        {
            button1.Click += Button1_Click;

        }

        private void Button1_Click(object? sender, EventArgs e)
        {
            ff = new Form3();
            ff.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ff.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ff.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
