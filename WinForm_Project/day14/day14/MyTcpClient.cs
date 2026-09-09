using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace day14
{
    public partial class MyTcpClient : Form
    {
        public MyTcpClient()
        {
            InitializeComponent();
            //绑定窗口事件
            this.Shown += TcpClientInit;
        }

        private void TcpClientInit(object? sender, EventArgs e)
        {
            //给按钮绑定事件
            button1.Click += ConnServerAndRead;//连接服务端 接收数据
            button2.Click += SendData;//发送数据给 服务端事件
            button3.Click += DisConnect;

            button2.Enabled = false;
            button3.Enabled = false;
            button1.Enabled = true;
        }

        private void DisConnect(object? sender, EventArgs e)
        {
            //关闭连接
            if (!IsConnected)
            {
                MessageBox.Show("没有连接服务器");
                return;
            }
            if (Stream == null)
            {
                MessageBox.Show("没有数据流");
                IsConnected = false;
                return;
            }
            Tcpclient.Close();//关闭连接
            IsConnected = false;
            Tcpclient = null;
            Stream = null;
            button1.Enabled = true;
            button3.Enabled = false;
            button2.Enabled= false;
        }

        private async void SendData(object? sender, EventArgs e)
        {
            if (!IsConnected)
            {
                MessageBox.Show("未连接服务端(服务器)");
                return;
            }
            if (Stream == null)
            {
                MessageBox.Show("没有数据流");
                IsConnected = false;
                return;
            }
            //发送信息给服务端
            //取到textbox 输入框中数据
            string SendStr = textBox2.Text;
            //转为字节数组
            byte[] bytes = Encoding.UTF8.GetBytes(SendStr);
            //发送数据
            try
            {
                //给 服务端 发送数据
                await Stream.WriteAsync(bytes, 0, bytes.Length);
            }
            catch (Exception ex)
            {
                IsConnected = false;
                MessageBox.Show($"给服务端发送数据失败:{ex.Message}");                
            }
            textBox2.Text = "";
        }

        private TcpClient Tcpclient;//客户端变量
        private bool IsConnected;//是否连接
        private NetworkStream Stream;//数据流
        private int Num = 0;
        private async void ConnServerAndRead(object? sender, EventArgs e)
        {
            //接收输入的 IP和端口号 并校验
            bool isAddress = IPAddress.TryParse(textBox3.Text, out IPAddress IP);
            bool isPort = int.TryParse(textBox1.Text, out int Port) && Port >= 0 && Port <= 65535;
            if (!isAddress || !isPort)
            {
                MessageBox.Show("输入的IP或端口号有误");
                return;
            }
            //创建 客户端对象
            Tcpclient = new TcpClient();
            try
            {
                //连接服务端
                await Tcpclient.ConnectAsync(IP, Port);
                Stream = Tcpclient.GetStream();//获取数据流
                IsConnected = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("连接异常");
                return;
            }
            //读取数据
            ReadData();


        }

        private async Task ReadData()
        {
            if (!IsConnected)
            {
                MessageBox.Show("未连接服务端");
                return;
            }
            if (Stream == null)
            {
                MessageBox.Show("没有数据流");
                IsConnected = false;
                return;
            }
            button1.Enabled = false;
            button2.Enabled = true;
            button3.Enabled = true;
            //准备字节数组 读取数据
            byte[] data = new byte[1024];
            // 不断的读取 服务端传来的数据
            while (true)
            {
                data = new byte[1024];
                //读取数据
                int len = await Stream.ReadAsync(data, 0, data.Length);
                if (len == 0)
                {
                    MessageBox.Show("连接断开");
                    break;
                }
                //拿到服务端发来的 数据
                string ReceiveData = Encoding.UTF8.GetString(data);//Receive是 收到 的意思
                //创建label 展示shujv
                Label label = new Label();
                label.Text = ReceiveData;
                label.Size = new Size(300, 30);
                label.Location = new Point(0, Num * 30);
                Num++;
                label.AutoSize = false;
                panel1.Controls.Add(label);
            }

        }
    }
}
