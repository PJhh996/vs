using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace day13
{
    public partial class game2 : Form
    {
        public game2()
        {
            InitializeComponent();
            this.Shown += Game2_Shown;

        }


        private Random random = new Random();//生成随机数 实例的对象
        private System.Windows.Forms.Timer getlableTimer = new System.Windows.Forms.Timer();
        private List<LabelAndTimer> labTimerList = new List<LabelAndTimer>();
        private int score = 0;
        private void Game2_Shown(object? sender, EventArgs e)
        {
            //游戏初始化
            getlableTimer.Interval = 800;
            //绑定事件  定时器触发事件
            getlableTimer.Tick += GetlableTimer_Tick;//间隔一秒就触发一次
            //绑定一个键盘按下时间
            this.KeyPreview = true;
            this.ActiveControl = null;
            this.KeyUp += Game2_KeyUp;
        }

        private void Game2_KeyUp(object? sender, KeyEventArgs e)
        {
            //遍历list，将labTimerList里面 的lab.text转变为Enum枚举类型
            for (int i = 0; i < labTimerList.Count; i++)
            {
                if (Enum.TryParse(labTimerList[i].lab.Text, true, out Keys key))
                {
                    if (e.KeyCode != key)continue;
                    //否则删除lab
                    panel1.Controls.Remove(labTimerList[i].lab);
                    //停止对应定时器
                    labTimerList[i].labTimer.Stop();
                    //删除list里面的lab
                    labTimerList.RemoveAt(i);
                    //加分加分
                    label2.Text = (++score).ToString();
                }
            }
        }

        int sleep = 2;

        private void GetlableTimer_Tick(object? sender, EventArgs e)
        {
            label4.Text = sleep.ToString();
            if (score > 20) label4.Text = (sleep+1).ToString();
            if (score > 50) label4.Text = (sleep + 2).ToString();
            if (score > 100) label4.Text = (sleep + 3).ToString();

            //一秒生成一个
            //创建label放置在penel里面
            Label lab = new Label();
            //初始化设置一下 lab的样式
            lab.Text = ((char)random.Next(65, 91)).ToString();
            lab.Size = new Size(30, 30);
            lab.Font = new Font("微软雅黑", 13F, FontStyle.Bold, GraphicsUnit.Point);
            lab.Location = new Point(random.Next(panel1.Width - lab.Width), 0);
            //添加到容器panel中
            panel1.Controls.Add(lab);
            //设置一个属于 这个lab的定时器
            System.Windows.Forms.Timer lTimer = new();
            lTimer.Interval = 10;//每隔一段时间下落一段距离
            lTimer.Tick += (object sender ,EventArgs e) =>labDown(lab) ;
            //启动他的定时器
            lTimer.Start();
            //记录到 labTimerList中
            labTimerList.Add(new LabelAndTimer(lab, lTimer));
        }

        private void labDown(Label lae)
        {
            //定时开始，lab开始落下
            lae.Top += sleep;//距离panel顶部的距离加2加2
            if (score > 20) lae.Top += sleep+1;
            if (score > 50) lae.Top += sleep+2;
            if (score > 100) lae.Top += sleep+3;
            
            if (lae.Top >= panel1.Height - lae.Height)
            {
                //停止定时器
                getlableTimer.Stop();
                labTimerList.ForEach(item => item.labTimer.Stop());
                //清空list里面的内容 还有 panel里面的lab
                labTimerList.Clear();
                panel1.Controls.Clear();
                MessageBox.Show("Game Orve！！！");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //点击开始按钮触发事件
            //初始分数为0
            score = 0;
            label4.Text = sleep.ToString();
            label2.Text = "0";
            //启动时钟
            getlableTimer.Start();

        }
    }



    public class LabelAndTimer
    {
        public Label lab { get; set; }
        public System.Windows.Forms.Timer labTimer { get; set; }

        public LabelAndTimer(Label la, System.Windows.Forms.Timer tm)
        {
            lab = la;
            labTimer = tm;
        }


    }

}
