using Cognex.VisionPro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace day13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.Shown += Form1_Shown;
            this.FormClosing += Form1_FormClosing;
            
        }


        private void Button1_Click(object sender, EventArgs e)
        {
            //点击按钮触发事件
            

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();//强制关闭当前进程
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            //获取相机
            //打开时获取相机
            CogFrameGrabbers gras = new CogFrameGrabbers();
            //获取单个相机
            ICogFrameGrabber gra = gras[0];
            //设置相机
            ICogAcqFifo Acq = gra.CreateAcqFifo("Generic GigEVision (Mono)",
                CogAcqFifoPixelFormatConstants.Format8Grey,
                0,
                true
            );
            //设置曝光
            Acq.OwnedExposureParams.Exposure = 70;
            //设置 延迟
            Acq.OwnedGigEVisionTransportParams.LatencyLevel = 1;

            //自动触发
            Acq.OwnedTriggerParams.TriggerEnabled = true;//打开相机监听 触发器信号（光电感应）
            Acq.OwnedTriggerParams.TriggerModel = CogAcqTriggerModelConstants.Auto;//全自动

            //硬件半自动
            //Acq.OwnedTriggerParams.TriggerEnabled = true;
            //Acq.OwnedTriggerParams.TriggerModel = CogAcqTriggerModelConstants.Semi;//半自动

            //绑定事件
            Acq.Complete += Acq_Complete;

            //Acq.StartAcquire();//半自动或手动时使用，自动使用会报错

            button1.Click += Button1_Click;


        }

        private void Acq_Complete(object sender, CogCompleteEventArgs e)
        {
            //读取 取像队列 状态
            ICogAcqFifo Acq = sender as ICogAcqFifo;
            Acq.GetFifoState(out int _,out int NumReady,out bool _);
            if (NumReady > 0)
            {

            }

        }
    }
}
