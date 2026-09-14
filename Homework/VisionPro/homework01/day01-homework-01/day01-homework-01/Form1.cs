using Cognex.VisionPro;
using Cognex.VisionPro.ImageFile;
using Cognex.VisionPro.Interop;
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

namespace day01_homework_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //点击触发事件
            //打开文件，选择照片
            using (OpenFileDialog OFD = new OpenFileDialog())// 创建 打开文件对话框 的对象
            {
                //配置
                OFD.Title = "请选择要计数的图片";//配置 标题
                OFD.Filter = "图片|*.jpg;*.jpeg;*.png;*.gif;";//配置文件 选择
                //判断 如果点的ok
                //弹出系统的 【打开文件】弹窗，阻塞程序，等待用户 点击确定 或 取消
                if (OFD.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile(OFD.FileName);//从打开文件 窗口的 图片中选择显示
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;//配置图片的那个什么来着 保证图片能显示得好看的那个
                    //新语法
                    //使用visionPro中的 图片处理工具 打开图片 需要引用 visionPro 安装目录下的dll文件
                    CogImageFileTool CFT = new CogImageFileTool(); //图片处理工具 对线
                    //Operator 操作成员，Open（）打开图像文件 的方法 ，用来吧磁盘 上的图片加载到 VisionPro内存中
                    CFT.Operator.Open(OFD.FileName,CogImageFileModeConstants.Read);
                    CFT.Run();//运行 图片处理工具

                    //拼接 视图方案的绝对路径
                    string VppFilePath = Path.Combine(Directory.GetCurrentDirectory(),"vpps", "骰子计点数方案.vpp");

                    //将vpp 文件中的视图方案 读取到 c#中
                    object LOF = CogSerializer.LoadObjectFromFile(VppFilePath);

                    //读取后默认是object 类型；不具备Cog工具对象的运行方法，所以给工具转类型
                    CogToolBlock CTB = (LOF as CogToolBlock);

                    //将 CogImageFileTool 工具读取到的输出图像，作为（视图方案）CTB 的输入图像
                    CTB.Inputs["OutputImage"].Value = CFT.OutputImage;
                    CTB.Run();//运行 视图方案

                    label2.Text = CTB.Outputs["Output"].Value.ToString();

                }

            }
        }
    }
}
