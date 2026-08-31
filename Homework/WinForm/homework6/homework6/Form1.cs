namespace homework6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            new BookAdd().Show();
        }

        private void Edibtn_Click(object sender, EventArgs e)
        {
            new BookEdi().Show();
        }

        private void Lookbtn_Click(object sender, EventArgs e)
        {
            new BookLook().Show();
        }
    }
}
