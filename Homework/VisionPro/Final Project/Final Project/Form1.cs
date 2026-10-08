using Cognex.VisionPro;
using Cognex.VisionPro.FGGigE;
//using Cognex.VisionPro.Interop;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Shown += Form1_Shown;
        }

        private ICogAcqFifo Acq { get; set; }
        private void Form1_Shown(object sender, EventArgs e)
        {
            Console.WriteLine("启动项目成功，请设置参数");
        }



        //***********************************连接相机***********************************
        #region 链接相机
        private void button6_Click(object sender, EventArgs e)
        {
            //获取相机
            //CogFrameGrabberGigEs Grabbers = new CogFrameGrabberGigEs();
            ICogFrameGrabber Grabber = new CogFrameGrabberGigEs()[0];
            //获取取像队列
            Acq = Grabber.CreateAcqFifo(
                Grabber.AvailableVideoFormats[1],
                CogAcqFifoPixelFormatConstants.Format8Grey,
                0,
                true
            );
            //设置相机
            Acq.OwnedGigEVisionTransportParams.LatencyLevel = 1;
            Acq.OwnedExposureParams.Exposure = 50;
            Acq.Complete += Acq_Complete;//开始取像事件
            Console.WriteLine("连接相机成功");
        }

        private void Acq_Complete(object sender, CogCompleteEventArgs e)
        {
            //获取取像队列状态
            Acq.GetFifoState(out int _, out int Num, out bool _);
            if (Num > 0)
            {

            }

        }
        #endregion//
        //******************************************************************************

    }
}
