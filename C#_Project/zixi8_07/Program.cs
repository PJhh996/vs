namespace zixi8_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] arr = new int[5];
            //    Console.WriteLine(arr[0]);

            //遍历字典
            //Dictionary<string, dynamic> aaa = new()
            //{
            //    ["name"] = "cff",
            //    ["age"] = 18,
            //};
            //aaa.Add("height", 188);
            //方式1：遍历KeyValuePair    (KeyValuePair ==> 键值对)
            //foreach (dynamic item in aaa.Keys)
            //{
            //    Console.WriteLine(item);
            //}

            //foreach (dynamic item in aaa.Values)
            //{
            //    Console.WriteLine(item);
            //}

            //foreach (dynamic item in aaa)
            //{
            //    Console.WriteLine(item);
            //}

            //思路1：遍历每个元素，让这个元素跟他后面的每一个元素都做比较，相等就删掉
            //List<int> ints = [1, 3, 3, 4, 5, 6, 7, 7, 8, 6, 4, 2, 3];
            //for (int j = 0; j < ints.Count; j++)
            //{
            //    for (int i = j + 1; i < ints.Count; i++)
            //    {
            //        if (ints[j] == ints[i])
            //        {
            //            ints.RemoveAt(i);
            //            i--;
            //        }
            //    }
            //}
            //foreach (int n in ints)
            //{
            //    Console.WriteLine(n);
            //}

            //思路2：找元素最后一次出现的下标，跟第一次出现的下标是否相等，
            //相等就表示元素没有重复，不相等就表示有重复，要删除掉最后一个重复元素。
            //List<int> ints = [1, 3, 3, 4, 5, 6, 7, 7, 8, 6, 4, 2, 3];
            //for (int i = 0; i < ints.Count; i++)
            //{
            //    while(true)
            //    {
            //        int index = ints.LastIndexOf(ints[i]);
            //        if (ints.LastIndexOf(ints[i]) != i)
            //        {
            //            ints.RemoveAt(index);
            //        }
            //        else 
            //        {
            //            break;
            //        }
            //    }
            //}
            //foreach (int x in ints)
            //{
            //    Console.WriteLine(x);
            //}

            //思路3：利用字典中的键是唯一的，将List中每个数据都作为字典的键，
            //最终在字典中的键都是唯一的，将所有键放在一个新的List中
            //创建一个字典
            // 遍历ints 将 其中的数据 作为 tmpDic的键名, 键值无所谓
            // 取出字典中的键 转为List
            // 验证去重效果

            //List<int> ints = [1, 3, 3, 4, 5, 6, 7, 7, 8, 6, 4, 2, 3];
            //Dictionary<int, dynamic> aaa = new();
            //foreach (int i in ints)aaa[i] = "wuwu";
            //List<int> bbb = aaa.Keys.ToList();
            //foreach (int j in bbb) Console.WriteLine(j);

            //思路4：创建一个新的List，遍历原本的List，原本List中的每一个元素，
            //放在新的List中进行判断是否存在，如果不存在就添加到新的List中，如果存在就不添加
            //List<int> ints = [1, 3, 3, 4, 5, 6, 7, 7, 8, 6, 4, 2, 3];
            //List<int> newList = [];
            //foreach (int i in ints)
            //{
            //    if (!newList.Contains(i))
            //    { 
            //        newList.Add(i);
            //    }
            //}
            //foreach (int a in newList)
            //{
            //    Console.WriteLine(a);
            //}


            //冒泡排序
            //自动比较排序
            //List<int > ints = [5,3,300,4,100,6,7,8,9,1,2];
            //for (int n = 0; n < ints.Count-1; n++)
            //{
            //    for (int i = 0; i < ints.Count - 1 - n; i++)
            //    {
            //        if (ints[i] > ints[i + 1])
            //        { 
            //            int tmp = ints[i];
            //            ints[i] = ints[i + 1];
            //            ints[i + 1] = tmp;
            //        }
            //    }
            //}
            //foreach(int aa in ints) Console.WriteLine(aa);

            //List<int> ints = [5, 3, 300, 4, 100, 6, 7, 8, 9, 1, 2];
            //for (int n = 0; n < ints.Count - 1; n++)
            //{
            //    for (int i = 0; i < ints.Count - 1 - n; i++)
            //    {
            //        if (ints[i] < ints[i + 1])
            //        {
            //            int tmp = ints[i];
            //            ints[i] = ints[i + 1];
            //            ints[i + 1] = tmp;
            //        }
            //    }
            //}
            //foreach (int aa in ints) Console.WriteLine(aa);


            List<Dictionary<string, dynamic>> goodsList = new List<Dictionary<string, dynamic>>
            {
                new Dictionary<string, dynamic>
                {
                    {"name", "机械键盘"},
                    {"price", 299.99},
                    {"code", "G001"},
                    {"stock", 120}
                },
                new Dictionary<string, dynamic>
                {
                    {"name", "无线鼠标"},
                    {"price", 89.50},
                    {"code", "G002"},
                    {"stock", 356}
                },
                new Dictionary<string, dynamic>
                {
                    {"name", "27寸显示器"},
                    {"price", 1299.00},
                    {"code", "G003"},
                    {"stock", 48}
                },
                new Dictionary<string, dynamic>
                {
                    {"name", "电竞耳机"},
                    {"price", 199.00},
                    {"code", "G004"},
                    {"stock", 85}
                },
                new Dictionary<string, dynamic>
                {
                    {"name", "电脑支架"},
                    {"price", 69.90},
                    {"code", "G005"},
                    {"stock", 210}
                }
            };
            // 按照价格做排序
            // 提示输入的 是price还是stock  排序类型 
            // 提示输入的是 ASC 还是DSC     排序顺序(ASC升序,DSC降序)
            // 根据输入完成数据排序
            Console.WriteLine("请输入排序类型（price/stock）：");
            string leixing = Console.ReadLine();
            //if (leixing == "price")
            //{
            //    string leixing = "price"
            //}
            //if (leixing == "stock")
            //{
            //    string leixing = "stock"
            //}
            Console.WriteLine("请输入排序顺序（ASC/DSC）：");
            string shunxu = Console.ReadLine();
            if (leixing == "price" && shunxu == "ASC")
            {
                for (int n = 0; n < goodsList.Count - 1; n++)
                {
                    for (int i = 0; i < goodsList.Count - 1 - n; i++)
                    {
                        if (goodsList[i]["price"] > goodsList[i + 1]["price"])
                        {
                            Dictionary<string, dynamic> tmp = goodsList[i];
                            goodsList[i] = goodsList[i + 1];
                            goodsList[i + 1] = tmp;
                        }
                    }
                }
                foreach (Dictionary<string, dynamic> aa in goodsList)
                    Console.WriteLine($"{aa["name"]}--{aa["price"]}");
            }
            else if (leixing == "stock" && shunxu == "ASC")
            {
                for (int n = 0; n < goodsList.Count - 1; n++)
                {
                    for (int i = 0; i < goodsList.Count - 1 - n; i++)
                    {
                        if (goodsList[i]["stock"] > goodsList[i + 1]["stock"])
                        {
                            Dictionary<string, dynamic> tmp = goodsList[i];
                            goodsList[i] = goodsList[i + 1];
                            goodsList[i + 1] = tmp;
                        }
                    }
                }
                foreach (Dictionary<string, dynamic> aa in goodsList)
                    Console.WriteLine($"{aa["name"]}--{aa["stock"]}");
            }
            else if (leixing == "price" && shunxu == "DSC")
            {
                for (int n = 0; n < goodsList.Count - 1; n++)
                {
                    for (int i = 0; i < goodsList.Count - 1 - n; i++)
                    {
                        if (goodsList[i]["price"] < goodsList[i + 1]["price"])
                        {
                            Dictionary<string, dynamic> tmp = goodsList[i];
                            goodsList[i] = goodsList[i + 1];
                            goodsList[i + 1] = tmp;
                        }
                    }
                }
                foreach (Dictionary<string, dynamic> aa in goodsList)
                    Console.WriteLine($"{aa["name"]}--{aa["price"]}");
            }
            else if (leixing == "stock" && shunxu == "DSC")
            {
                for (int n = 0; n < goodsList.Count - 1; n++)
                {
                    for (int i = 0; i < goodsList.Count - 1 - n; i++)
                    {
                        if (goodsList[i]["stock"] < goodsList[i + 1]["stock"])
                        {
                            Dictionary<string, dynamic> tmp = goodsList[i];
                            goodsList[i] = goodsList[i + 1];
                            goodsList[i + 1] = tmp;
                        }
                    }
                }
                foreach (Dictionary<string, dynamic> aa in goodsList)
                    Console.WriteLine($"{aa["name"]}--{aa["stock"]}");
            }
            else { Console.WriteLine("输入 排序类型 或 排序顺序 有误"); }


        }
    }
}
