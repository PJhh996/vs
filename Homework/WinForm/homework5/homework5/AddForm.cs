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
        List<Dictionary<string,dynamic>> bookList = new List<Dictionary<string,dynamic>>();
        

        public AddForm()
        {
            InitializeComponent();
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
                ["作者"] = bookname,
                ["价格"] = bookname,
                ["标签"] = bookname,
                ["是否借出"] = false
            };

            bookList.Add(bookDic);
            MessageBox.Show("添加成功");
        }
    }
}
