namespace day11
{
    public partial class Form1 : Form
    {
        private BookClass book = new BookClass(1, "三国演义", 8.8, true);
        public Form1()
        {
            InitializeComponent();
            // 控件属性 数据绑定
            textBox1.DataBindings.Add("Text", book, "Name");
            label1.DataBindings.Add("Text", book, "Id", true, DataSourceUpdateMode.OnPropertyChanged);
            checkBox1.DataBindings.Add("checked", book, "isBorrow");


        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(book.Name);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            book.Name = "西游记";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(book.Id.ToString());
        }
        private void button4_Click(object sender, EventArgs e)
        {
            book.Id = 6666666;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text = "1234567";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show(book.isBorrow.ToString());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            book.isBorrow = !book.isBorrow;
        }
    }
}
