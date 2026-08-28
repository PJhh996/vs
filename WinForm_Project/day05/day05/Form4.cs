using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace day05
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            InitAll();
        }
        private void InitAll()
        {
            allBox.CheckStateChanged += AllBox_CheckStateChanged;//全选事件
            foreach (Control item in panel1.Controls)
            {
                (item as CheckBox).CheckedChanged += item_CheckedChanged;
            }
        }

        private void item_CheckedChanged(object? sender, EventArgs e)
        {
            int count = 0;//定义一个计数器，用来可判断是否全选了
            foreach (Control item in panel1.Controls)
            {
                CheckBox box = (item as CheckBox);
                if (box.CheckState == CheckState.Checked)count++;    
            }
            List<Control> list = panel1.Controls.OfType<Control>().ToList();
            if(count == list.Count)allBox.CheckState = CheckState.Checked;
            else if(count > 0 && count < list.Count)allBox.CheckState = CheckState.Indeterminate;
            else allBox.CheckState = CheckState.Unchecked;


        }

        private void AllBox_CheckStateChanged(object? sender, EventArgs e)
        {
            if (allBox.CheckState == CheckState.Checked)
            {
                foreach (Control item in panel1.Controls)
                {
                    (item as CheckBox).CheckState = CheckState.Checked;
                }
            }
            else if (allBox.CheckState == CheckState.Unchecked)
            {
                foreach (Control item in panel1.Controls)
                {
                    (item as CheckBox).CheckState = CheckState.Unchecked;
                }
            }
            else return; 
        }
    }
}
