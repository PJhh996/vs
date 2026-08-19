using System.Text.Json;
using System.Text.RegularExpressions;

namespace zuoye8_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 实例化图书对象
            BookManager BM = new BookManager("./book.json", new JsonSerializerOptions
            {
                WriteIndented = true, // 美化格式内容
                AllowTrailingCommas = true,
            });


            string num = "";
            while (num != "0")
            {
                // 提示信息
                Console.WriteLine("======欢迎来到图书管理系统======");
                Console.WriteLine("1: 新增图书");
                Console.WriteLine("2: 删除图书");
                Console.WriteLine("3: 编辑图书");
                Console.WriteLine("4: 查询所有图书");
                Console.WriteLine("5: 查询单个图书");
                Console.WriteLine("6: 借阅图书");
                Console.WriteLine("7: 归还图书");
                Console.WriteLine("0: 退出");
                Console.WriteLine();
                num = Console.ReadLine();

                switch (num)
                {
                    case "1":
                        Console.WriteLine("----新增图书----");
                        Console.WriteLine("请输入书名");
                        string bookName = Console.ReadLine();
                        if (Regex.IsMatch(bookName, @"^\S[\u4e00-\u9fa5a-zA-Z0-9]{0,19}\S$"))
                        {

                            Console.WriteLine("请输入作者");
                            string author = Console.ReadLine();
                            if (Regex.IsMatch(author, @"^\S[\u4e00-\u9fa5]\S$"))
                            {
                                Console.WriteLine("请输入标签");
                                string mark = Console.ReadLine();
                                if (Regex.IsMatch(mark, @"^\S[\u4e00-\u9fa5 、]\S$"))
                                {
                                    Console.WriteLine("请输入价格");
                                    //double price = double.Parse(Console.ReadLine());
                                    string price = Console.ReadLine();
                                    if (Regex.IsMatch(price, @"^[1-9]+[0-9]*(\.\d)?$"))
                                    {
                                        // 组装 书籍 字典
                                        Dictionary<string, dynamic> bookDic = new()
                                        {
                                            ["name"] = bookName,
                                            ["author"] = author,
                                            ["isBorrow"] = false,
                                            ["id"] = new Random().NextDouble(),
                                            ["mark"] = mark,
                                            ["price"] = price

                                        };
                                        string res = BM.AddBook(bookDic);
                                        Console.WriteLine(res);
                                    }
                                    else Console.WriteLine("输入价格格式有误！！！\n");
                                }
                                else Console.WriteLine("输入标签格式有误！！！\n");
                            }
                            else Console.WriteLine("输入作者格式有误！！！\n");
                        }
                        else Console.WriteLine("书名格式有误！！！\n");



                        // 调用实例方法  实现 添加书籍

                        break;
                    case "2":
                        Console.WriteLine("----删除图书----");
                        Console.WriteLine("请输入删除的书名：");
                        string bookRemove = Console.ReadLine();
                        var removeRes = BM.RemoveBook(bookRemove);
                        Console.WriteLine(removeRes);
                        break;
                    case "3":
                        Console.WriteLine("----编辑图书----");
                        Console.WriteLine("请输入编辑的书名：");
                        string editName = Console.ReadLine();
                        var resEdit = BM.EditBook(editName);
                        Console.WriteLine(resEdit);
                        break;
                    case "4":
                        Console.WriteLine("----查询所有图书----");
                        string resStr = BM.SearchBook();
                        Console.WriteLine(resStr);
                        break;
                    case "5":
                        Console.WriteLine("----查询单个图书----");
                        Console.WriteLine("请输入要查询的书名：");
                        string oneBookName = Console.ReadLine();
                        Dictionary<string, dynamic> oneResStr = BM.SearchBook(oneBookName);
                        string resBook = $"\n书名：{oneResStr["name"]}--作者:{oneResStr["author"]}" +
                            $"标签：{oneResStr["mark"]}--价格：{oneResStr["price"]}--是否借出:{oneResStr["isBorrow"]}\n";
                        Console.WriteLine(resBook);                    
                        break;
                    case "6":
                        Console.WriteLine("----借阅图书----");
                        Console.WriteLine("请输入要借阅的图书书名：");
                        string bookBorrowName = Console.ReadLine();
                       
                            var borrowRes = BM.borrowBook(bookBorrowName);
                            Console.WriteLine(borrowRes);
                        
                            
                        break;
                    case "7":
                        Console.WriteLine("----归还图书----");
                        Console.WriteLine("请输入归还图书的书名：");
                        string bookHuanName = Console.ReadLine();
                        if (!Regex.IsMatch(bookHuanName, @"^\S[\u4e00-\u9fa5a-zA-Z0-9]{0,19}\S$"))
                            Console.WriteLine("输入书名格式有误！！！\n");
                        else
                        {
                            var HuanRes = BM.Huanshu(bookHuanName);
                            Console.WriteLine(HuanRes);
                        }

                        break;
                    case "0":
                        Console.WriteLine("--**退出**--\n");
                        break;
                    default:
                        Console.WriteLine("****输入有误****\n");
                        break;
                }


            }
        }
    }
}
/*
后续同学自行完善 方向
    1. 对所有输入的数据进行校验 √
        - 可以先取出首尾两端的空白
        - 不为空，长度要求校验
        - 正则校验
    2. 完善一个借阅功能
        - 添加一个借阅功能的编号 比如： 5
            + 输入5 进入借阅功能
                - 将所有可借阅的书籍展示， 并要求用户输入借阅的书籍名称
                - 输入要借阅的书籍，实现借阅
    3. 完善一个还书功能  
*/