namespace zuoye2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dataGridView1.Rows.Add("Content-Type", "application/x-www-form-urlencoded");
            dataGridView1.Rows.Add("username", "byhy");
            dataGridView1.Rows.Add("password", "88888888");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
