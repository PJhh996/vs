using System.Formats.Tar;

namespace day12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //一般容器都有画图事件paint 画图事件
            panel1.Paint += Panel1_Paint;
        }

        private void Panel1_Paint(object? sender, PaintEventArgs e)
        {
            //获取画图对象
            Graphics g = e.Graphics;
            //设置抗锯齿   消除图形毛边，让图形更光滑
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            //创建画笔/笔刷
            using (SolidBrush brushGreen = new SolidBrush(Color.Green))
            using (SolidBrush brushRed = new SolidBrush(Color.Red))
            //FromArgb 三元色 ，参数：透明度，红色，绿色，蓝色
            using (SolidBrush brushArgb = new SolidBrush(Color.FromArgb(255, 255, 255, 0)))
            using (Pen penRed = new Pen(Color.Red, 3))//参数：颜色，线宽
            using (Pen penGreen = new Pen(Color.Green, 6))
            using (Pen penArgb = new Pen(Color.FromArgb(255, 255, 255, 0), 6))
            {
                //填充矩形 参数：笔刷 ， 起始坐标x，y ，宽，高
                g.FillRectangle(brushRed, 10, 10, 200, 100);
                g.FillRectangle(brushGreen, 220, 10, 200, 100);
                g.FillRectangle(brushArgb, 430, 10, 200, 100);

                //画矩形 参数：画笔，起始坐标x，y，宽，高
                g.DrawRectangle(penGreen, 10, 110, 200, 100);
                g.DrawRectangle(penArgb, 220, 110, 200, 100);
                g.DrawRectangle(penRed, 430, 110, 200, 100);

                //画空心圆 圆对应矩形的起始坐标x，y
                g.DrawEllipse(penRed, 640, 10, 210, 210);

                //实心圆（填充）
                g.FillEllipse(brushGreen, 860, 10, 210, 210);

                //画椭圆、实心椭圆(红色边框，黄色填充)
                g.DrawEllipse(penRed, 10, 220, 200, 100);
                g.FillEllipse(brushArgb, 10, 220, 200, 100);

                //画线 参数：起始x，y，结束x，y
                g.DrawLine(penRed, 220, 220, 420, 220);
                g.DrawLine(penRed, 420, 220, 220, 320);
                g.DrawLine(penRed, 220, 320, 420, 320);

                //画文字
                Font f = new Font("微软雅黑", 9);//字体类型，字体大小
                //新建一个文字格式设置对象，默认参数
                StringFormat sf = new StringFormat();
                //sf.Alignment = StringAlignment.Center;//水平对齐
                sf.LineAlignment = StringAlignment.Center;//垂直对齐
                g.DrawString("我要画的文字Rain11", f, brushGreen, 220, 110);
                g.DrawString("我要画的文字Rain22", f, brushGreen, 220, 220, sf);//相对于该坐标对齐

                //画多边形
                Point[] points =
                {
                    new Point (1110,10),
                    new Point (1310,10),
                    new Point (1280,210),
                    new Point (1080,210),
                };
                g.DrawPolygon(penRed, points);
                g.FillPolygon(brushArgb, points);
                //三角形
                Point[] points1 =
                {   new Point (1110,10),
                    new Point (1310,10),
                    new Point (1280,210),
                };
                g.FillPolygon(brushGreen, points1);


                //等边三角形
                int Raduis = 100;
                int cx = 640 + 210 / 2;
                int cy = 10 + 210 / 2;

                Point[] points2 = new Point[3];//长度为3 的Point数组
                double[] angles = { 30, 150, 270 };//单词angles 是角度的意思
                //遍历角度  将角度转换为 坐标
                for (int i = 0; i < angles.Length; i++)
                {
                    var px = Math.Cos(angles[i] * Math.PI / 180) * Raduis + cx;
                    var py = Math.Sin(angles[i] * Math.PI / 180) * Raduis + cy;
                    points2[i] = new Point((int)px,(int)py);
                }
                g.DrawPolygon(penRed, points2);

                Point[] points3 = new Point[3];
                double[] angles1 = { 90, 210, 330 };//单词angles 是角度的意思
                for (int i = 0; i < angles.Length; i++)
                {
                    var px = Math.Cos(angles1[i] * Math.PI / 180) * Raduis + cx;
                    var py = Math.Sin(angles1[i] * Math.PI / 180) * Raduis + cy;
                    points3[i] = new Point((int)px, (int)py);
                }
                g.DrawPolygon(penRed, points3);

                //画弧线
                g.DrawArc(penRed, 10, 110, 200, 100,0,180);


            }
        }
    }
}
