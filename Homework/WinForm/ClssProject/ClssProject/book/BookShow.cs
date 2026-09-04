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
            //table1.CellClick += Table1_CellClick;
            table1.CellButtonClick += Table1_CellButtonClick;
        }

        private void Table1_CellButtonClick(object sender, AntdUI.TableButtonEventArgs e)
        {
            //表格按钮点击事件
            // e 事件参数对象
            //e.Record 获取点击行的数据
            //e.btn 点击触发的按钮
            System.Data.DataRow book = e.Record as System.Data.DataRow;
            if (e.Btn.Text == "编辑")
            {
                BookAddAndEdit bookEdit = new BookAddAndEdit("编辑", book["id"].ToString());
                bookEdit.Show();
                this.Hide();
                bookEdit.FormClosed += (object sender, FormClosedEventArgs e) =>
                {
                    this.Show();
                    showBook();
                };
            }
            else if (e.Btn.Text == "删除")
            {
                //调用删除方法
                bookDel(book["id"].ToString());
            }
            else if (e.Btn.Text == "借书" || e.Btn.Text == "还书")
            {
                borrowReturn(e.Btn.Text, book["name"].ToString(), book["id"].ToString(), book["is_borrow"].ToString());
            }

        }

        private async void borrowReturn(string obj, string name, string id, string isborrow)
        {
            if (obj == "借书" && isborrow == "1")
            {
                MessageBox.Show($"《{name}》已被人借走");
                return;
            }
            if (obj == "还书" && isborrow == "2")
            {
                MessageBox.Show($"《{name}》还在书库里");
                return;
            }

            //查找对应的图书数据
            string sql = "update book set is_borrow=@is_borrow where id=@id ";
            await mySql.ConAndHandler(sql, cmd =>
            {
                string oneOrtwo = isborrow == "1" ? "2" : "1";//等于1就换成2，等于2就换成1
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@is_borrow", oneOrtwo);
                int row = cmd.ExecuteNonQuery();
                if (row > 0)
                {
                    MessageBox.Show($"《{name}》成功" + obj);
                    showBook();
                }
                else
                {
                    MessageBox.Show($"《{name}》{obj}失败");
                }


                return true;
            });

        }

        private async void bookDel(string id)
        {
            //点击删除按钮时触发事件所调用的函数
            //展示 提示框 询问是否删除
            DialogResult res = MessageBox.Show("是否删除？", "删除操作", MessageBoxButtons.YesNo);
            if (res == DialogResult.No) return;
            //要执行的sql语句
            string sql = "delete from book where id = @id";
            await mySql.ConAndHandler(sql, cmd =>
            {
                cmd.Parameters.AddWithValue("@id", id);
                int row = cmd.ExecuteNonQuery();
                if (row > 0)
                {
                    MessageBox.Show("删除成功！");
                    showBook();
                }
                else
                {
                    MessageBox.Show("删除失败");
                }

                return true;
            });


        }

        //private async void Table1_CellClick(object sender, AntdUI.TableClickEventArgs e)
        //{
        //    //TableClickEventArgs e
        //    //e.ColumnIndex 列下标
        //    //e.RowIndex 行下标
        //    //e.Column 列对象    key==> 列表名称           
        //    //e.Record 这一行数据
        //    //MessageBox.Show(e.ColumnIndex.ToString());
        //    //MessageBox.Show(e.RowIndex.ToString());
        //    //MessageBox.Show(e.Column.Key.ToString());
        //    //e.Record
        //    //System.Data.DataRow Book = e.Record as System.Data.DataRow;
        //    //MessageBox.Show(Book["name"].ToString());
        //    //MessageBox.Show(Book[1].ToString());

        //    //获取点击的那一行数据 
        //    if (e.RowIndex == 0 || e.Column.Key != "hander") return;
        //    System.Data.DataRow book = e.Record as System.Data.DataRow;
        //    DialogResult res = MessageBox.Show("编辑还是删除？\n是 = 编辑\n否 = 删除","删除编辑", MessageBoxButtons.YesNoCancel);
        //    if (res == DialogResult.Yes)
        //    {
        //        //编辑逻辑
        //        //展示编辑窗口
        //        BookAddAndEdit bookEdit = new BookAddAndEdit("编辑", book["id"].ToString());
        //        bookEdit.Show();
        //        this.Hide();
        //        bookEdit.FormClosed += BookEdit_FormClosed;
        //    }
        //    else if(res == DialogResult.No)
        //    {
        //        //删除逻辑
        //        string del = "delete from book where id = @id";
        //        await mySql.ConAndHandler(del, cmd => {
        //            cmd.Parameters.AddWithValue("@id", book["id"].ToString());
        //            int row = cmd.ExecuteNonQuery();
        //            if (row > 0)
        //            {
        //                MessageBox.Show("删除成功");
        //                showBook();
        //            }
        //            else {
        //                MessageBox.Show("删除失败");
        //            }
        //            return true;
        //        });
        //    }
        //}

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

        private async void showBook() //显示 刷新表方法
        {
            await mySql.ConAndHandler("select * from book", cmd =>
            {
                //创建适配器
                MySqlDataAdapter Ada = new MySqlDataAdapter(cmd);
                //创建内存表
                DataTable dt = new DataTable();
                //填充数据
                Ada.Fill(dt);
                table1.DataSource = dt;


                //设置表头====================================================================
                table1.Columns.Clear();//先清除 再重新填充
                table1.Bordered = true;
                //table1.Dock = DockStyle.Fill;
                table1.Columns = new AntdUI.ColumnCollection()
                {
                     new AntdUI.Column("id","编号")
                     {
                        Render=(object val,object cel,int index )=> index+1
                     }.SetAlign(),
                     new AntdUI.Column("name","书名").SetAlign(),
                     new AntdUI.Column("author","作者").SetAlign(),
                     new AntdUI.Column("price","价格").SetAlign(),
                     new AntdUI.Column("label","标签").SetAlign(),
                     new AntdUI.Column("is_borrow","借阅"){
                     Render=(object val,object cel,int index )=> val.ToString()=="1"?"已借阅":"在书架"
                    }.SetAlign()
                };
                //var handlerCol = new AntdUI.Column("handler","操作");
                //handlerCol.Render = (object val, object cel, int index) => "删除 | 编辑";
                //table1.Columns.Add(handlerCol);

                var handlerButton = new AntdUI.Column("handler", "操作");
                handlerButton.SetAlign();
                handlerButton.Render = (object val, object cel, int index) =>
                {
                    var btns = new AntdUI.CellLink[] {
                        new AntdUI.CellButton("edit","编辑",AntdUI.TTypeMini.Default),
                        new AntdUI.CellButton("delete","删除",AntdUI.TTypeMini.Default)
                    };
                    return btns;
                };
                table1.Columns.Add(handlerButton);

                var borrowButton = new AntdUI.Column("isborrow", "是否借阅").SetAlign();//SetAlifn()让表头里面的内容居中
                borrowButton.Render = (object val, object cel, int index) =>
                {
                    return new AntdUI.CellLink[] {
                        new AntdUI.CellButton("borrow","借书",AntdUI.TTypeMini.Default),
                        new AntdUI.CellButton("return","还书",AntdUI.TTypeMini.Default)
                    };
                };
                table1.Columns.Add(borrowButton);
                return true;
            });
        }






    }
}
