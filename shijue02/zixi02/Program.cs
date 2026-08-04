namespace xunlian2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //dynamic 变量名 = 值;   //不限制变量的类型，给任意类型的值，且可以修改成其他类型的值

            //var 变量名 = 值;   //自动捕获变量类型，不用主动盛名，不可以修改其他类型的值

            /*************************/
            //可变类型变量：
            //任意类型 语法：dynamic 变量名 = 值；
            // 变量的值可以是任意类型
            //dynamic a = 10;
            //Console.WriteLine($"a:{a}");
            //a = "abc";
            //Console.WriteLine($"a:{a}");
            //a = true;
            //Console.WriteLine($"a:{a}");


            //不确定类型的变量，给值就有类型了：
            //类型推导：var 变量名 = 值；
            //变量会根据赋值的数据的类型 作为变量的类型限制
            //var n = 10; //此时n只能是整形了
            //n = 10.1; //报错


            //变量类型检测：
            //变量类型检测 变量.GetType() ==> "System.数据类型"
            //int n = 10;
            //Console.WriteLine(n.GetType());
            //double m = 10.1;
            //Console.WriteLine(m.GetType());
            //string s = "aaa";
            //Console.WriteLine(s.GetType());
            //bool b = true;
            //Console.WriteLine(b.GetType());

            //dynamic a = 10;
            //Console.WriteLine($"a: {a}类型是{a.GetType()}");
            //a = "hello";
            //Console.WriteLine($"a: {a}类型是{a.GetType()}");
            //a = true;
            //Console.WriteLine($"a: {a}类型是{a.GetType()}");

            /*************************/

            //匿名类型
            //匿名类型也叫匿名对象，类似集合；多个数据集中在一个变量中，为了方便访问其中每个诗句，由键值对组成。
            //定义：使用var 自动捕获类型
            //语法：var 变量 = new {键名 = 键值，，，};

            //var user1 = new
            //{
            //    name = "seven",
            //    age = 22,
            //    gender = "boy"
            //};
            //Console.WriteLine(user1.GetType());
            //Console.WriteLine(user1.name);
            //user1.name = "lemon"; // 不可以修改
            //user1.Add("info",1);  // 不可以添加
            //user1.info = "abc"

            /*************************/

            //数据字典  可以新增和修改数据的集合
            //语法：数据字典：集合的一种，集合是多个数据在一个容器中，集合中的数据称为元素
            //一般我们会将一类数据放在集合中
            //数据字典集合中的元素是以 键值对 形式存储的
            //Dictionary<键名的类型，键值的类型> 变量名 = new Dictionary<数据类型，数据类型> {初始值}
            //Dictionary<string, dynamic> user = new Dictionary<string, dynamic>()
            //{
            //    ["name"] = "雨姐",
            //    ["age"] = 43,
            //    ["gender"] = "girl",
            //    ["boyFriend"] = new Dictionary<string, dynamic>()
            //    {
            //        ["name"] = "神",
            //        ["age"] = 1000,
            //        ["gender"] = "boy",
            //    }
            //};

            //Console.WriteLine(user);
            //Console.WriteLine(user.GetType());

            // 访问
            //Console.WriteLine(user["name"]);
            //Console.WriteLine(user["age"]);
            //Console.WriteLine(user["boyFriend"]["name"]);
            //Console.WriteLine(user["abc"]); //报错:  如果访问了不存在的 元素键名 则报错

            // 了解: 通过方法获取 字典的键值 
            // 语法: 字典.TryGetValue(键名, out 类型 接受键值的变量)
            // 返回值: 布尔值
            //Console.WriteLine(user.TryGetValue("name",out dynamic val));
            //Console.WriteLine(val);
            //Console.WriteLine(user.TryGetValue("abc", out dynamic val)); 

            // 获取字典中的元素个数  字典.Count
            //Console.WriteLine(user.Count);

            // 修改
            //user["boyFriend"]["name"] = "翠花";
            //Console.WriteLine(user["boyFriend"]["name"]);

            // 添加 (键名不存在就是添加)
            //user["height"] = 180;
            //Console.WriteLine(user["height"]);

            // 删除 
            //user.Remove("gender");
            //Console.WriteLine(user.TryGetValue("gender", out dynamic val));

            // 清空 .Clear()
            //Console.WriteLine(user["name"]);
            //Console.WriteLine(user["age"]);
            //user.Clear();
            //Console.WriteLine(user.TryGetValue("name",out dynamic v1));
            //Console.WriteLine(user.TryGetValue("age", out dynamic v2));

            /*************************/

            //数组
            //数组: 就是一个固定长度的“容器”，用来存放多个 数据类型相同的元素。
            //数组中多个数据按顺序存储，每个小空间以下标（从0开始向后递增的数字）操作。
            //语法1：类型[] 变量名 = new 类型[长度]

            //语法2：类型[] 变量名 = [值, .. ..] 自动推断长度
            //类型[] 变量名 = { 值, .... }  老版本中使用 `{ }`

            // 定义：指定集合中数据类型
            string[] stu = ["张三", "李四", "王五"];
            // 数组: 就是一个固定长度的“容器”，用来存放多个数据类型相同的元素。
            // 数组中多个数据按顺序存储，每个小空间以下标（从0开始向后递增的数字）操作。

            // 定义数组
            //语法1：类型[] 变量名 = new 类型[长度]            
            //int[] arr = new int[3];
            // 指定了长度默认值 int的0
            //Console.WriteLine(arr[0]);
            //Console.WriteLine(arr[1]);

            //语法2：类型[] 变量名 = [值, .. ..]  自动推断长度
            //int[] arr1 = [10, 20, 30];
            // 访问
            //Console.WriteLine(arr1[0]);
            //Console.WriteLine(arr1[1]);
            //Console.WriteLine(arr1[2]);

            // 修改
            //Console.WriteLine(arr1[0]);
            //arr1[0] = 100;
            //Console.WriteLine(arr1[0]);

            // 不能新增
            //arr1[3] = 123; // 无效
            //Console.WriteLine(arr1[3]); // 报错

            // 获取长度
            //Console.WriteLine(arr1.Length);
            //Console.WriteLine(arr1.Count());

            //string[] arr2 = { "L", "O", "V", "E" }; // 老版本中 使用{} 创建
            //Console.WriteLine(arr2[2]);


            /*************************/

            //list数据集合
            // list数据集合
            // 加强版的数组: list列表集合 可以新增 可以删除
            //List<string> stus = new List<string>()
            //{
            //    "张三",
            //    "李四",
            //    "王五",
            //    "赵六",
            //};
            // list集合中的数据 也是通过下标访问的
            //Console.WriteLine(stus[0]);
            //Console.WriteLine(stus[1]);
            //Console.WriteLine(stus[2]);
            //Console.WriteLine(stus[3]);
            //Console.WriteLine(stus[4]); // 报错: 下标超出范围

            // 修改
            //stus[0] = "田七";
            //Console.WriteLine(stus[0]);

            // 获取长度
            //Console.WriteLine(stus.Count);

            // 不能访问 范围外的下标
            //stus[4] = "田七"; // 报错

            //Add:给数组末尾新增数据
            //List<int> arr1 = new List<int>()
            //{
            //    10,
            //    20,
            //    30
            //};
            ////  Add：给数组末尾新增数据
            //Console.WriteLine(arr1.Count); // 3
            //arr1.Add(100);
            //Console.WriteLine(arr1.Count); // 4
            //Console.WriteLine(arr1[3]);

            //AddRange：给数组末尾新增多个数据
            //List<string> arr2 = new List<string>() { "a", "b", "c" };
            //Console.WriteLine(arr2.Count);
            ////arr2.AddRange(["DD", "EE"]); // 参数必须 也是一个集合
            //arr2.AddRange(new List<string>() { "FF", "GG" }); // 参数必须 也是一个集合
            //Console.WriteLine(arr2.Count); // 添加成功后 集合长度有变化
            //Console.WriteLine(arr2[3]);
            //Console.WriteLine(arr2[4]);

            //Insert：在任意下标位置新增数据
            //List<string> arr3 = new List<string>() { "a", "b", "c" };
            ////list集合.Insert(插入的下标位置,要插入的数据)
            ////arr3.Insert(2, "f"); //  "a", "b","f" ,"c" 
            ////arr3.Insert(3, "f");
            ////arr3.Insert(4, "g"); // 注意: 新增数据的下标 范围 0 到 集合.Count
            ////Console.WriteLine(arr3.Count); // 添加成功后 集合长度有变化
            //Console.WriteLine(arr3[2]);
            //Console.WriteLine(arr3[3]);
            //Console.WriteLine(arr3[4]);

            //Remove：将List中指定的数据删除
            //List<int> nums = new List<int>() { 10, 20, 30 };
            //nums.Remove(20);
            //Console.WriteLine(nums[0]);
            //Console.WriteLine(nums[1]);
            //Console.WriteLine(nums[2]); // 报错: 删除后 2 超出 下标范围

            //RemoveAt：将List中指定下标的数据删除
            //List<int> nums1 = new List<int>() { 10, 20, 30 };
            //nums1.RemoveAt(2);
            //Console.WriteLine(nums1[0]); // 10
            //Console.WriteLine(nums1[1]); // 20
            //Console.WriteLine(nums1[2]); // 报错: 删除后 2 超出 下标范围

            //RemoveRange：删除数组中指定的多个数据
            //List<int> nums2 = new List<int>() { 10, 20, 30, 40 };
            ////list集合.RemoveRange(下标,个数) // 从下标开始删除指定个数
            //nums2.RemoveRange(1, 2);
            //Console.WriteLine(nums2[0]); // 10
            //Console.WriteLine(nums2[1]);  // 40
            //Console.WriteLine(nums2[2]); // // 报错: 删除后 2 超出 下标范围

            //Clear：清空所有数据
            //  返回值为布尔值
            //List<string> sArr2 = new List<string>() { "a", "b", "c" };
            //Console.WriteLine(sArr2.Contains("b"));
            //Console.WriteLine(sArr2.Contains("f"));

            //IndexOf：查找某个数据在List中第一次出现的下标，结果找到就是下标，找不到就是 - 1
            //List<string> sArr3 = new List<string>() { "a", "b", "c", "d", "a", "b", "f" };
            //Console.WriteLine(sArr3.IndexOf("c")); // 2
            //Console.WriteLine(sArr3.IndexOf("b")); // 1
            //Console.WriteLine(sArr3.IndexOf("f")); // 6
            //Console.WriteLine(sArr3.IndexOf("x")); // -1

            //LastIndexOf：找某个数据在List中最后一次出现的下标，找到就得到下标，找不到就是-1
            //  LastIndexOf：找某个数据在List中最后一次出现的下标，找到就得到下标，找不到就是  -1
            //List<string> sArr4 = new List<string>() { "a", "b", "c", "d", "a", "b", "f" };
            //Console.WriteLine(sArr4.LastIndexOf("c")); // 2
            //Console.WriteLine(sArr4.LastIndexOf("b")); // 5
            //Console.WriteLine(sArr4.LastIndexOf("f")); // 6
            //Console.WriteLine(sArr4.LastIndexOf("x")); // -1

            //GetRange：从List中获取多个数据
            List<string> sArr5 = new List<string>() { "a", "b", "c", "d", "e", "f", "g" };
            // GetRange(开始下标, 个数) 返回一个list集合
            //List<string> newsArr = sArr5.GetRange(2, 3);
            //Console.WriteLine(newsArr[0]);
            //Console.WriteLine(newsArr[1]);
            //Console.WriteLine(newsArr[2]);
            ////Console.WriteLine(newsArr[3]); // 报错

            //Console.WriteLine(sArr5[2]);
            //Console.WriteLine(sArr5[3]);

            //Reverse：翻转
            //List<string> sArr6 = new List<string>() { "L", "O", "V", "E" };
            //sArr6.Reverse();
            //Console.WriteLine(sArr6[0]); // "E"
            //Console.WriteLine(sArr6[1]); // "V"
            //Console.WriteLine(sArr6[2]); // "O"
            //Console.WriteLine(sArr6[3]); // "L"

            /*************************/

            //随机数
            //语法：
            //Random r = new Random();
            //int num = r.Next(9); // 获取0-9的随机整数，不包含9
            //Console.WriteLine(num);
            //double num1 = r.NextDouble(); // 获取随机浮点数,0-1
            //Console.WriteLine(num1);

            // 随机数:定义一个随机数对象，调用他的生成随机数方法
            // 随机数
            //var r = new Random(); // 获取到随机对象
            // 随机对象.Next(正整数n) ===> 获取随机0~n的随机整数 不包含n
            //int r1 = r.Next(5); // 获取0~5之间的随机整数 不包含5
            //Console.WriteLine(r1);
            // 随机对象.Next(n,m) ===> 获取随机n~m的随机整数 不包含m
            //Console.WriteLine(r.Next(1));
            //Console.WriteLine(r.Next(1, 5));

            // 随机对象.NextDouble()  返回0~1之间的小数
            //Console.WriteLine(r.NextDouble()); 
            //Console.WriteLine(r.NextDouble()); 
            //Console.WriteLine(r.NextDouble()); 
            //Console.WriteLine(r.NextDouble()); 

            // 5~10的随机小数
            //Console.WriteLine(r.Next(5,10) + r.NextDouble());

            //例子：点名器（随即下标）
            // 随机点名
            /*
             需要将多个姓名放在一起 ==> List
             随机生成一个下标
             */

            // 使用List存放多个姓名
            //List<string> students = new List<string>()
            //{
            //    "谢谊","覃东稳",
            //    "姜添舒","张小松","方锦",
            //    "黄陆基","王耀腾","李佳鑫",
            //    "蓝启耿","周佳龙","黄宇盛",
            //    "韦炳湘","韩旭颖","钟朝林",
            //    "曾杰文","李卓达","彭钇霖",
            //    "田健","何战胜","徐诚",
            //    "张仁杰","龙昊","陈佳",
            //    "陈志锋","王明宇","李之阳",
            //    "潘家涵","蓝浩天","杨天硕",
            //    "董俊涛","蒙琛 ","张英玉",
            //    "陈煜松","莫远宁","李家良",
            //    "丁佳俊","谭森华","刘宏阳",
            //    "宁东明","崔世锦","唐海波",
            //};
            //// students 集合的下标 0~students.Count
            //// 获取随机的下标
            //Random r = new Random();
            //int i = r.Next(students.Count);
            //Console.WriteLine(students[i]);

            /*************************/

            //数据结构

                //商品

                // 商品的数据结构
                /**
                 * 单个商品具备的元素 ===> 单个商品使用 字典 类型存储比较合适
                 * img: 图片
                 * name: 名称
                 * price: 价格
                 * introduce: 描述
                 */
                            // 多个电商 可以使用list集合存储
                List<Dictionary<string, dynamic>> goods = new List<Dictionary<string, dynamic>>()
                {
                    new Dictionary<string,dynamic> ()
                    {
                        ["name"] = "耳机",
                        ["img"] = "图片地址",
                        ["price"] = 110,
                        ["introduce"] = "描述1",
                    },
                    new Dictionary<string,dynamic> ()
                    {
                        ["name"] = "儿童桌",
                        ["img"] = "图片地址",
                        ["price"] = 1200,
                        ["introduce"] = "描述2",
                    },
                    new Dictionary<string,dynamic> ()
                    {
                        ["name"] = "鼠标",
                        ["img"] = "图片地址",
                        ["price"] = 24,
                        ["introduce"] = "描述4",
                    }
                };

                // 后续可以给goods 中添加 商品


               //歌曲


                // 歌曲数据结构
                /**
                 * 单个歌曲的 数据元素  ===> 单个歌曲使用 字典 类型存储比较合适
                 * name: 歌名
                 * author: 作者
                 * lrc: 歌词
                 * comment: 多个评论 ===> 使用list集合存储
                 * 单个评论的数据元素  ===> 使用字典存储
                 *   name: 评论者
                 *   content: 评论内容
                 */
                            // 多个歌曲 可以使用list集合存储

                List<Dictionary<string, dynamic>> songs = new List<Dictionary<string, dynamic>>()
                {
                   new Dictionary<string, dynamic>()
                   {
                    ["name"] = "鲨鱼宝宝",
                    ["author"]= "谢谊",
                    ["lrc"]= "歌词1",
                    ["comment"] = new List<Dictionary<string, dynamic>>()
                    {
                        new Dictionary<string, dynamic>()
                        {
                            ["name"]="覃东稳",
                            ["content"]= "下个歌王"
                        },
                        new Dictionary<string, dynamic>()
                        {
                            ["name"]="张学友",
                            ["content"]= "下一个歌神"
                        }
                    }
                   },
                   new Dictionary<string, dynamic>()
                   {
                    ["name"] = "下一个天亮",
                    ["author"]= "姜添舒",
                    ["lrc"]= "歌词1",
                    ["comment"] = new List<Dictionary<string, dynamic>>()
                    {
                        new Dictionary<string, dynamic>()
                        {
                            ["name"]="周杰伦",
                            ["content"]= "下次别唱"
                        },
                        new Dictionary<string, dynamic>()
                        {
                            ["name"]="张小松",
                            ["content"]= "一起唱...."
                        }
                    }
                   },
                };      
        }
    }
}
