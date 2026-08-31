using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Windows.Forms;

namespace homework6
{
    public partial class BookAdd : Form
    {
        public BookAdd()
        {
            InitializeComponent();
            //绑定事件接收数据
            UserControl.BookEvent += UserControl_BookAdd;
        }
        private string path = "./book.json";
        private void UserControl_BookAdd(BookInfo obj)
        {
            //新建一个list来接收数据
            List<BookInfo> bookList = new();
            string jsonStr = "";
            //判断有没有文件
            if (File.Exists(path))
            {
                jsonStr = File.ReadAllText(path);
                bookList = JsonSerializer.Deserialize<List<BookInfo>>(jsonStr);
            }
            BookInfo name = bookList.Find(item => item.BookName == obj.BookName);
            if (name != null) {
                Console.WriteLine("不能重复添加同一图书");
                return;
            }
            //将拿到的数据加到list中
            bookList.Add(obj);
            jsonStr = JsonSerializer.Serialize(bookList, new JsonSerializerOptions()
            {
                WriteIndented = true,
                AllowTrailingCommas = true,
                Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping
            });
            File.WriteAllText(path,jsonStr);
            MessageBox.Show("新增图书成功");
            this.Close();
        }
    }
}
