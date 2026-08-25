using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace day02
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            fa();
        }

        public void fa()
        { 
            Button b0 = new Button();
            b0.Location = new Point(0, 0);
            b0.Size = new Size(100, 50);
            b0.Text = "0";

            Button b1 = new Button();
            b1.Location = new Point(0, 60);
            b1.Size = new Size(100, 50);
            b1.Text = "1";

            Button b2 = new Button();
            b2.Location = new Point(0, 120);
            b2.Size = new Size(100, 50);
            b2.Text = "2";

            Button b3 = new Button();
            b3.Location = new Point(0, 180);
            b3.Size = new Size(100, 50);
            b3.Text = "3";

            Button b4 = new Button();
            b4.Location = new Point(0, 240);
            b4.Size = new Size(100, 50);
            b4.Text = "4";

            Control[] bs = [b0,b1,b2,b3,b4];

            this.Controls.AddRange(bs);

            this.Controls.SetChildIndex(b2,0);

            for (int i = 0; i < bs.Length; i++)
            {
                string aa = this.Controls.GetChildIndex(bs[i]).ToString();
                bs[i].Text = aa;
            }


        }


    }
}
