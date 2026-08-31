using homework5.USctrl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace homework5
{
    public partial class AddForm : Form
    {
        //接收主窗口 传过来的 流式布局
        private FlowLayoutPanel _flow;
        public List<Dictionary<string,dynamic>> bookList = new List<Dictionary<string,dynamic>>();       
        public AddForm()
        {
            InitializeComponent();
            //InitAdd();
        }
        public AddForm(FlowLayoutPanel flow) 
        {
            InitializeComponent();
            _flow = flow;
            InitAdd();
        }
        private void InitAdd()
        {
            addBtn.Click += AddBtn_Click;
        }

        private void AddBtn_Click(object? sender, EventArgs e)
        {
            //获取 输入框信息
            string bookname = bNameTb.Text;
            string author = auNameTb.Text;
            string price = priceTb.Text;
            string mark = markTb.Text;
            Dictionary<string, dynamic> bookDic = new()
            {
                ["书名"] = bookname,
                ["作者"] = author,
                ["价格"] = price,
                ["标签"] = mark,
                ["是否借出"] = false
            };

            bookList.Add(bookDic);
            UserBook book = new UserBook(bookname, author,price,mark);
            _flow.Controls.Add(book);
            MessageBox.Show("添加成功");
        }
    }
}
