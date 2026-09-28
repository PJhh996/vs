using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace day11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        //连接机械臂
        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder fwType = new StringBuilder(128);
            StringBuilder version = new StringBuilder(128);
            int ret = DobotDll.ConnectDobot("COM3", 115200, fwType, version);
            if (ret == 0)
            {
                MessageBox.Show($"连接成功！\n固件:{fwType}\n版本:{version}");
            }
            else
            {
                MessageBox.Show($"连接失败，返回码:{ret}");
            }
        }


        //断开连接
        private void button2_Click(object sender, EventArgs e)
        {
            DobotDll.DisconnectDobot();
            MessageBox.Show("串口已断开");
        }
        private void button3_Click(object sender, EventArgs e)
        {
            // 创建指令对象
            HOMECmd homeCmd = new HOMECmd();
            // 设置指令队列编号
            UInt64 cmdIndex = 0;
            // 调用回零函数
            int ret = DobotDll.SetHOMECmd(ref homeCmd, false, ref cmdIndex);
            if (ret == 0)
            {
                MessageBox.Show("回零指令下发成功，请观察机械臂运动");
            }
            else
            {
                MessageBox.Show($"回零调用失败，返回码:{ret}");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int ret = DobotDll.SetQueuedCmdStartExec();
            if (ret == 0)
            {
                MessageBox.Show("队列开始执行，机械臂自动跑点位");
            }
            else
            {
                MessageBox.Show($"启动队列失败，返回码:{ret}");
            }
        }
    }
}
