using MySqlConnector;
using System.Data;
using System.Runtime.InteropServices.Marshalling;
using System.Security.Policy;
using System.Web;

namespace day08
{
    public partial class Form1 : Form
    {
        string ConnStr =
            "server=localhost;port=3306;database=test;uid=root;pwd=root;charset=utf8";
        public Form1()
        {
            InitializeComponent();

            using (MySqlConnection conn = new MySqlConnection(ConnStr))
            {
                conn.Open();//打开链接

                //写sql语句
                string Sql = "select * from user";//查找表格所有 数据
                //创建命令对象   sql语句
                using (MySqlCommand Comm = new MySqlCommand(Sql, conn))
                {
                    //创建适配器 ==> 查询的数据库数据 和 内存数据集关联
                    MySqlDataAdapter Ada = new MySqlDataAdapter(Comm);
                    //创建内存表
                    DataTable dt = new DataTable();
                    //把数据填充进表
                    Ada.Fill(dt);
                    dataGridView1.DataSource = dt;

                }


            }

        }

        private void button1_Click(object sender, EventArgs e)//查找
        {
            //拿到文本框内容
            string str = textBox1.Text;
            //创建数据表链接
            using (MySqlConnection conn = new MySqlConnection(ConnStr))
            {
                //打开链接
                conn.Open();
                //写sql语句
                //string sql = "select * from user where username = @username";
                //string sql = "select * from user where gender = @username";
                string sql = "select * from user where username like concat('%',@username,'%')";
                //创建命令对象
                using (MySqlCommand comm = new MySqlCommand(sql, conn))
                {
                    //comm 的参数填充
                    comm.Parameters.AddWithValue("@username", str);
                    //创建内存表
                    MySqlDataAdapter Ada = new MySqlDataAdapter(comm);
                    //创建内存表
                    DataTable dt = new DataTable();
                    Ada.Fill(dt);//数据填充
                    dataGridView1.DataSource = dt;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //创建数据表链接
            using (MySqlConnection conn = new MySqlConnection(ConnStr))
            {
                //打开链接
                conn.Open();

                //写sql语句   增、删、改 数据库里面的数据 不返回表格 
                //只会告诉你一共影响多少行  必须用 ExecuteNonQuery()，返回int整数
                //string sql = "insert into user (username,password,age,gender,banji) values(@username,@password,@age,@gender,@banji)";
                //string sql = "insert into user(username,age,gender,banji,password) value(@username,@age,@gender,@banji,@password)";
                //string sql = "delete from user where username = @username";
                //string sql = "update user set username = @username,gender = @gender where id = @id";
                string sql = "update user set gender = '男',age = age + 1 where id = 1";


                //创建命令对象
                using (MySqlCommand comm = new MySqlCommand(sql, conn))
                {
                    /**************************查询返回表才能用********************/
                    ////创建内存表
                    //MySqlDataAdapter Ada = new MySqlDataAdapter(comm);
                    ////创建内存表
                    //DataTable dt = new DataTable();
                    //Ada.Fill(dt);//数据填充
                    //dataGridView1.DataSource = dt;
                    /***************************************************************/

                    //comm 的参数填充
                    //comm.Parameters.AddWithValue("@username", "刘德华");
                    //comm.Parameters.AddWithValue("@password", "123456");
                    //comm.Parameters.AddWithValue("@age", 19);
                    //comm.Parameters.AddWithValue("@gender", "男");
                    //comm.Parameters.AddWithValue("@banji", "02班");

                    //comm.Parameters.AddWithValue("@username","刘德华");

                    //comm.Parameters.AddWithValue("@id",26);
                    //comm.Parameters.AddWithValue("@username","王宝强");
                    //comm.Parameters.AddWithValue("@gender","女");


                    //命令对象.ExecuteNonQuery() 
                    int row = comm.ExecuteNonQuery();
                    MessageBox.Show(row.ToString());


                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //创建数据表链接
            using (MySqlConnection conn = new MySqlConnection(ConnStr))
            {
                //打开链接
                conn.Open();
                //写sql语句
                //string sql = "";
                //string sql = "select * from user where id=1";
                string sql = "select * from user where id=100";
                //创建命令对象
                using (MySqlCommand comm = new MySqlCommand(sql, conn))
                {
                    //comm 的参数填充
                    //comm.Parameters.AddWithValue("@username", "");

                    //// ExecuteScalar: 获取聚合查询结果
                    //Object res = comm.ExecuteScalar();
                    //label1.Text = res.ToString();

                    //结果读取对象
                    MySqlDataReader Reader = comm.ExecuteReader();

                    //label1.Text = Reader.FieldCount.ToString();//获得结果的列数
                    //label1.Text = Reader.HasRows.ToString();//判断是否 至少有一行结果

                    bool isRows = Reader.Read(); // 结果对象读取数据
                    // 结果对象 是否读到数据
                    label1.Text = isRows.ToString();

                    //label1.Text = Reader.GetInt32(3).ToString();
                    //label1.Text = Reader.GetString(2);

                    //label1.Text = Reader.GetString("banji");
                    //label1.Text = Reader.GetDateTime("create_at").ToString();



                }
            }
        }





    }
}