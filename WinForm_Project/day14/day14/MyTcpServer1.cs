using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;

namespace day14
{
    public partial class MyTcpServer1 : Form
    {
        public MyTcpServer1()
        {
            InitializeComponent();
            //绑定窗体事件
            this.Shown += TcpServerInit;
        }

        private void TcpServerInit(object? sender, EventArgs e)
        {
            //打开 客户端窗口
            new MyTcpClient().Show();
            //绑定按钮事件
            button1.Click += CreateServerAndRead;//创建服务端 和 读取 客户端发送来的数据
            button2.Click += SendInit;//点击触发 发送事件

            button1.Enabled = true;
            button2.Enabled = false;
        }

        private async void SendInit(object? sender, EventArgs e)
        {
            if (!IsConnected)
            {
                MessageBox.Show("未连接客户端");
                return;
            }
            if (Stream == null)
            {
                MessageBox.Show("没有数据流");
                return; 
            }
            //获取输入框数据
            string sendStr = textBox2.Text;
            //转为 字节数组
            byte[] bytes = Encoding.UTF8.GetBytes(sendStr);//字节 <=> 字符串 互相转换的一套规则
            try
            {
                //给客户端发送数据
                //ReadAsync  读，接收别人 发送来的数组数据
                //WriteAsync 写，发送数据给别人
                await Stream.WriteAsync(bytes, 0, bytes.Length);//await等待，不然数据没传送完就下一步了 

            }
            catch (Exception ex)
            {
                IsConnected = false;
                MessageBox.Show($"给客户端发送数据失败{ex.Message}");
            }
            //清空txetBox输入框数据
            textBox2.Text = "";
        }

        private TcpListener Tcpserver;
        private TcpClient Tcpclient;
        NetworkStream Stream;//网络流
        private bool IsConnected;//是否已连接
        private int Num = 0;
        private async void CreateServerAndRead(object? sender, EventArgs e)
        {
            //校验输入
            //尝试将，textBox.text 转为int类型，如果成功就是true,就抛出端口Port
            if (!int.TryParse(textBox1.Text, out int Port) || Port < 0 || Port > 65535)
            {
                MessageBox.Show("输入端口有误");
                return;
            }
            //创建Tcp服务
            Tcpserver = new TcpListener(System.Net.IPAddress.Any,Port);
            //启动服务
            Tcpserver.Start();
            Console.WriteLine("===TCP服务启动成功===");
            button1.Enabled = true;
            button2.Enabled = true;
            IsConnected = true;
            try
            {
                //创建 客户端 对象（等待）    
                //AcceptTcpClientAsync异步等待客户端来连接，一直等客户端程序来连接服务器端口，才会往下走
                //await配合异步，不会卡死整个窗体界面
                Tcpclient = await Tcpserver.AcceptTcpClientAsync();
                //输出连接的客户端信息
                Console.WriteLine($"客户端连接，IP：{Tcpclient.Client.RemoteEndPoint}");
                //获取数据流(数据管道)
                Stream = Tcpclient.GetStream();//Stream 网络流，数据流
            }
            catch (Exception ex)
            {
                Tcpserver.Stop();
                Tcpserver.Dispose();//释放销毁 这个监听对象,不能再Start();
                IsConnected = false;
                Console.WriteLine("===TCP服务器关闭===");
            }
            //读取数据
            ReadData();

        }

        private async Task ReadData()
        {
            if (!IsConnected)
            {
                MessageBox.Show("客户端未连接！");
                return;
            }
            if (Stream == null)
            {
                IsConnected = false;
                MessageBox.Show("没有数据流");
                return;
            }
            //button1.Enabled = false;
            //button2.Enabled = true;
            //button3.Enabled = true;
            //准备 字节数组 接受数据
            byte[] data = new byte[1024];
            while (true)
            {
                data = new byte[1024];
                //读取数据
                int len = await Stream.ReadAsync(data, 0, data.Length);//从0开始存放读到的数据，最多读到data.Length
                if (len == 0)
                {
                    MessageBox.Show("客户端已断开连接");
                    break;
                }
                //拿到客户端发来的数据
                string ReceiveData = Encoding.UTF8.GetString(data);//字节 <=> 字符串 互相转换的一套规则
                Label label = new Label();
                label.Text = ReceiveData;
                label.AutoSize = false;
                label.Size = new Size(300,30);
                label.Location = new Point(0,Num*30 );
                Num++;
                panel1.Controls.Add(label);
            }



        }
    }
}
