namespace homework1
{
    public partial class Form1 : Form
    {
        private int speed = 5;
        public Form1()
        {
            InitializeComponent();
            InitMove();
            InitESC();
        }

        private void InitESC()
        {
            this.KeyUp += Form1_KeyUp;
        }

        private void Form1_KeyUp(object? sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            this.Close();
        }

        private void InitMove()
        {
            this.KeyDown += this_KeyDown;
        }

        private void this_KeyDown(object sender, KeyEventArgs e)
        {
            Point pi = panel1.Location;
            switch (e.KeyCode)
            {
                case Keys.A:
                    pi.X -= speed;
                    break;
                case Keys.D:
                    pi.X += speed;
                    break;
                case Keys.W:
                    pi.Y -= speed;
                    break;
                case Keys.S:
                    pi.Y += speed;
                    break;
                default:
                    break;
            }
            if (pi.X < 0) pi.X = 0;
            if (pi.X + panel1.Width > this.Width) pi.X = this.Width - panel1.Width;
            if (pi.Y < 0) pi.Y = 0;
            if (pi.Y + panel1.Height > this.Height) pi.Y = this.Height - panel1.Height;
            panel1.Location = pi;
        }
    }
}
