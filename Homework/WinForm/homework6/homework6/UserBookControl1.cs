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
            btn.Text = text;
            booktip.Text = "图书"+text;
        }

        //自定义一个 事件
        internal event Action<BookInfo> BookEvent;

        private void InitBtn()
        {
            btn.Click += btn_Click;
        }

        private void btn_Click(object? sender, EventArgs e)
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
        private BookInfo _editBook;
        public BookInfo EditBook
        { 
            get => _editBook;
            set 
            { 
                _editBook = value;
                if (value != null)
                {
                    //自动回填到各个文本框
                    nameInp.Text = value.BookName;
                    authorInp.Text = value.Author;
                    priceInp.Text = value.Price.ToString();
                    markInp.Text = value.Mark;
                }
            }
        }



    }
}
