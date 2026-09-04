using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace day11
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            //时钟
            var timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;//时间间隔
            //提前启动时钟，防止启动时没有值
            timer.Tick += (object sender, EventArgs e) => showTime();
            //启动时钟
            timer.Start();
            showTime();
        }

        private void showTime()
        {
            //获取时间
            TimeSpan time = DateTime.Parse("2026-10-1 0:0:0") - DateTime.Now;
            label1.Text = Math.Floor(time.TotalDays).ToString();// 简单记一下 英文意思 Total 总计
            label2.Text = Math.Floor(time.TotalHours % 24).ToString();
            label3.Text = Math.Floor(time.TotalSeconds % 60).ToString();
            label4.Text = Math.Floor(time.TotalMilliseconds % 60).ToString();

        }

    }
}
