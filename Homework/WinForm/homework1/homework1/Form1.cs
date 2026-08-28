namespace homework1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            init();
        }

        private string[] picArr = [@"./images/cat.jpg", @"./images/bird.jpg", @"./images/eagle.jpg"];
        int index = 0;
        List<Button> btnList = new();
        private void init()
        {
            //将button放进一个list里面
            btnList.AddRange(button1, button2, button3);
            //将label集合遍历
            Label[] labs = [label1, label2];

            foreach (Label item in labs) item.Click += Labs_Click;

            foreach (Button item in btnList) item.Click += Btn_Click;
            PicBtn();

        }

        private void Labs_Click(object sender, EventArgs e)
        {
            Label lab = (Label)sender;
            if (lab.Text == "<")
            {
                index = index == 0 ? picArr.Length - 1 : --index;

                PicBtn();
            }
            else
            {
                index = index == picArr.Length - 1 ? 0 : ++index;
                PicBtn();
            }
        }


        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            index = btnList.IndexOf(btn);
            PicBtn();
        }

        private void PicBtn()
        {
            pictureBox1.Image = Image.FromFile(picArr[index]);
            btnList.ForEach(item =>
            {
                item.BackColor = Color.DarkGray;
                item.ForeColor = Color.Black;
            });
            btnList[index].BackColor = Color.Green;
            btnList[index].ForeColor = Color.White;
        }

    }
}
