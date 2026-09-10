using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Xml.Schema;

namespace MyTcpClient1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //绑定初始化事件
            this.Shown += TcpClientInit;
        }

        private void TcpClientInit(object? sender, EventArgs e)
        {
            //按钮触发事件
            button1.Click += ConnServerAndRead;
            button2.Click += SendData;
        }

        private async void SendData(object? sender, EventArgs e)
        {
            //发送 数据的事件
            if (!isConnected)
            {
                MessageBox.Show("未连接服务端");
                return;
            }
            if (Stream == null)
            {
                MessageBox.Show("没有数据流");
                isConnected = false;
                return;
            }
            //获取输入框数据转为 字节数组
            string text = textBox3.Text;
            byte[] data = Encoding.UTF8.GetBytes(text);
            try
            {
                await Stream.WriteAsync(data,0,data.Length);
            }
            catch (Exception ex)
            {
                MessageBox.Show("给服务端发送消息失败");
                return;
                
            }
            textBox3.Text = "";

        }

        private TcpClient tcpClient;
        private bool isConnected;
        private NetworkStream Stream;
        private int Num =0;
        private async void ConnServerAndRead(object? sender, EventArgs e)
        {
            //接收输入的端口 IP 并校验
            bool isAddress = IPAddress.TryParse(textBox1.Text,out IPAddress IP);
            bool isPort = int.TryParse(textBox2.Text, out int Port);
            if (!isAddress || !isPort || Port <0 || Port >65535)
            {
                MessageBox.Show("输入IP或端口有误");
                return;
            }
            //没有 输入错误继续执行
            //创建客户端
            tcpClient = new TcpClient();
            //创建好后 连接服务器
            try
            {
                //连接服务器
                await tcpClient.ConnectAsync(IP,Port);
                //获取数据流
                Stream = tcpClient.GetStream();
                isConnected = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"连接失败{ex.Message}");
                isConnected = false;
            }
            //读取数据
            //使用 自定义的读取数据方法
            ReadData();
        }

        private async Task ReadData()
        {
            //先判断是否连接成功
            if (!isConnected)
            {
                MessageBox.Show("未连接服务端");
                return ;
            }
            if (Stream == null)
            {
                MessageBox.Show("没有数据流");
                isConnected = false;
                return;
            }
            //读取数据
            //准备字节数组
            byte[] bytes = new byte[1024];
            //死循环读取
            while (true)
            {
                bytes = new byte[1024];//清空数据流
                int len = await Stream.ReadAsync(bytes,0,bytes.Length);
                if (len == 0)
                {
                    MessageBox.Show("连接断开");
                    break;
                }
                //将 字节数组里的数据 转变为 字符串
                string ReceiveData = Encoding.UTF8.GetString(bytes);
                //创建label
                Label la = new Label();
                la.Text = ReceiveData;
                la.Size = new Size(300,30);
                la.Location = new Point(0,30*Num);
                Num++;
                panel1.Controls.Add( la );
            }


        }





    }
}
