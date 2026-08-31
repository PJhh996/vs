using AntdUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace homework6
{
    public partial class UserBookControl1 : UserControl
    {
        public UserBookControl1()
        {
            InitializeComponent();
            InitBtn();
        }
        public UserBookControl1(string text)
        {
            InitializeComponent();
            InitBtn();
            addbtn.Text = text;
            booktip.Text = "图书"+text;
        }

        //自定义一个 事件
        internal event Action<BookInfo> BookEvent;

        private void InitBtn()
        {
            addbtn.Click += Addbtn_Click;
        }

        private void Addbtn_Click(object? sender, EventArgs e)
        {
            BookInfo bookInfo = new BookInfo()
            {
                Id = Guid.NewGuid().ToString(),
                BookName = nameInp.Text,
                Author = authorInp.Text,
                Price = double.Parse(priceInp.Text),
                Mark = markInp.Text,
                IsBorrow = false
            };
            BookEvent.Invoke(bookInfo);//执行委托,传输数据
        }

        //private BookInfo edibook;
        //private BookInfo EditBook
        //{
        //    get { return edibook; }
        //    set { edibook = value; }
        //}

    }
}
