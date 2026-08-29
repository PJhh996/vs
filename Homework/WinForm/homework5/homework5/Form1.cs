namespace homework5
{
    public partial class Form1 : Form
    {
        AddForm add = new AddForm();
        public Form1()
        {
            InitializeComponent();
            InitBook();
        }
        private void InitBook()
        {
            button1.Click += Add_Click;
        }

        private void Add_Click(object? sender, EventArgs e)
        {
            add.Show();
        }
    }
}
