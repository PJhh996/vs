using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace day05
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            priceCb.SelectedIndexChanged += Changed;
            timeCb.SelectedIndexChanged += Changed;
        }

        private void Changed(object sender ,EventArgs e) 
        {
            ComboBox cb = sender as ComboBox;
            if (cb.Name == "priceCb")
            {
                if (cb.Text == "升序") MessageBox.Show("按价格升序");
                else MessageBox.Show("按价格降序");
            }
            else 
            {
                if (cb.Text == "升序") MessageBox.Show("按上架时间升序");
                else MessageBox.Show("按上架时间降序");
            }
        } 
    }
}
