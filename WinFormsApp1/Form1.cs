namespace WinFormsApp1
{
    public partial class Names : Form
    {
        public Names()
        {
            InitializeComponent();
        }

        private void Names_Load(object sender, EventArgs e)
        {

        }

        private void Name_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // 检查文本框不为空，且列表框中不包含该名称
            if (!string.IsNullOrWhiteSpace(txtName.Text) && !lstNames.Items.Contains(txtName.Text))
            {
                // 将名称添加到列表框
                lstNames.Items.Add(txtName.Text);
            }
        }

        private void lstNames_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
