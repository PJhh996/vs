using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Text.Json;
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
        public string EditBook(Dictionary<string, dynamic> bookDic)
        {
            // 编辑的逻辑处理
            return "ok";
        }
        #endregion

        #region 删除方法
        // 删除数据
        public string RemoveBook(string bookName)
        {
            // 删除的逻辑处理
            return "ok";
        }
        #endregion

        #region 查询所有数据方法
        // 查询所有数据
        public string SearchBook() // 返回值根据情况修改
        {
            // 新建一个list接受外部参数
            List<Dictionary<string,dynamic>> bookList = new();
            if (!File.Exists(path)) return "图书管理系统中暂无图书数据！！！\n  ";
            var jsonStr = File.ReadAllText(path);

            if (string.IsNullOrWhiteSpace(jsonStr))return "图书管理系统中暂无图书数据！！！\n  ";

            bookList = JsonSerializer.Deserialize<List<Dictionary<string, dynamic>>>(jsonStr);

            if (bookList.Count == 0) return "图书管理系统中暂无图书数据！！！\n  ";

            string result = "";
            foreach (var item in bookList)
            {
                result += $"书名:{item["name"]}--作者:{item["author"]}--价格:{item["price"]}\n";
            }

            return result;
        }
        #endregion

        #region 查询点个方法
        // 根据图书名称查询当前图书数据：强制要求
        public string SearchBook(string bookName) // 返回值根据情况修改
        {
            // 删除的逻辑处理
            return "ok";
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
