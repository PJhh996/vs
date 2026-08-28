namespace zuoye8_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 作业1
            List<Dictionary<string, dynamic>> list = new()
            {
                new Dictionary<string, dynamic>()
                {
                    ["name"] = "zs",
                    ["age"] = 29,
                    ["isMan"] = true,
                    ["isSingle"] = true,
                    ["salary"] = 4200
                },
                new Dictionary<string, dynamic>(){
                    ["name"] = "ls",
                    ["age"] = 20,
                    ["isMan"] = false,
                    ["isSingle"] = true,
                    ["salary"] = 3400
                },
                new Dictionary<string, dynamic>(){
                    ["name"] = "ww",
                    ["age"] = 19,
                    ["isMan"] = true,
                    ["isSingle"] = false,
                    ["salary"] = 6000
                },
                new Dictionary<string, dynamic>(){
                    ["name"] = "zl",
                    ["age"] = 14,
                    ["isMan"] = false,
                    ["isSingle"] = true,
                    ["salary"] = 2000
                },
                new Dictionary<string, dynamic>(){
                    ["name"] = "sq",
                    ["age"] = 35,
                    ["isMan"] = true,
                    ["isSingle"] = false,
                    ["salary"] = 7000
                },
                new Dictionary<string, dynamic>(){
                    ["name"] = "zb",
                    ["age"] = 27,
                    ["isMan"] = false,
                    ["isSingle"] = true,
                    ["salary"] = 2900
                },
            };
            // 作业1
            // Find: 要求查找年龄小于20的
            //var res = list.Find(item =>item["age"] < 20);
            //Console.WriteLine(res["name"]);

            // FindLast: 要求查找年龄大于25的
            //var res = list.FindLast(item => item["age"] > 25);
            //Console.WriteLine(res["name"]);

            // FindAll: 找出性别男的
            //var res = list.FindAll(item => item["isMan"] == true);
            //foreach (var item in res) Console.WriteLine(item["name"]);    

            // FindIndex: 找出薪水大于5000
            //var res = list.FindIndex(item => { return item["salary"] > 5000;
            //});
            //Console.WriteLine(list[res]["name"]);


            // FindLastIndex: 找出薪水小于3000
            //var res = list.FindLastIndex(item => item["salary"] < 3000);
            //Console.WriteLine(list[res]["name"]);


            // Exists: 判断是否有薪水大于5000            
            //var res = list.Exists(item => item["salary"] > 5000);
            //if(res)
            //Console.WriteLine("有的，有的兄弟");
            //else Console.WriteLine("这个真没有了兄弟");

            // ForEach: 输出每个的 名字-年龄-薪水
            //list.ForEach(item => Console.WriteLine($"{item["name"]}-{item["age"]}-{item["salary"]}"));


            // ConvertAll: 映射得到一个所以薪水的list
            //List<int> newList = list.ConvertAll(item => (int)item["salary"]);
            //Console.WriteLine(string.Join("-",newList));



            //TrueForAll: 判断是否都成年
            //var res = list.TrueForAll(item => item["age"] >= 18);
            //if (res) Console.WriteLine("这些家伙都成年了");
            //else Console.WriteLine("这些家伙中有人没有成年");


            // IndexOf？？？？？？？

            // LastIndexOf    ？？？？？？？？？
            #endregion

            //作业2:  封装一个函数 接收一个字符串; 返回一个字典,
            //键是字符串的每个字符,键值是这个字符在字符串中出现的次数
            //aacddbbda
            Func<string, Dictionary<char, int>> sss = (string aaa) =>
            {
                Dictionary<char, int> dic = new Dictionary<char, int>();

                //遍历字符串每一个字符
                foreach (char c in aaa)
                {
                    if (dic.ContainsKey(c))
                    {
                        //已经存在，次数+1
                        dic[c] = dic[c] + 1;
                    }
                    else
                    {
                        //不存在，新增，次数1
                        dic.Add(c, 1);
                    }
                }
                return dic;
            };

            //测试调用
            var res = sss("aacddbbda");
            foreach (var item in res)
            {
                Console.WriteLine($"字符:{item.Key} 次数:{item.Value}");
            }
        }
    }
}
