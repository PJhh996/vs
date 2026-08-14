using System.Text.Json;
using System.Text.RegularExpressions;

namespace zuoye8_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 作业1
            //作业: 使用读写文件配合命令行窗口 模拟实现注册功能
            //要求输入用户名和密码,完成注册; (注册的用户信息记录在user.txt文件中,
            //一行一个用户信息 数据之间通过 === 分隔)

            //Action zhuce = () =>
            //{

            //    while(true)
            //    {
            //        Console.WriteLine("请输入注册用户名：");
            //        string user = Console.ReadLine();
            //        if (user == "")
            //        {
            //            Console.WriteLine("输入账号不能为空");
            //            break;
            //        } 
            //        Console.WriteLine("请输入新密码：");
            //        string password = Console.ReadLine();
            //        if (password == "")
            //        {
            //            Console.WriteLine("输入密码不能为空");
            //            break;
            //        }
            //        Console.WriteLine("输入esc可退出注册，是否退出：");
            //        string esc = Console.ReadLine();
            //        if(esc == "esc")break;

            //        var path = "./user.txt";
            //        File.AppendAllText(path, $"用户名:{user}===密码:{password}\n");

            //    }
            //};
            //zhuce();
            #endregion


            //扩展练习:  使用读写文件配合命令行窗口  模拟实现注册登录功能
            //进入就是菜单栏界面, 1注册,2登录,0退出
            //输入1 进入注册, 要求输入用户名,密码, 用户输入用户名和密码 则实现注册功能,
            //要求校验用户名和密码
            //输入2 进入登录, 要求输入用户名, 密码, 输入后完成登录校验功能; 登录成功提示 登录成功
            //输入0 退出程序,
            //-用户注册成功的用户信息 以文件的形式存储在user.json中(要求以json形式存储)
            //- [{ username: "",password: "",datetime: "时间戳"}]
            //-用户操作日志user.log: 用户每次操作都要有日志记录, 记录操作,用户名,
            //操作方式,时间,如果有异常的,记录异常

            while (true)
            {
                Console.WriteLine("请选择菜单（1=>注册/2=>登录/0=>退出）：");
                int menu = int.Parse(Console.ReadLine());
                var date = DateTime.Now;
                var path = "./user.json";
                if (menu == 1)
                {
                    Console.WriteLine("开始注册");
                    File.AppendAllText(path, $"user.log：用户开始注册，{date}\n");
                    Console.WriteLine("请输入用户名：");
                    string userName = Console.ReadLine();
                    Console.WriteLine("请输入密码：");
                    string passWord = Console.ReadLine();
                    bool user = Regex.IsMatch(userName,@"\s");
                    bool pwd = Regex.IsMatch(passWord, @"\s");
                    if (userName.Length < 8 || userName.Length > 16)
                    {
                        Console.WriteLine("输入用户名长度不符合要求");
                        File.AppendAllText(path, $"user.log：用户输入用户名长度有误，注册失败，{date}\n");
                        continue;
                    }
                    else if (user)
                    {
                        Console.WriteLine("输入用户名中不能有空格");
                        File.AppendAllText(path, $"user.log：用户输入用户名有空格，注册失败，{date}\n");
                        continue;
                    }
                    else if (passWord.Length < 8 || passWord.Length > 16)
                    {
                        Console.WriteLine("输入密码长度不符合要求");
                        File.AppendAllText(path, $"user.log：用户输入密码长度有误，注册失败，{date}\n");
                        continue;
                    }
                    else if (pwd)
                    {
                        Console.WriteLine("输入密码中不能有空格");
                        File.AppendAllText(path, $"user.log：用户输入密码有空格，注册失败，{date}\n");
                    }
                    else
                    {
                        Console.WriteLine("注册成功");
                        var obj = new { 
                            username = userName,
                            password = passWord,
                        };
                        string json = JsonSerializer.Serialize(obj, new JsonSerializerOptions { WriteIndented = true });
                        File.AppendAllText(path, $"user.log：{json}  注册成功  {date}\n");
                    }
                }
                else if (menu == 2)
                {
                    Console.WriteLine("开始登录");
                    File.AppendAllText(path, $"user.log：用户开始登录，{date}\n");
                    Console.WriteLine("请输入用户名：");
                    string userName = Console.ReadLine();
                    bool hasSpace = Regex.IsMatch(userName, @"\s");
                    if ((userName.Length < 8 || userName.Length > 16) || hasSpace)
                    {
                        Console.WriteLine("输入用户名不存在");
                        File.AppendAllText(path, $"user.log：{userName}该用户不存在，{date}\n");
                        continue;
                    }                  
                    else
                    {
                        Console.WriteLine("请输入密码：");
                        string password = Console.ReadLine();
                        bool hasSpacePwd = Regex.IsMatch(password, @"\s");
                        if ((userName.Length < 8 || userName.Length > 16) || hasSpacePwd)
                        {
                            Console.WriteLine("输入密码错误");
                            File.AppendAllText(path, $"user.log：用户{userName}输入密码错误，{date}\n");
                            continue;
                        }
                        else
                        {                            
                            Console.WriteLine("登录成功");
                            File.AppendAllText(path, $"user.log：用户{userName}登录成功，{date}\n");
                            continue;
                        }

                    }
                }
                else if (menu == 0)
                {                     
                    Console.WriteLine("退出");
                    File.AppendAllText(path, $"user.log：用户退出菜单，{date}\n");
                    break;
                }
                else
                {
                    File.AppendAllText(path, $"user.log：用户菜单选择出错，{date}\n");
                    Console.WriteLine("菜单选择出错");
                    break;
                }
            }






        }
    }
}
