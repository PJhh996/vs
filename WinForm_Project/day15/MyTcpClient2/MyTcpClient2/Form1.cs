using System.Drawing.Design;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace MyTcpClient2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //绑定窗体事件
            this.Shown += TcpClientInit ;
        }

        private void TcpClientInit(object? sender, EventArgs e)
        {
            //绑定 连接事件
            button1.Click += ConnectServerAndRead;
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
            if (stream == null)
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
                await stream.WriteAsync(data, 0, data.Length);
            }
            catch (Exception ex)
            {
                MessageBox.Show("给服务端发送消息失败");
                return;

            }
            textBox3.Text = "";
        }

        private TcpClient tcpClient;
        private bool isConnected = false;
        private NetworkStream stream;
        private int Num = 0;
        private async void ConnectServerAndRead(object? sender, EventArgs e)
        {
            //判断 IP 和 端口是否有误
            bool isIPAddress = IPAddress.TryParse(textBox1.Text,out IPAddress IP);
            bool isPort = int.TryParse(textBox2.Text, out int Port);
            if (!isIPAddress || !isPort || Port < 0 || Port > 65535)
            {
                MessageBox.Show("输入IP 或 端口有误");
                return;
            }
            //创建 客户端对象
            tcpClient = new TcpClient();
            //连接服务端
            try
            {
                //连接服务器
                await tcpClient.ConnectAsync(IP,Port);
                //获取 数据流
                stream = tcpClient.GetStream();
                isConnected = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"连接失败{ex.Message}");
                isConnected = false;
            }
            //读取数据

            ReadData();


        }

        private async Task ReadData()
        {
            //判断是否连接
            if (!isConnected)
            {
                MessageBox.Show("未连接服务端");
                return ;
            }
            if (stream == null)
            {
                MessageBox.Show("没有数据流");
                isConnected = false;
                return;
            }
            //准备字节数组 接收数据
            byte [] data = new byte[1024];
            //死循环 读取
            while (true)
            {
                data = new byte[1024];
                int len = await stream.ReadAsync(data, 0, data.Length);
                if (len == 0)
                {
                    MessageBox.Show("连接断开");
                        ;
                }
                // 字节 转换 字符串
                string ReceiveData = Encoding.UTF8.GetString(data);
                Label label = new Label();
                label.Text = ReceiveData;
                label.Size = new Size(300,30);
                label.Location = new Point(0,30*Num);
                Num++;
                panel1.Controls.Add(label);

            }

        }
    }
}
