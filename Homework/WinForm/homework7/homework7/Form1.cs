using System.Reflection.Emit;

namespace homework7
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Timer MyTimer1 { get; set; }
        
        public Form1()
        {
            InitializeComponent();
            show();
            ShowTime();
        }
        private void ShowTime()
        {
            MyTimer1 = new System.Windows.Forms.Timer();
            MyTimer1.Interval = 1000;
            MyTimer1.Tick += (object snender, EventArgs e) => show();

            MyTimer1.Start();
        }
        private void show()
        {
            // 获取当前时间对象
            DateTime dt = DateTime.Now;
            // 获取小时
            var hour = dt.Hour.ToString();
            // 分钟
            var minute = dt.Minute.ToString();
            // 秒速
            var second = dt.Second.ToString();
            pictureBox3.Image = Image.FromFile(@"./images/maohao.png");
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.Image = Image.FromFile(@"./images/maohao.png");
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            // @"./images/数字.png"
            string timeStr = hour.PadLeft(2, '0') + minute.PadLeft(2, '0') + second.PadLeft(2, '0');
            //组织一下控件在数组中
            var picArr = new PictureBox[] {
                    pictureBox1,pictureBox2,pictureBox4,
                    pictureBox5,pictureBox7,pictureBox8
                };
            for (int i = 0; i < picArr.Length; i++)
            {
                picArr[i].SizeMode = PictureBoxSizeMode.StretchImage;
                picArr[i].Image = Image.FromFile(@"./images/" + timeStr[i] + ".png");
            }

            DateTime nationalDay = new DateTime(2026, 10, 1);
            TimeSpan ts = nationalDay - DateTime.Now;
            label1.Text = $"距离国庆还有：{ts.Days}天{ts.Hours}时{ts.Minutes}分{ts.Seconds}秒";

        }


    }
}
