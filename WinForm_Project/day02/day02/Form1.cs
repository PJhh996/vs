namespace day02
{
    public partial class Form1 : Form
    {

        
        private Button btn2;
        private Label lab1;
        private Panel panel1;
        private Button btn1;

        public void btn()
        {
            btn2 = new Button();
            btn2.Location = new Point(400, 0);
            btn2.Size = new Size(100, 50);
            btn2.Name = "btn2";
            btn2.Text = "btn2按钮  ";
            this.Controls.Add(btn2);

            btn1 = new Button()
            {
                Location = new Point(200, 200),
                Size = new Size(100, 50),
                Name = "btn1",
                Text = "确定",
            };
            this.Controls.Add(btn1);

            lab1 = new Label()
            {
                Location = new Point(0, 60),
                Size = new Size(100, 50),
                Name = "lab1",
                Text = "lab内容  "
            };
            this.Controls.Add(lab1);
        }

        public void panel()
        { 
            panel1 = new Panel();
            panel1.Location = new Point(200, 200);
            panel1.Size = new Size(400, 800);
            panel1.Name = "pl1";


            Button btn3 = new Button();
            btn3.Location = new Point(0,0);
            btn3.Size = new Size(100, 50);
            btn3.Name = "btn3";
            btn3.Text = "1";

            Button btn4 = new Button();
            btn4.Location = new Point(0,60);
            btn4.Size = new Size(100, 50);
            btn4.Name = "btn4";
            btn4.Text = "2";

            Button btn5 = new Button();
            btn5.Location = new Point(120, 0);
            btn5.Size = new Size(100, 50);
            btn5.Name = "btn5";
            btn5.Text = "3";

            Button btn6 = new Button();
            btn6.Location = new Point(120, 60);
            btn6.Size = new Size(100, 50);
            btn6.Name = "btn6";
            btn6.Text = "4";
            //panel1.Controls.Add(btn3);

            //this.Controls.Add(panel1);

            Control[] btnS = [btn3, btn4, btn5, btn6];
            //panel1.Controls.AddRange(btnS);
            this.Controls.AddRange(btnS);

            //this.Controls.Remove(btn6);
            //this.Controls.RemoveAt(0);

            //this.Controls.Clear();

            this.Controls.SetChildIndex(btn6,1);

        }


        public Form1()
        {
            InitializeComponent();
            //btn();
            panel();
        }


    }
}
