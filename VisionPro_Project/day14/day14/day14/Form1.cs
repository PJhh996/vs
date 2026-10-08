using Cognex.VisionPro;
using Cognex.VisionPro.FGGigE;
using Cognex.VisionPro.ToolBlock;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace day14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Shown += Form1_Shown;
            this.FormClosed += Form1_FormClosed;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //强制杀死当前进程
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }
        private ICogAcqFifo Acq { get; set; }
        private CogToolBlock CTB {  get; set; }
        private void Form1_Shown(object sender, EventArgs e)
        {
            //加载方案
            CTB = CogSerializer.LoadObjectFromFile("./vpps/方案名.vpp") as CogToolBlock;
            Console.WriteLine("检测方案加载成功");

            //获取相机
            CogFrameGrabberGigEs Grabbers = new CogFrameGrabberGigEs();
            //获取单个相机
            ICogFrameGrabber Grabber = Grabbers[0];
            //获取相机 取像队列
            Acq = Grabber.CreateAcqFifo(
                Grabber.AvailableVideoFormats[1],
                CogAcqFifoPixelFormatConstants.Format8Grey,
                0,
                true
            );
            //设置相机
            Acq.OwnedGigEVisionTransportParams.LatencyLevel = 1;//延迟等级
            Acq.OwnedExposureParams.Exposure = 50;//设置曝光
            //绑定事件
            Acq.Complete += Acq_Complete;//获取队列完成后执行
            Console.WriteLine("相机加载成功");
        }

        private void Acq_Complete(object sender, CogCompleteEventArgs e)
        {
            //获取队列状态
            Acq.GetFifoState(out int _, out int NumReady, out bool _);
            if (NumReady > 0)
            {
                ICogImage Image = Acq.CompleteAcquireEx(new CogAcqInfo());//方法：等待相机采集完成，取出图像，并拿到这一帧采集的附加信息
                CTB.Inputs["OutputImage"].Value = Image;
                //开始检测   执行CTB方案
                CTB.Run();
                Console.WriteLine("检测个数：" + CTB.Outputs["结果名"].Value);
                //在控件上显示图片
                cogRecordDisplay1.Image = Image;
                cogRecordDisplay1.Fit();
                cogRecordDisplay1.Record = CTB.CreateLastRunRecord().SubRecords["显示标记的图片名"];

            }else
            {
                Console.WriteLine("没有取到图像");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //开始取像
            Acq.StartAcquire();
            Console.WriteLine("取像开始");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //保存图像按钮
            string s = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds().ToString();//时间戳
            //保存图片
            Console.WriteLine($"保存图片：{s}.png");
            cogRecordDisplay1.Image.ToBitmap().Save($"./images/{s}.png");
            //保存带标注图片
            cogRecordDisplay1.CreateContentBitmap(Cognex.VisionPro.Display.CogDisplayContentBitmapConstants.Display)
                .Save($"./images/new_{s}.png");
            Console.WriteLine("保存成功");
        }
    }
}
