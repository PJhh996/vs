using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace homework6
{
    public partial class BookEdi : Form
    {
        BookInfo BookInfo = new BookInfo();
        public BookEdi()
        {
            InitializeComponent();
        }

        public BookEdi(string Id)
        {
            InitializeComponent();
            InitEdi(Id);
        }
        List<BookInfo> bookList = new List<BookInfo>();
        BookInfo book;
        string jsonStr = "";
        private void InitEdi(string id) 
        { 
            
            jsonStr = File.ReadAllText("./book.json");
            bookList = JsonSerializer.Deserialize<List<BookInfo>>(jsonStr);
            book = bookList.Find(item => item.Id == id);
            userBookControl11.BookEvent += BookEdi_Event;
        }
        private void BookEdi_Event(BookInfo obj)
        {
            book.Id = obj.Id;
            book.Author = obj.Author;
            book.Price = obj.Price;
            book.Mark = obj.Mark;
            jsonStr = JsonSerializer.Serialize(bookList, new JsonSerializerOptions()
            {
                WriteIndented = true,
                AllowTrailingCommas = true,
                Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping
            });
            File.WriteAllText("./book.json", jsonStr);
            MessageBox.Show("新增图书成功");
            this.Close();

        }
    }
}
