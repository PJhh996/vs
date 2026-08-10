using System;
using System.Globalization;
using System.Text.RegularExpressions;


namespace zixi8_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string str = "abbccdd";
            //string aaa = "";
            //for (int i = 0; i < str.Length; i++)
            //{
            //    int j = 0;
            //    for ( ; j < aaa.Length; j++)
            //    {
            //        if (str[i] == aaa[j]) break;
            //    }
            //    if (j == aaa.Length) aaa += str[i];
            //}
            //Console.WriteLine(aaa);


            //string str = "生活总会有大麻烦，黑夜总会过去";
            //List<string> mingan = ["大麻","夜总会"];
            //foreach (var item in mingan)
            //{
            //    string newStr = "";
            //    for (int i = 0; i < item.Length; i++)
            //    {
            //        newStr += "*";
            //    }
            //    str = str.Replace(item,newStr);
            //}
            //Console.WriteLine(str);

            //string old = "you love i";
            //string[] strArr = old.Split();
            //List<string> haha = new ();
            //foreach (string yuansu in strArr)
            //{
            //    haha.Add(yuansu);
            //}
            //haha.Reverse ();
            //string res = "";
            //foreach (string str in haha)
            //{ 
            //    string one = str.Substring(0,1).ToUpper();
            //    string hou = str.Substring(1).ToLower();
            //    res += one + hou + " ";
            //}
            //Console.WriteLine(res.Substring(0,res.Length-1));

            //string str = "aa";
            //Console.WriteLine(str.PadLeft(4,'*'));

            //int? a = null;
            //Console.WriteLine(a);

            //string b = null;  //null相当于""
            //Console.WriteLine(b);
            //b = "aaa";
            //Console.WriteLine(b);

            //string arr = "asdfhe";
            //Console.WriteLine(arr.Length );

            //可以通过下标 配合长度完成字符串的遍历
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}

            //利用遍历对字符串去重
            //string str = "aaabbssdfdf";
            //string res = "";
            //for (int i = 0; i < str.Length;i++)
            //{
            //    int j = 0;
            //    for (; j < res.Length; j++)
            //    {
            //        if (str[i] == res[j]) break;
            //    }
            //    if (j == res.Length) res += str[i];
            //}
            //Console.WriteLine(res);

            //字符串 空值 判断
            //string.IsNullOrEmpty:判断字符串是否为空或null
            //string.IsNullOrWhiteSpace:判断字符串是否为null或空格

            //string str = null;
            //string str = "a";
            //bool res = string.IsNullOrEmpty(str);
            //Console.WriteLine(res);

            //bool res = string.IsNullOrWhiteSpace(str);
            //Console.WriteLine(res);

            //Substring：截取字符串
            //字符串.Substring（开始下标） //从下标开始到最后截取字符串内容
            //字符串.Substring（开始下标，个数） //从下标开始根据个数，截取字符串内容
            //string str = "abcdefg";
            //string res = "";
            //res = str.Substring(0, 3);
            //Console.WriteLine(res);
            //res = str.Substring(3);
            //Console.WriteLine(res);

            //Contains：判断字符串中是否包含小字符串（子串）
            //string str = "abcdefg";
            //bool res = str.Contains("b"); //True
            //Console.WriteLine(res);       
            //res = str.Contains("ab");     //True
            //Console.WriteLine(res);
            //res = str.Contains("aa");     //False
            //Console.WriteLine(res);
            //res = str.Contains("h");      //False
            //Console.WriteLine(res);
            //例子：去重
            //string str = "aaddbbf";
            //string res = "";
            //for (int i = 0; i < str.Length; i++)
            //{
            //    if (!res.Contains(str[i])) res += str[i];
            //}
            //Console.WriteLine(res);

            //StartsWith：判断字符串是否用某个子串开头
            //EndsWith：判断字符串是否以某个子串结尾
            //string str = "abcdddddefg";
            //bool res = str.StartsWith("a");
            //bool res = str.StartsWith("aa");
            //bool res = str.EndsWith("fg");
            //Console.WriteLine(res);

            //IndexOf：在字符串中找某个子串第一次出现的下标，找到得到下标，找不到得到 - 1
            // 字符串.IndexOf(子串)  查找子串第一次出现的下标
            // 字符串.IndexOf(子串,开始下标)  从开始下标查找子串第一次出现的下标            
            //string str = "abcdebfg";
            ////int index = str.IndexOf("b");
            //int index = str.IndexOf("k");
            ////int index = str.IndexOf("b",2);
            //Console.WriteLine(index);

            //LastIndexOf：在字符串中找某个子串最后一次出现的下标，找到得到下标，找不到得到 - 1
            // 语法参数和IndexOf 一样
            //string str = "abcdebfg";
            ////int index = str.LastIndexOf("b");
            ////int index = str.LastIndexOf("b", 2);
            //int index = str.LastIndexOf("b",0 );
            //Console.WriteLine(index);

            //ToUpper：将字符串中的小写字母转成大写字母只有字母区分大小写，其他字符没有大小写区分
            //ToLower：将字符串中的大写字母转成小写字母
            // ToUpper: 将字符串内容转为大写
            // ToLower: 将字符串内容转为小写
            // 注意: 只有英文字符串才有大小写区分
            //string str = "abcDDDDefg";
            //Console.WriteLine(str.ToUpper()); // ABCDDDDEFG
            //Console.WriteLine(str.ToLower()); // abcddddefg

            //Trim：去除字符串首尾两端的空格
            //补充：类型中还有一种类型char类型，字符类型，单个字符(字符串)
            // string 字符串类型 使用双引号包裹 表示一串字符的集合 一般用表示一段内容 
            // char 字符类型 使用单引号包裹, 表示单个字符, 字符类型可以和整型转换
            //string str = "ABC";
            //char s = 'A';
            //Console.WriteLine((int)s);

            //string str = ",,!!,abc!!,,,";
            //Console.WriteLine("-" + str + "|"); // -  abc    |
            //string res = str.Trim(','); // 根据传入的字符去除首尾两端内容
            //string res = str.Trim(',', '!'); // 根据传入的字符去除首尾两端内容
            //Console.WriteLine("-" + res + "|"); // -abc|

            //TrimStart：去除开头的空格
            //TrimEnd：去除结尾的空格
            // Trim：去除字符串首尾两端的空格
            //string str = "  abc    ";
            //Console.WriteLine("-" + str + "|"); // -  abc    |
            //string res = str.Trim();
            //Console.WriteLine("-" + res + "|"); // -abc|

            // TrimStart：去除开头的空格
            //string str = "  abc    ";
            //Console.WriteLine("-" + str + "|"); // -  abc    |
            //string res = str.TrimStart();
            //Console.WriteLine("-" + res + "|"); // -abc    |

            // TrimEnd：去除结尾的空格
            //string str = "  abc    ";
            //Console.WriteLine("-" + str + "|"); // -  abc    |
            //string res = str.TrimEnd();
            //Console.WriteLine("-" + res + "|"); // -  abc|

            //Replace：将字符串中指定的子串都替换成的新的子串
            //// Replace：将字符串中指定的子串都替换成的新的子串
            //string str = "abacdaeafeeg";
            //Console.WriteLine(str.Replace("a","0"));
            //Console.WriteLine(str.Replace("ee", "**"));

            // 敏感词替换为 * , 而且个数要保持一致
            //string str = "生活总会有大麻烦, 黑夜总会过去";
            //List<string> mgc = new() { "大麻","夜总会"};
            //foreach (string s in mgc) 
            //{
            //    string newStr = "";
            //    for (int i = 0; i < s.Length; i++)
            //    {
            //        newStr += "*";
            //    }
            //    str = str.Replace(s, newStr);
            //}
            //Console.WriteLine(str);
            // 生活总会有**烦, 黑***过去

            //分割字符串 Split
            // 字符串.Split(指定分隔符)
            //string str = "西瓜_葡萄_芒果_榴莲";
            //string[] resArr = str.Split("_");
            ////Console.WriteLine(resArr);
            //foreach(string item in resArr) Console.WriteLine(item);

            //string str = "西瓜 葡萄 芒果 榴莲";
            //string[] resArr = str.Split(); // 默认使用空格作为分隔符
            ////Console.WriteLine(resArr);
            //foreach (string item in resArr) Console.WriteLine(item);

            //string str = "西瓜-葡萄-芒果-榴莲";
            //string[] resArr = str.Split("-",2); // 参数2 数字将字符串分割为两份
            ////Console.WriteLine(resArr);
            //foreach (string item in resArr) Console.WriteLine(item);

            //string str = "西瓜--葡萄--芒果--榴莲"; // ""   "  "
            ////string[] resArr = str.Split("-"); 
            //string[] resArr = str.Split("-", StringSplitOptions.RemoveEmptyEntries);  //移除空字符串 
            ////Console.WriteLine(resArr);
            //foreach (string item in resArr) Console.WriteLine(item);

            //string str = "西瓜-葡萄!芒果+榴莲";
            //string[] resArr = str.Split(['-', '!', '+']);
            ////Console.WriteLine(resArr);
            //foreach (string item in resArr) Console.WriteLine(item);
            //例："you love i"`转成`"I Love You"
            //string oldStr = "you love i";
            //string[] strArr = oldStr.Split();
            //List<string> strList = new List<string>();
            //foreach (string str in strArr)
            //{
            //    strList.Add(str);

            //}
            //strList.Reverse();
            //string newStr = "";
            //foreach (string item in strList)
            //{
            //    string one = item.Substring(0,1).ToUpper();
            //    string hou = item.Substring(1).ToLower();
            //    newStr  += one + hou+" ";
            //}
            //Console.WriteLine(newStr.Substring(0,newStr.Length-1));

            //string.Concat：将多个字符串拼接成一个大字符串
            //string str1 = "aa";
            //string str2 = "bb";
            //string str3 = "cc";
            ////string[] strArr = ["qq", "ww", "EE"];
            //string res = string.Concat(str1, str2, str3);
            ////string res = string.Concat(strArr);
            //Console.WriteLine(res); // aabbcc

            //string.Join：将数组或List中的所有元素使用指定的连接符拼接成一个字符串
            //string[] strArr = ["qq", "ww", "EE"];
            //Console.WriteLine(string.Join("-", strArr)); // qq-ww-EE

            //List<string> strList = ["I", "Love", "U"];
            //Console.WriteLine(string.Join(" ",strList)); // I Love U 

            //PadLeft：给字符串左边填充指定的符号填满指定的长度
            //PadRight：给字符串右边填充指定的符号填满指定的长度
            //string str = "aa";
            // 字符串.PadLeft(数字,填充字符) // 数字表示填充后的长度
            //Console.WriteLine(str.PadLeft(2, '*')); // aa
            //Console.WriteLine(str.PadLeft(1, '*')); // aa
            //Console.WriteLine(str.PadLeft(4, '*')); // **aa

            //Console.WriteLine(str.PadRight(3,'*')); // aa*

            //// 敏感词替换为 * , 而且个数要保持一致
            //string str = "生活总会有大麻烦, 黑夜总会过去";
            //// 假设list存储敏感词
            //List<string> mgc = ["大麻", "夜总会"];

            //foreach (string str1 in mgc)
            //{
            //    string newStr = "".PadRight(str1.Length,'*');                
            //    str = str.Replace(str1, newStr);
            //}
            //Console.WriteLine(str);

            //Remove：删除字符串中的一段
            //string str = "abcdefhijk";
            //// 字符串.Remove(开始下标)// 从开始下标往最后的全删除
            //// 字符串.Remove(开始下标,个数)// 从开始下标根据个数删除
            //// 返回的是删除后的字符串
            ////Console.WriteLine(str.Remove(2)); // ab
            //Console.WriteLine(str.Remove(2, 3)); // abfhijk
            //Console.WriteLine(str);


            /************************************************/
            //正则表达式
            //提取
            //string reg = @"a";
            //string str = "bac";
            ////  Regex.Match(字符串,正则规则);  // 按照规则从字符串中提取内容
            //Match res = Regex.Match(str, reg);
            //Console.WriteLine(res.Value); // a

            //验证方法
            // Regex.IsMatch(字符串,正则)  // 判断字符串是否符合规则内容
            //string reg = @"a";
            //bool res = Regex.IsMatch("bac", reg);
            //Console.WriteLine(res); // True
            //bool res1 = Regex.IsMatch("bcd", reg);
            //Console.WriteLine(res1); // False

            //替换方法
            // // Regex.Replace(字符串,正则,替换上的内容) // 按照正则规则 将字符串中的内容替换上指定字符串
            // 返回替换完成的字符串
            //string reg = @"a";
            //string res = Regex.Replace("bac", reg, "e");
            //Console.WriteLine(res); // bec


            /*********************************************/
            // 特殊字符:  代表规则中要匹配的字符。
            //var reg = @"."; // 表示任意一个字符
            //Console.WriteLine(Regex.IsMatch("  ",reg));                
            //Console.WriteLine(Regex.IsMatch(" 你好 ", reg));                

            //var reg = @"\d"; // 表示任意一个数字
            //Console.WriteLine(Regex.IsMatch("abc", reg)); // False
            //Console.WriteLine(Regex.IsMatch("abc1", reg));  // True
            //Console.WriteLine(Regex.IsMatch("123", reg));  // True

            //var reg = @"\D"; // 表示任意一个非数字
            //Console.WriteLine(Regex.IsMatch("abc", reg)); // True
            //Console.WriteLine(Regex.IsMatch("abc1", reg));  // True
            //Console.WriteLine(Regex.IsMatch("123", reg));  // False

            //var reg = @"\w"; // 表示任意一个数字字母下划线
            //Console.WriteLine(Regex.IsMatch("abc", reg)); // True
            //Console.WriteLine(Regex.IsMatch("abc1", reg));  // True
            //Console.WriteLine(Regex.IsMatch("123", reg));  // True
            //Console.WriteLine(Regex.IsMatch("你好_", reg));  // True
            //Console.WriteLine(Regex.IsMatch("你好AAA", reg));  // True
            //Console.WriteLine(Regex.IsMatch("*<>", reg));  // False
            //Console.WriteLine(Regex.IsMatch("!@#$", reg));  // False

            //var reg = @"\W"; // 表示任意一个非数字字母下划线
            //Console.WriteLine(Regex.IsMatch("abc", reg)); // False
            //Console.WriteLine(Regex.IsMatch("abc1", reg));  // False
            //Console.WriteLine(Regex.IsMatch("123", reg));  // False
            //Console.WriteLine(Regex.IsMatch("你好_", reg));  // False
            //Console.WriteLine(Regex.IsMatch("你好AAA", reg));  // False
            //Console.WriteLine(Regex.IsMatch("*<>", reg));  // True
            //Console.WriteLine(Regex.IsMatch("!@#$", reg));  // True

            //var reg = @"\s"; // 表示任意一个空白符(空格)
            //Console.WriteLine(Regex.IsMatch("abc", reg)); // False
            //Console.WriteLine(Regex.IsMatch("a bc", reg)); // True
            //Console.WriteLine(Regex.IsMatch(" ", reg)); // True
            //Console.WriteLine(Regex.IsMatch("123-ABC", reg)); // False

            //var reg = @"\S"; // 表示任意一个非空白符(空格)
            //Console.WriteLine(Regex.IsMatch("abc", reg)); // True
            //Console.WriteLine(Regex.IsMatch("a bc", reg)); // True
            //Console.WriteLine(Regex.IsMatch(" ", reg)); // False
            //Console.WriteLine(Regex.IsMatch("123-ABC", reg)); // True

            //var reg = @"[abc]"; // 表示abc中的任意一个字符
            //Console.WriteLine(Regex.IsMatch("abc", reg)); // True
            //Console.WriteLine(Regex.IsMatch("a bc", reg)); // True
            //Console.WriteLine(Regex.IsMatch("c", reg)); // True
            //Console.WriteLine(Regex.IsMatch("C", reg)); // False
            //Console.WriteLine(Regex.IsMatch("123-ABC", reg)); // True

            //var reg = @"[a-z]"; // 表示任意一个小写字母
            //Console.WriteLine(Regex.IsMatch("abc", reg)); // True
            //Console.WriteLine(Regex.IsMatch("a bc", reg)); // True
            //Console.WriteLine(Regex.IsMatch("c", reg)); // True
            //Console.WriteLine(Regex.IsMatch("C", reg)); // False
            //Console.WriteLine(Regex.IsMatch("123-ABC", reg)); // False

            // @"[0-9]"  表示任意一个数字
            // @"[A-Z]"  表示任意一个大写字母
            // @"[A-Za-z]"  表示任意一个字母

            //var reg = @"[^abc]"; // 表示任意一个除了abc的字符
            //Console.WriteLine(Regex.IsMatch("abc", reg)); // False
            //Console.WriteLine(Regex.IsMatch("a bc", reg)); // True/
            //Console.WriteLine(Regex.IsMatch("c", reg)); // False
            //Console.WriteLine(Regex.IsMatch("C", reg)); // True
            //Console.WriteLine(Regex.IsMatch("123-ABC", reg)); // True

            //量词: 修饰前面的字符要匹配到的数量。
            //var reg = @"a*"; // 表示任意个字符a
            ////Console.WriteLine(Regex.IsMatch("abc", reg)); // True
            ////Console.WriteLine(Regex.IsMatch("a bc", reg)); // True
            ////Console.WriteLine(Regex.IsMatch("c", reg)); // True
            ////Console.WriteLine(Regex.IsMatch("C", reg)); // True
            ////Console.WriteLine(Regex.IsMatch("123-ABC", reg)); // True
            //Console.WriteLine(Regex.Match("abc", reg)); // a
            //Console.WriteLine(Regex.Match("123-ABC", reg)); // 

            //var reg = @"\d+"; // 表示至少1个数字字符
            //Console.WriteLine(Regex.IsMatch("abc", reg)); // False
            //Console.WriteLine(Regex.IsMatch("a2bc", reg)); // True
            //Console.WriteLine(Regex.IsMatch("c", reg)); // False
            //Console.WriteLine(Regex.IsMatch("123", reg)); // True
            //Console.WriteLine(Regex.IsMatch("123-ABC", reg)); // True

            //var reg = @"\d?"; // 表示0个或1个数字字符
            ////Console.WriteLine(Regex.IsMatch("abc", reg)); // True
            ////Console.WriteLine(Regex.IsMatch("a2bc", reg)); // True
            ////Console.WriteLine(Regex.IsMatch("c", reg)); // True
            ////Console.WriteLine(Regex.IsMatch("123", reg)); // True
            ////Console.WriteLine(Regex.IsMatch("123-ABC", reg)); // True
            //Console.WriteLine(Regex.Match("abc", reg)); //
            //Console.WriteLine(Regex.Match("123-ABC", reg)); // 1 

            //var reg = @"\d{3}"; // 表示三个连续的数字字符
            ////Console.WriteLine(Regex.IsMatch("abc", reg)); // False
            ////Console.WriteLine(Regex.IsMatch("a2bc", reg)); // False
            ////Console.WriteLine(Regex.IsMatch("c", reg)); // False
            ////Console.WriteLine(Regex.IsMatch("123", reg)); // True
            ////Console.WriteLine(Regex.IsMatch("123-ABC", reg)); // True
            ////Console.WriteLine(Regex.IsMatch("1c23", reg)); // False
            //Console.WriteLine(Regex.Match("1abc12", reg)); //
            //Console.WriteLine(Regex.Match("123-ABC", reg)); // 123 

            //var reg = @"\d{3,5}"; // 表示3到5个连续的数字字符
            ////Console.WriteLine(Regex.IsMatch("abc", reg)); // False
            ////Console.WriteLine(Regex.IsMatch("a2bc", reg)); // False
            ////Console.WriteLine(Regex.IsMatch("c", reg)); // False
            ////Console.WriteLine(Regex.IsMatch("a123", reg)); // True
            ////Console.WriteLine(Regex.IsMatch("a1123", reg)); // True
            ////Console.WriteLine(Regex.IsMatch("a11235", reg)); // True
            ////Console.WriteLine(Regex.IsMatch("12323-ABC", reg)); // True
            ////Console.WriteLine(Regex.IsMatch("1c2333333", reg)); // True
            //Console.WriteLine(Regex.Match("1abc1222", reg)); // 1222
            //Console.WriteLine(Regex.Match("123-ABC", reg)); // 123 

            //var reg = @"\d{3,}"; // 表示3到无数个连续的数字字符
            //Console.WriteLine(Regex.IsMatch("abc", reg)); // False
            //Console.WriteLine(Regex.IsMatch("a2bc", reg)); // False
            //Console.WriteLine(Regex.IsMatch("c", reg)); // False
            //Console.WriteLine(Regex.IsMatch("a123", reg)); // True
            //Console.WriteLine(Regex.IsMatch("a1123", reg)); // True
            //Console.WriteLine(Regex.IsMatch("a11235", reg)); // True
            //Console.WriteLine(Regex.IsMatch("12323-ABC", reg)); // True
            //Console.WriteLine(Regex.IsMatch("1c2333333", reg)); // True
            //Console.WriteLine(Regex.Match("1abc1222111111", reg)); // 1222111111
            //Console.WriteLine(Regex.Match("123-ABC", reg)); // 123 

            // 其他符号
            //// ^ 表示以什么内容开头  必须书写在最开头
            //var reg = @"^\d{3}"; // 表示必须以3到个连续的数字字符开头
            //Console.WriteLine(Regex.IsMatch("12abc", reg)); // False
            //Console.WriteLine(Regex.IsMatch("123abc", reg)); // True
            //Console.WriteLine(Regex.IsMatch("111abc", reg)); // True
            //Console.WriteLine(Regex.IsMatch("123456abc", reg)); // True
            //Console.WriteLine(Regex.IsMatch("1a23111", reg)); // False
            //Console.WriteLine(Regex.IsMatch("12z33333", reg)); // False

            //// $ 表示以什么内容结尾  必须书写在最后
            //var reg = @"\d{3}$"; // 表示必须以3到个连续的数字字符结尾
            //Console.WriteLine(Regex.IsMatch("12abc", reg)); // False
            //Console.WriteLine(Regex.IsMatch("123abc", reg)); // False
            //Console.WriteLine(Regex.IsMatch("111abc11", reg)); // False
            //Console.WriteLine(Regex.IsMatch("123456abc123", reg)); // True
            //Console.WriteLine(Regex.IsMatch("1a23111", reg)); // True
            //Console.WriteLine(Regex.IsMatch("12z33333", reg)); // True


            //// 以匹配到的这三个数字开头, 并以匹配到的这三个数字结尾
            //var reg = @"^\d{3}$"; // 表示必须  3个连续的数字字符
            //Console.WriteLine(Regex.IsMatch("12abc", reg)); // False
            //Console.WriteLine(Regex.IsMatch("123abc", reg)); // False
            //Console.WriteLine(Regex.IsMatch("111", reg)); // True
            //Console.WriteLine(Regex.IsMatch("123", reg)); // True
            //Console.WriteLine(Regex.IsMatch("123a123", reg)); // False
            //Console.WriteLine(Regex.IsMatch("123123", reg)); // False
            //Console.WriteLine(Regex.IsMatch("1a23111", reg)); // False
            //Console.WriteLine(Regex.IsMatch("12z33333", reg)); // False


            //var reg = @"a|bc"; // 表示  包含一个a或者bc 
            //Console.WriteLine(Regex.IsMatch("12abc", reg)); // True
            //Console.WriteLine(Regex.IsMatch("123abc", reg)); // True
            //Console.WriteLine(Regex.IsMatch("111", reg)); // False
            //Console.WriteLine(Regex.IsMatch("123", reg)); // False
            //Console.WriteLine(Regex.IsMatch("123a123", reg)); // True
            //Console.WriteLine(Regex.IsMatch("123123", reg)); // False
            //Console.WriteLine(Regex.IsMatch("1a23111", reg)); // True
            //Console.WriteLine(Regex.IsMatch("12z33333", reg)); // False


            //var reg = @"[\u4e00-\u9fa5]"; // 表示  包含一个汉字
            //Console.WriteLine(Regex.IsMatch("12abc", reg)); // False
            //Console.WriteLine(Regex.IsMatch("hello", reg)); // False
            //Console.WriteLine(Regex.IsMatch("hel你好lo", reg)); // True
            //Console.WriteLine(Regex.IsMatch("hel你lo", reg)); // True


            //var reg = @"\."; // 表示  包含字符.
            //Console.WriteLine(Regex.IsMatch("12abc", reg)); // False
            //Console.WriteLine(Regex.IsMatch("he.llo", reg)); // True
            //Console.WriteLine(Regex.IsMatch("hel你好lo", reg)); // False
            //Console.WriteLine(Regex.IsMatch("hel.你lo", reg)); // True

            //多次提取
            //string reg = @"a|b";
            //MatchCollection res = Regex.Matches("abc", reg);
            //Console.WriteLine(res[0]);
            //Console.WriteLine(res[1]);

            //分组
            //用小括号表示一组
            //string reg = @"(\d{4})-(\d{2})-(\d{2})";
            //Match res = Regex.Match("2026-07-22", reg);
            // 正则中的() 是一个个单独的整体,除了整个正则表达式会匹配之外, 每个小括号也会单独匹配
            // 这些小括号单独匹配的内容 在整体匹配结果的分组中
            //Console.WriteLine(res.Value); // 2026-07-22
            //Console.WriteLine(res.Groups[0]); // 2026-07-22
            //Console.WriteLine(res.Groups[1]); // 2026  // 第一个小括号匹配的结果
            //Console.WriteLine(res.Groups[2]); // 07
            //Console.WriteLine(res.Groups[3]); // 22
            //Console.WriteLine(res.Groups.Count); // 4

            // () 也可以表示一个小的单独整体
            //var reg = @"^a|b$";
            //Console.WriteLine(Regex.IsMatch("a",reg)); // True
            //Console.WriteLine(Regex.IsMatch("b",reg)); // True
            //Console.WriteLine(Regex.IsMatch("accc",reg)); // True
            //Console.WriteLine(Regex.IsMatch("cccb", reg)); // True


            //var reg = @"^(a|b)$";
            //Console.WriteLine(Regex.IsMatch("a", reg)); // True
            //Console.WriteLine(Regex.IsMatch("b", reg)); // True
            //Console.WriteLine(Regex.IsMatch("accc", reg)); // False
            //Console.WriteLine(Regex.IsMatch("cccb", reg)); // False

            //?:放在小括号中，表示不产生分组，只用于匹配使用。
            //例子：
            //string reg = @"(?:\d{4})-(?:\d{2})-(?:\d{2})";
            //Match res = Regex.Match("2026-07-22", reg);
            //Console.WriteLine(res.Value); // 2026-07-22
            //Console.WriteLine(res.Groups[0]); // 2026-07-22
            //Console.WriteLine(res.Groups[1]); // 
            //Console.WriteLine(res.Groups.Count); // 1

            // 案例：

            //-手机号
            //- qq号
            //- 邮箱号
            //- 提取一句话中的所有工资
            //-手机号 // 假设第二位不能是0
            //var reg1 = @"^1[1-9]\d{9}$";
            ////- qq号
            //var reg2 = @"[1-9]\d{4,8}";
            ////- QQ邮箱号
            //var reg3 = @"[1-9]\d{4,8}@qq\.com";
            ////- 提取一句话中的所有工资
            //var str = "你的工资是: 10000 我的工资是:3000,小明的工资是: 20000";
            //var reg4 = @"[1-9]\d{3,}";
            //var res = Regex.Matches(str, reg4);
            //foreach (var item in res) Console.WriteLine(item);




        }
    }
}
