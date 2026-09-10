using System.Net;
using System.Net.Sockets;

namespace MyTcpServer
{
    internal class Program
    {
        //创建一个列表，用来存储 连接的客户端
        private static List<TcpClient> clientList = new List<TcpClient>();

        static async Task Main(string[] args)
        {
            //创建服务器
            TcpListener Tcpserver = new TcpListener(IPAddress.Any,8989);
            //启动服务
            Tcpserver .Start();
            while (true)
            {
                try
                {
                    //创建 客户端对象(Async等待)
                    TcpClient Tcpclient = await Tcpserver.AcceptTcpClientAsync();
                    //将 客户端添加到 list中
                    clientList.Add(Tcpclient);
                    Console.WriteLine($"客户端数：{clientList.Count}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"连接出错：{ex.Message}");                    
                }
                //读取客户端数据方法
                ReadClient();
            }
        }

        private static void ReadClient()
        {
            //遍历循环 每一个客户端，创建对应数据流
            foreach (TcpClient item in clientList)
            {
                ReadClientMessage(item);
            }
        }

        private static async Task ReadClientMessage(TcpClient tcpClient)
        {
            //接收 客户端发来的数据流
            NetworkStream stream = tcpClient.GetStream();
            //准备字节数组，用来转换数据流数据
            byte[] buffer = new byte[1024];
            while (true)
            {
                buffer = new byte[1024];
                int len = await stream.ReadAsync(buffer, 0, buffer.Length);
                if (len == 0)
                {
                    Console.WriteLine("链接断开");
                    break;
                }
                //遍历列表 给每一个客户端发送
                foreach (TcpClient Client in clientList)
                {
                    NetworkStream stream1 = Client.GetStream();
                    await stream1.WriteAsync(buffer, 0, buffer.Length);
                }
            }

        }
    }
}
