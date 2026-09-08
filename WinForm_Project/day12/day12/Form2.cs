using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Text;
using System.Windows.Forms;

namespace day12
{
    public partial class Form2 : Form
    {
        //Class1 Radius = new Class1();

        //实例化定时器对象
        private System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        private int Num = 0;
        public Form2()
        {
            InitializeComponent();
            //给容器绑定画图事件
            panel1.Paint += Panel1_Paint;
            //初始化 定时器
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;//定时器触发事件
            timer.Start();
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            //获取秒数
            Num = DateTime.Now.Second;
            panel1.Invalidate();
        }
        private int Radius = 100;
        private int RadiusX = 150;
        private int RadiusY = 150;
        //刻度长度
        private int LongScale = 10;
        private int Count = 60;

        private void Panel1_Paint(object? sender, PaintEventArgs e)
        {
            //画钟表
            Graphics g = e.Graphics;//获取画图对象
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;//磨锯齿
            using (Pen penBlack = new Pen(Color.Black, 4))
            {
                //先画圆
                g.DrawArc(penBlack, RadiusX - Radius, RadiusY - Radius, 2 * Radius, 2 * Radius, 0, 360);
                //g.DrawEllipse(penBlack, 0, 0, 2 * RadiusX, 2 * RadiusY);//坐标不太会用
                var tmpLong = LongScale;//临时的刻度长度
                //循环画刻度
                for (int i = 0; i < Count; i++)
                {
                    if (i % 5 == 0) tmpLong = LongScale * 2;
                    var startX = Math.Cos((360 / Count) * i * Math.PI / 180) * Radius + RadiusX;
                    var startY = Math.Sin((360 / Count) * i * Math.PI / 180) * Radius + RadiusY;
                    var endX = Math.Cos((360 / Count) * i * Math.PI / 180) * (Radius - tmpLong) + RadiusX;
                    var endY = Math.Sin((360 / Count) * i * Math.PI / 180) * (Radius - tmpLong)+ RadiusY;
                    g.DrawLine(penBlack, (int)startX, (int)startY, (int)endX, (int)endY);
                    tmpLong = LongScale;
                }
                using (Pen penRed = new Pen(Color.Red, 4))
                {
                    var endX = Math.Cos(((360 / Count) * Num + 270) * Math.PI / 180) * (Radius - tmpLong) + RadiusX;
                    var endY = Math.Sin(((360 / Count) * Num + 270) * Math.PI / 180) * (Radius - tmpLong) + RadiusY;
                    g.DrawLine(penRed, RadiusX, RadiusY, (int)endX, (int)endY);
                }

            }
        }
    }
    public class DoubleBufferPanel : Panel
    {
        public DoubleBufferPanel()
        {
            //开启双缓冲，消除闪烁
            this.SetStyle(ControlStyles.UserPaint
                | ControlStyles.AllPaintingInWmPaint
                | ControlStyles.OptimizedDoubleBuffer, true);
            UpdateStyles();
        }
    }

}

