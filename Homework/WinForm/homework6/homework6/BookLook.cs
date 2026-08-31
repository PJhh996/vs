using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;

namespace homework6
{
    public partial class BookLook : Form
    {
        public BookLook()
        {
            InitializeComponent();
            Lookbook();
        }
        private void Lookbook()
        {
            if (!File.Exists("./book.json")) 
            {
                MessageBox.Show("暂时没有书籍");
                this.Close();
            }
            //读取文件
            string jsonStr = File.ReadAllText("./book.json");
            List<BookInfo> bookList = JsonSerializer.Deserialize<List<BookInfo>>(jsonStr);
            table1.DataSource = bookList;//控件 的数据属性     把一整行数据交给表格
            //表格自动生成行列 自动填充内容
            //重置表头
            table1.Controls.Clear();
            table1.Columns = new AntdUI.ColumnCollection {
                new AntdUI.Column("Id", "编号")
                {
                    Render = (object val,object cel,int index ) =>index.ToString()

                },
                new AntdUI.Column("BookName", "书名"),
                new AntdUI.Column("Author", "作者"),
                new AntdUI.Column("Price", "价格"),
                new AntdUI.Column("Mark", "标签"),
                new AntdUI.Column("IsBorrow", "是否借阅"){
                    // val 单元的值, cel: 行数据, index 行号
                    Render = (object val,object cel,int index) =>
                    {
                        return (bool)val?"已借阅":"书架中";
                    }
                },
            };
            table1.Columns.Add(new AntdUI.Column("Handler", "操作")
            {
                Render = (object val, object cel, int index) => "删除"
            });
            table1.Columns.Add(new AntdUI.Column("Handler2", "操作")
            {
                Render = (object val, object cel, int index) => "编辑"
            });

            table1.CellClick += Table1_CellClick;

        }

        private void Table1_CellClick(object sender, AntdUI.TableClickEventArgs e)
        {
            BookInfo bookInfo = (e.Record as BookInfo);
            if (e.ColumnIndex.ToString() == "6")
            { 
                //这是删除的逻辑
            }
            if (e.ColumnIndex.ToString() == "7")
            {
                //这是编辑的逻辑

                new BookEdi(bookInfo.Id).Show();
            }
        }
    }
}
