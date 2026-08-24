using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.AccessControl;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace zuoye8_17
{
    internal class BookManager
    {
        // 属性：
        // 数据文件路径
        public string path { get; }
        // JSON序列化配置项
        public JsonSerializerOptions JsonOpts { get; }


        #region 新增方法
        // 新增数据：强制要求 ==> 将list写入文件中
        public string AddBook(Dictionary<string, dynamic> bookDic)
        {
            // 判断图书是否已存在===>根据图书名判断(一个书名只有一本)

            // 新增的逻辑处理
            // 判断path路径是存在===> 不存在, 组装书籍list,序列化后 写入文件
            // 如果存在 =====> 先读取文件内容
            // 反序列化为list ====> 添加bookDic到list中
            // 序列化list ====> 写入文件
            List<Dictionary<string, dynamic>> bookList = new();
            var json = File.ReadAllText(path);
            if (File.Exists(path) && !string.IsNullOrWhiteSpace(json))
            {
                // 读取文件===>反序列化
                bookList = JsonSerializer.Deserialize<List<Dictionary<string, dynamic>>>(json);// 反序列化                
            }
            if (File.Exists(path) && string.IsNullOrWhiteSpace(json))
            {
                bookList.Add(bookDic); // 新增字典添加进bookList            
                string jsonSstr = JsonSerializer.Serialize(bookList, JsonOpts); //序列化            
                File.WriteAllText(path, jsonSstr); // 写入文件
                return "新增数据成功！！！\n";
            }

            // 创建字符串变量 将字典里的书名拿来跟新增书名比对
            string newBookName = bookDic["name"].ToString();
            bool isExist = bookList.Any(item => item["name"].ToString() == newBookName);
            if (isExist) return "新增失败，该书名已存在！！！\n  ";

            bookList.Add(bookDic); // 新增字典添加进bookList            
            string jsonStr = JsonSerializer.Serialize(bookList, JsonOpts); //序列化            
            File.WriteAllText(path, jsonStr); // 写入文件

            return "新增数据成功！！！\n  ";
        }
        #endregion

        #region 编辑方法
        // 编辑数据
        public string EditBook(string bookName)
        {

            Dictionary<string, dynamic> newDic = new();
            //判断文件是否存在
            if (!File.Exists(path)) return "编辑失败，图书不存在！！！\n";
            var json = File.ReadAllText(path);
            List<Dictionary<string, dynamic>> jsonStr = JsonSerializer.Deserialize<List<Dictionary<string, dynamic>>>(json);
            Dictionary<string, dynamic> bookDic = jsonStr.Find(item => item["name"].ToString() == bookName);

            foreach (var kv in bookDic)
            {
                // kv.Key 是键，kv.Value是值
                Console.WriteLine($"{kv.Key} ： {kv.Value}");
            }
            Console.WriteLine("编辑作者：");
            string author = Console.ReadLine();
            if (Regex.IsMatch(author, @"^\S[u4e00-u9fa5a]+\S$"))
            {
                Console.WriteLine("编辑标签：");
                string mark = Console.ReadLine();
                if (Regex.IsMatch(mark, @"^\S[u4e00-u9fa5a]+\S$"))
                {
                    Console.WriteLine("编辑价格：");
                    string price = Console.ReadLine();
                    if (Regex.IsMatch(price, @"^[1-9]+[0-9]*(\.[0-9]+)?$"))
                    {
                        newDic = new()
                        {
                            ["name"] = bookName,
                            ["author"] = author,
                            ["mark"] = mark,
                            ["price"] = price

                        };
                        foreach (var ii in newDic)
                        {
                            bookDic[ii.Key] = newDic[ii.Key];
                        }
                        File.WriteAllText(path, JsonSerializer.Serialize(jsonStr, this.JsonOpts));
                        return "编辑成功！！！\n";

                    } return "编辑失败，输入价格格式不正确！！！\n";
                }return "输入标签格式有误！！！\n";
            }return "输入作者名格式有误！！！\n";
        }
        #endregion

        #region 删除方法
        // 删除数据
        public string RemoveBook(string bookName)
        {
            List<Dictionary<string, dynamic>> list = new();
            List<Dictionary<string, dynamic>> newList = new();

            //判断文件是否存在
            if (!File.Exists(path)) return "没有可以删除的图书！！！\n";
            //文件存在则读取文件
            var str = File.ReadAllText(path);
            if (string.IsNullOrWhiteSpace(str)) return "没有可以删除的图书！！！\n";

            //反序列化
            list = JsonSerializer.Deserialize<List<Dictionary<string, dynamic>>>(str);

            //找到对应的书名
            foreach (var item in list)
            {
                if (item["name"].ToString() != bookName) newList.Add(item);
            }
            var reResult = JsonSerializer.Serialize(newList, JsonOpts);
            File.WriteAllText(path, reResult);
            if (list.Count > newList.Count) return "选择图书已删除！！！\n";
            else return "删除失败，没有找到该图书！！！\n";



        }
        #endregion

        #region 查询所有数据方法
        // 查询所有数据
        public string SearchBook() // 返回值根据情况修改
        {
            // 新建一个list接受外部参数
            List<Dictionary<string, dynamic>> bookList = new();
            if (!File.Exists(path)) return "图书管理系统中暂无图书数据！！！\n  ";
            var jsonStr = File.ReadAllText(path);

            if (string.IsNullOrWhiteSpace(jsonStr)) return "图书管理系统中暂无图书数据！！！\n  ";

            bookList = JsonSerializer.Deserialize<List<Dictionary<string, dynamic>>>(jsonStr);

            if (bookList.Count == 0) return "图书管理系统中暂无图书数据！！！\n  ";

            string result = "";
            foreach (var item in bookList)
            {
                result += $"\n书名:{item["name"]}--作者:{item["author"]}--价格:{item["price"]}--是否借出：{item["isBorrow"]}\n";
            }

            return result;
        }
        #endregion

        #region 查询点个方法
        // 根据图书名称查询当前图书数据：强制要求
        public Dictionary<string, dynamic> SearchBook(string bookName) // 返回值根据情况修改
        {
            Dictionary<string, dynamic> bookDic = new();


            //判断文件是否存在
            if (!File.Exists(path)) return bookDic;
            var jsonStr = File.ReadAllText(path);

            List<Dictionary<string, dynamic>> list =
                JsonSerializer.Deserialize<List<Dictionary<string, dynamic>>>(jsonStr);

            Dictionary<string, dynamic> newBookDic = list.Find(item => item["name"].ToString() == bookName);
            if (newBookDic == null) return bookDic;

            return newBookDic;


        }
        #endregion

        #region 借阅方法
        public string borrowBook(string bookName) 
        {
            //判断文件是否存在
            if (!File.Exists(path)) return "没有可以借出的书籍！！！";
            //文件存在 ===> 读取文件
            var jsonStr = File.ReadAllText(path);
            //反序列化
            List<Dictionary<string, dynamic>> list = JsonSerializer.Deserialize<List<Dictionary<string ,dynamic>>>(jsonStr);
            Dictionary<string, dynamic> bookDic = list.Find(item => item["name"].ToString() == bookName);
            if (bookDic == null) return "未找到该图书！！！\n";
            
            if (bookDic["isBorrow"].ToString() == "False")
            {
                bookDic["isBorrow"] = true;
                File.WriteAllText(path, JsonSerializer.Serialize(list, this.JsonOpts));
                return "借书成功！！！\n";
            }
            return "该书籍已被借出！！！\n";
        }
        #endregion

        #region 还书方法
        public string Huanshu(string bookName) 
        {
            //判断文件是否存在
            if (!File.Exists(path)) return "图书馆中没有书籍！！！\n";
            //文件存在 ===> 读取文件
            var jsonStr = File.ReadAllText(path);
            //反序列化
            List<Dictionary<string, dynamic>> list = JsonSerializer.Deserialize<List<Dictionary<string, dynamic>>>(jsonStr);
            Dictionary<string, dynamic> bookDic = list.Find(item => item["name"].ToString() == bookName);
            if (bookDic == null) return "未找到该图书！！！\n";

            if (bookDic["isBorrow"].ToString() == "True")
            {
                bookDic["isBorrow"] = false;
                File.WriteAllText(path, JsonSerializer.Serialize(list, this.JsonOpts));
                return "还书成功！！！\n";
            }
            return "该书籍未被借出！！！\n";

        }


        #endregion

        // 自定义实例构造函数
        public BookManager(string bookPath, JsonSerializerOptions Opts)
        {
            // 实例化初始化属性
            path = bookPath;
            JsonOpts = Opts;
        }

    }
}
