using System.Text.Json;

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
                Console.WriteLine("0: 退出");
                Console.WriteLine();
                num = Console.ReadLine();

                switch (num)
                {
                    case "1":
                        Console.WriteLine("----新增图书----");
                        Console.WriteLine("请输入书名");
                        string bookName = Console.ReadLine();
                        Console.WriteLine("请输入作者");
                        string author = Console.ReadLine();
                        Console.WriteLine("请输入标签");
                        string mark = Console.ReadLine();
                        Console.WriteLine("请输入价格");
                        double price = double.Parse(Console.ReadLine());
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
                        // 调用实例方法  实现 添加书籍
                        string res = BM.AddBook(bookDic);
                        Console.WriteLine(res);
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
                        if (resEdit == null) Console.WriteLine("编辑失败，图书不存在！！！\n");
                        else Console.WriteLine("编辑成功！！！\n");


                            break;
                    case "4":
                        Console.WriteLine("----查询所有图书----");
                        string resStr = BM.SearchBook();
                        Console.WriteLine(resStr);
                        break;
                    case "5":
                        Console.WriteLine("----查询单个图书----");
                        Console.WriteLine("请输入要查询的书名：");
                        string oneBookName  = Console.ReadLine();
                        Dictionary<string,dynamic> oneResStr = BM.SearchBook(oneBookName);
                        string resBook = $"\n书名：{oneResStr["name"]}--作者:{oneResStr["author"]}" +
                            $"标签：{oneResStr["mark"]}--价格：{oneResStr["price"]}\n";
                        Console.WriteLine(resBook);
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
