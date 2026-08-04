namespace zuoye3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dataGridView1.Rows.Add(1, "烤鸭", "烤类", "小明", "138******56", "一号桌", "已下单");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
