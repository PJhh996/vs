using MySqlConnector;
using System.Data;

namespace kaoshi2
{
    public partial class Form1 : Form
    {
        private MySQL mySql { get; set; } = new MySQL("test");
        public Form1()
        {
            InitializeComponent();
            this.Shown += CarInit;
        }

        private void CarInit(object sender, EventArgs e)
        {
            //初始化、
            //绑定事件
            button1.Click += AddCar;// 车辆新增
            button2.Click += AddUser;// 客户新增
            //表格显示 数据事件
            button3.Click += LookUser;
            ShowData("car");
        }

        private void LookUser(object? sender, EventArgs e)
        {
            //设置显示方法
            dataGridView1.DataSource =null;
            ShowData("user_info");
        }



        //显示 新增用户 界面
        private void AddUser(object? sender, EventArgs e)
        {
            CarManager.UserAdd User = new CarManager.UserAdd();
            User.Show();
            this.Hide();
            User.FormClosed += User_FormClosed;
        }
        //新增用户界面关闭 显示 隐藏的Form1
        private void User_FormClosed(object? sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        //显示 新增车辆 界面
        private void AddCar(object sender, EventArgs e)
        {
            CarManager.CarAdd Car = new CarManager.CarAdd();
            Car.Show();
            this.Hide();
            Car.FormClosed += Car_FormClosed;
        }
        //新增车辆关闭时 显示 From1
        private void Car_FormClosed(object? sender, FormClosedEventArgs e)
        {
            this.Show();
            ShowData("car");
        }



        private async void ShowData(string sql)//按钮点击，显示车辆数据
        {
            await mySql.ConAndHandler($"select * from {sql}", cmd =>
            {
                dataGridView1.DataSource = null;
                //创建适配器
                MySqlDataAdapter Ada = new MySqlDataAdapter(cmd);
                //创建内存表
                DataTable dt = new DataTable();
                //填充数据
                Ada.Fill(dt);
                dataGridView1.DataSource = dt;

                ////设置表头
                //dataGridView1.AutoGenerateColumns = false;//禁用数据源表头自动生成
                

                //// 设置行头
                //dataGridView1.RowHeadersVisible = false;
                //// 设置表数据为只读
                ////dataGridView1.ReadOnly = true;
                //// 设置表数据不能手动删除添加
                //dataGridView1.AllowUserToAddRows = false;
                //dataGridView1.AllowUserToDeleteRows = false;
                //// 表宽度自适应
                //dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                return true;
            });
        }

    }
}
