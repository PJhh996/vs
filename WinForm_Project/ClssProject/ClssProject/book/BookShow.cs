using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ClssProject.book
{
    public partial class BookShow : Form
    {
        private MySql mySql { get; set; } = new MySql("test");
        public BookShow()
        {
            InitializeComponent();
            showBook();
            //给表格绑定 点击事件
            table1.CellClick += Table1_CellClick;
        }

        private void Table1_CellClick(object sender, AntdUI.TableClickEventArgs e)
        {
            //TableClickEventArgs e
            //e.ColumnIndex 列下标
            //e.RowIndex 行下标
            //e.Column 列对象    key==> 列表名称           
            //e.Record 这一行数据
            //MessageBox.Show(e.ColumnIndex.ToString());
            //MessageBox.Show(e.RowIndex.ToString());
            //MessageBox.Show(e.Column.Key.ToString());
            //e.Record
            //System.Data.DataRow Book = e.Record as System.Data.DataRow;
            //MessageBox.Show(Book["name"].ToString());
            //MessageBox.Show(Book[1].ToString());

            //获取点击的那一行数据 
            System.Data.DataRow book = e.Record as System.Data.DataRow;
            DialogResult res = MessageBox.Show("编辑还是删除？\n是 = 编辑\n否 = 删除","删除编辑",MessageBoxButtons.YesNoCancel);
            if (res == DialogResult.Yes)
            {
                //编辑逻辑
                //展示编辑窗口
                BookAddAndEdit bookEdit = new BookAddAndEdit("编辑", book["id"].ToString());
                bookEdit.Show();
                this.Hide();
                bookEdit.FormClosed += BookEdit_FormClosed;
            }
            else if(res == DialogResult.No)
            {
                //删除逻辑
                string del = "delete from book where id = @id";
                mySql.ConAndHandler(del, cmd => {
                    cmd.Parameters.AddWithValue("@id", book["id"].ToString());
                    int row = cmd.ExecuteNonQuery();
                    if (row > 0)
                    {
                        MessageBox.Show("删除成功");
                        showBook();
                    }
                    else {
                        MessageBox.Show("删除失败");
                    }
                });
            }
        }

        private void BookEdit_FormClosed(object? sender, FormClosedEventArgs e)
        {
            this.Show();
            showBook();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BookAddAndEdit bookAdd = new BookAddAndEdit("新增");
            bookAdd.Show();
            this.Hide();
            bookAdd.FormClosed += BookAdd_FormClosed;
        }

        private void BookAdd_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
            showBook();
        }

        private void showBook() //显示 刷新表方法
        {
            mySql.ConAndHandler("select * from book", cmd =>
            {
                //创建适配器
                MySqlDataAdapter Ada = new MySqlDataAdapter(cmd);
                //创建内存表
                DataTable dt = new DataTable();
                //填充数据
                Ada.Fill(dt);
                table1.DataSource = dt;
                //设置表头
                table1.Columns.Clear();//先清除 再重新填充
                table1.Bordered = true;
                //table1.Dock = DockStyle.Fill;
                table1.Columns = new AntdUI.ColumnCollection()
                {
                     new AntdUI.Column("id","编号")
                     {
                        Render=(object val,object cel,int index )=> index+1
                     },
                     new AntdUI.Column("name","书名"),
                     new AntdUI.Column("author","作者"),
                     new AntdUI.Column("price","价格"),
                     new AntdUI.Column("label","标签"),
                     new AntdUI.Column("is_borrow","借阅"){
                     Render=(object val,object cel,int index )=> val.ToString()=="1"?"已借阅":"在书架"
                    }
                };
                var handlerCol = new AntdUI.Column("handler","操作");
                handlerCol.Render = (object val, object cel, int index) => "删除 | 编辑";
                table1.Columns.Add(handlerCol);

            });
        }

    }
}
