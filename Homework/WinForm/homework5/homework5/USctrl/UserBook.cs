using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace homework5.USctrl
{
    public partial class UserBook : UserControl
    {
        public UserBook(string bookname, string author, string price, string mark)
        {
            InitializeComponent();
            bookLab.Text = bookname;
            authorLab.Text = author;
            priceLab.Text = price;
        }
        public UserBook()
        {
            InitializeComponent();
        }
    }
}
