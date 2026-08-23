using System.Diagnostics;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text.Json;

namespace kaoshi8_21_3_1
{
    internal class Program
    {
        
        static void Main(string[] args)
        {

            ShouwEmpinfo SE = new ShouwEmpinfo();

            string num = "";
            Console.WriteLine("==员工薪资管理控制台系统==");
            Console.WriteLine("输入编码选择菜单");
            Console.WriteLine("1.新增员工");
            Console.WriteLine("2.查看全部员工");
            Console.WriteLine("3.根据编号调整薪资");
            Console.WriteLine("4.根据编号删除员工");
            Console.WriteLine("5.按薪资条件筛选员工");
            Console.WriteLine("6.退出系统");
            num = Console.ReadLine();

            while (num != "6")
            {
               
                switch (num) 
                {
                    case "1":
                        Console.WriteLine("==新增员工==");
                        Console.WriteLine("输入员工编号：");
                        int id = int.Parse(Console.ReadLine());
                        Console.WriteLine("输入员工姓名：");
                        string name = Console.ReadLine();
                        Console.WriteLine("请输入部门：");
                        string bumen = Console.ReadLine();
                        Console.WriteLine("请输入薪资：");
                        double xinzi = double.Parse(Console.ReadLine());
                        SE.empAdd(id,name,bumen,xinzi);
                        

                        break;
                    case "2":
                        Console.WriteLine("==查看全部员工==");
                        SE.chaKan();

                        break;
                    case "3":
                        Console.WriteLine("==根据编号调整薪资==");
                        break;
                    case "4":
                        Console.WriteLine("==根据编号删除员工==");
                        break;
                    case "5":
                        Console.WriteLine("==按薪资条件筛选员工==");
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
