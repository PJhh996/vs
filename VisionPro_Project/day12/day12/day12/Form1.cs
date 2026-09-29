using Cognex.VisionPro;
using Cognex.VisionPro.ImageProcessing;
using Cognex.VisionPro.ToolBlock;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace day12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.FormClosing += Form1_FormClosing;//强制关闭当前进程，防止报错
            this.Shown += Form1_Shown;
        }
        private CogToolBlock CTB { get; set; }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill(); // 强制关闭当前进程
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            //拼接路径
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "vpps", "硬币计数方案.vpp");
            Object CTBObj = CogSerializer.LoadObjectFromFile(filePath); // 加载vpp文件转为 Cog的工具对象
            CTB = CTBObj as CogToolBlock;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //获取所有相机
            CogFrameGrabbers Grabbers = new CogFrameGrabbers();
            //遍历获取所有相机
            //foreach (ICogFrameGrabber item in Grabbers)
            //{
            //    MessageBox.Show(item.Name);
            //}

            //也可以获取单个 相机 通过下标
            ICogFrameGrabber Grabber = Grabbers[0];

            //接下来获取 相机拍到的图像
            //1.配置相机 2.获取相机的取像队列 3.给Acq绑定事件（Acq是控制相机接收图片的采集管道，在事件中获取图像）
            //4.启动相机拍照


            //配置相机  获取相机的取像队列（Acq）
            //参数 ： 视频格式  图片类型  相机端口  是否自动准备
            ICogAcqFifo Acq = Grabber.CreateAcqFifo(
                "Generic GigEVision (Mono)",
                CogAcqFifoPixelFormatConstants.Format8Grey,
                0,
                true
                );
            //设置曝光
            Acq.OwnedExposureParams.Exposure = 500;

            //绑定事件
            Acq.Complete += Acq_Complete;

            // 开始取像
            Acq.StartAcquire();

        }

        private void Acq_Complete(object sender, CogCompleteEventArgs e)
        {
            //获取取像队列
            ICogAcqFifo Acq = sender as ICogAcqFifo;

            //获取取像队列的状态
            Acq.GetFifoState(out int _,out int NumReady,out bool _);//NumReady 当前取像完成个数
            if (NumReady > 0)
            {
                //获取一张 队列拍完的图像，同时把本次采集成功/失败信息，存入CogAcqInfo对象，最后把图像返回给image变量
                ICogImage image = Acq.CompleteAcquireEx(new CogAcqInfo());

                //使用灰度图转换工具转换一下
                CogImageConvertTool CICT = new CogImageConvertTool();//获取工具
                CICT.InputImage = image;
                CICT.Run();//运行

                //将灰度图工具输出的图片 转换为 比特图像数据
                Bitmap ResImage = CICT.OutputImage.ToBitmap();
                //微软winform原生控件只认 微软自家的 System.Drawing.Image/Bitmap,所以要转
                pictureBox1.Image = ResImage as System.Drawing.Image;//转为图片
                                                                     // 将拍照的图像 传给 CTB 的输入
                CTB.Inputs["OutputImage"].Value = image;
                CTB.Run();

                // 在非UI主线程中不能操作 UI控件
                this.Invoke(new Action(() => // 切换会UI主线程
                {
                    label2.Text = CTB.Outputs["count"].Value.ToString();
                }));


            }



        }
    }
}
