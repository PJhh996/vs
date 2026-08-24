using System.Diagnostics;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.RegularExpressions;

namespace kaoshi8_21_3_1
{
    internal class Program
    {

        static void Main(string[] args)
        {

            Employee EM = new Employee();

            string num = "";


            while (num != "6")
            {
                Console.WriteLine("==员工薪资管理控制台系统==");
                Console.WriteLine("输入编码选择菜单");
                Console.WriteLine("1.新增员工");
                Console.WriteLine("2.查看全部员工");
                Console.WriteLine("3.根据编号调整薪资");
                Console.WriteLine("4.根据编号删除员工");
                Console.WriteLine("5.按薪资条件筛选员工");
                Console.WriteLine("6.退出系统");
                num = Console.ReadLine();

                switch (num)
                {
                    case "1":
                        Console.WriteLine("==新增员工==");
                        Console.WriteLine("输入员工编号：");
                        string id = Console.ReadLine();
                        if (Regex.IsMatch(id, @"\d"))
                        {
                            Console.WriteLine("输入员工姓名：");
                            string name = Console.ReadLine();
                            Console.WriteLine("请输入部门：");
                            string bumen = Console.ReadLine();
                            Console.WriteLine("请输入薪资：");
                            string xinzi = Console.ReadLine();
                            if (Regex.IsMatch(xinzi, @"^\d+(\.[0-9]+)?$"))
                            {
                                EM.empAdd(id, name, bumen, xinzi);
                                continue;
                            }
                            Console.WriteLine("输入薪资格式有误！！！\n");
                            continue;
                        }
                        Console.WriteLine("输入员工编号格式有误！！！\n");

                        break;
                    case "2":
                        Console.WriteLine("=====================查看全部员工=====================");
                        EM.chaKan();
                        Console.WriteLine("======================================================");

                        break;
                    case "3":
                        Console.WriteLine("==根据编号调整薪资==");
                        Console.WriteLine("请输入员工编号：");
                        string empId = Console.ReadLine();
                        if (Regex.IsMatch(empId, @"\d"))
                        {
                            EM.Gai(empId);
                            continue;
                        }
                        Console.WriteLine("输入编号格式有误！！！\n");

                        break;
                    case "4":
                        Console.WriteLine("==根据编号删除员工==");
                        Console.WriteLine("请输入员工编号：");
                        string idEmp = Console.ReadLine();
                        if (Regex.IsMatch(idEmp, @"\d"))
                        { 
                            EM.Remove(idEmp);
                            continue;
                        }
                        Console.WriteLine("输入编号格式有误！！！\n");

                        break;
                    case "5":
                        Console.WriteLine("=====================按薪资条件筛选员工=====================");
                        Console.WriteLine("请输入薪资：");
                        string sl = Console.ReadLine();
                        if (Regex.IsMatch(sl, @"^\d+(\.[0-9]+)?$")) EM.Xinzi(sl);
                        Console.WriteLine("输入薪资格式有误！！！\n");
                        Console.WriteLine("============================================================");
                        break;
                    case "6":
                        Console.WriteLine("==退出系统==");
                        break;
                    default:
                        Console.WriteLine("输入编号有误！！！");
                        break;
                }

            }
        }
    }
}
