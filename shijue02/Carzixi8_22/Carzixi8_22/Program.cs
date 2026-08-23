using System.Text.RegularExpressions;

namespace Carzixi8_22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string num = "";
            //实例化对象
            CarManager CM = new CarManager();
            UserManager UM = new UserManager();
            RentReturnCar RRC = new RentReturnCar();

            while (num != "0")
            {
                Tips();
                num = Console.ReadLine();
                switch (num)
                {
                    case "1":
                        Console.WriteLine("===新增车辆===");
                        Console.WriteLine("请输入车牌号：");
                        string card = Console.ReadLine();
                        Console.WriteLine("请输入车辆类型：");
                        string type = Console.ReadLine();
                        Console.WriteLine("请输入每小时费用：");
                        string price = Console.ReadLine();
                        string res = CM.CarAdd(card, type, price);
                        Console.WriteLine(res);

                        break;
                    case "2":
                        Console.WriteLine("================查看所有车辆信息================");
                        CM.SearchAll();
                        Console.WriteLine("================================================");
                        break;
                    case "3":
                        Console.WriteLine("===查看某辆车===");
                        Console.WriteLine("请输入要查询的车辆ID：");
                        int oneId = int.Parse(Console.ReadLine());
                        Console.WriteLine("==================查看车辆信息==================");
                        CM.SearchOne(oneId);
                        Console.WriteLine("================================================");

                        break;
                    case "4":
                        Console.WriteLine("================查看所有空闲车辆================");
                        CM.SearchFree();
                        Console.WriteLine("================================================");
                        break;
                    case "5":
                        Console.WriteLine("===新增客户===");
                        Console.WriteLine("请输入新客户姓名：");
                        string userName = Console.ReadLine();
                        Console.WriteLine("请输入新客户身份证号：");
                        string idCard = Console.ReadLine();
                        Console.WriteLine("请输入性别：");
                        string gender = Console.ReadLine();
                        Console.WriteLine("请输入新客户号码：");
                        string phoneNo = Console.ReadLine();
                        if (Regex.IsMatch(phoneNo, @"^1\d{10}$"))
                        {
                            Console.WriteLine("新客户座右铭：");
                            string motto = Console.ReadLine();
                            string resUserAdd = UM.UserAdd(userName, idCard, gender, phoneNo, motto);
                            Console.WriteLine(resUserAdd);
                        }
                        else Console.WriteLine("输入号码格式错误！！！\n");
                        break;
                    case "6":
                        Console.WriteLine("=====================所有客户信息=====================");
                        UM.UserAll();
                        Console.WriteLine("======================================================");
                        break;
                    case "7":
                        Console.WriteLine("请输入你要查询的客户身份证号：");
                        string oneIdCard = Console.ReadLine();
                        UM.UserOne(oneIdCard);
                        break;
                    case "8":
                        Console.WriteLine("===租车===");
                        Console.WriteLine("请输入车辆ID：");
                        int rentCarId = int.Parse(Console.ReadLine());
                        Console.WriteLine("请输入客户ID：");
                        int rentUserId = int.Parse(Console.ReadLine());
                        RRC.RentCar(rentCarId, rentUserId);
                        break;
                    case "9":
                        Console.WriteLine("===还车===");
                        Console.WriteLine("请输入还车id：");
                        int returnId = int.Parse(Console.ReadLine());
                        RRC.ReturnCar(returnId);

                        break;
                    case "10":
                        Console.WriteLine("==========================查看租车记录==========================");
                        RRC.Look();
                        Console.WriteLine("================================================================");


                        break;
                    case "0":
                        Console.WriteLine("===退出系统===");
                        break;
                    default:
                        Console.WriteLine("输入编号有误！！！\n");
                        break;


                }


            }

            static void Tips()
            {
                Console.WriteLine("==欢迎来到神车系统==");
                Console.WriteLine("请选择操作编号：");
                Console.WriteLine("0：退出系统");
                Console.WriteLine("1：新增车辆");
                Console.WriteLine("2：查看所有车辆信息");
                Console.WriteLine("3：查看某辆车");
                Console.WriteLine("4：查看所有空闲车辆");
                Console.WriteLine("5：新增客户");
                Console.WriteLine("6：查看所有客户");
                Console.WriteLine("7：查看某个客户");
                Console.WriteLine("8：租车");
                Console.WriteLine("9：还车");
                Console.WriteLine("10：查看所有租车记录");
            }

        }
    }
}
