using System.Text.RegularExpressions;

namespace zuoye8_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //提取一句话中所有的中文姓名
            //string str = "hello, I am 刘德华,your name is 黎明?";
            //// 注意：中间是英文减号 -
            //var reg = @"[\u4e00-\u9fa5]{2,3}";

            //MatchCollection matches = Regex.Matches(str, reg);

            //foreach (Match m in matches)
            //{
            //    Console.WriteLine(m.Value);
            //}

            //替换所有多余空格
            //string str = "abc  dd  ee  ff  gg  HH  h j k";
            //var reg = @" ";
            //string res = Regex.Replace(str,reg,"-");
            //Console.WriteLine(res);

            //身份证号码
            //string str = "我的身份证号是: 360731200111052112,你的身份证是: 42108320041119211X";
            //// 书写正则, 找到字符串中的身份证号及 出生年,月,日
            //string reg = @"\b(\d{6})(\d{4})(\d{2})(\d{2})(\d{3}[\dXx])\b";

            //MatchCollection matches = Regex.Matches(str, reg);
            //foreach (Match m in matches)
            //{
            //    Console.WriteLine($"完整身份证：{m.Groups[0].Value}");
            //    Console.WriteLine($"出生年：{m.Groups[2].Value}");
            //    Console.WriteLine($"出生月：{m.Groups[3].Value}");
            //    Console.WriteLine($"出生日：{m.Groups[4].Value}");
            //    Console.WriteLine("--------");
            //}


            //密码强度检测：强中弱（字母、数字、特殊符号）
            // 请输入密码（字母、数字、特殊符号）
            //密码中可以有数字,字母,特殊符号;长度要求8~15 
            //如果只有一种则 强度为弱
            //如果只有两种则 强度为中
            //如果两种都有则 强度为强
            //验证密码长度是否符合,并输出密码强度
            //Console.WriteLine("请输入密码(字母、数字、特殊符号)");
            //string pwd = Console.ReadLine();
            //if (pwd.Length > 15 || pwd.Length < 8)
            //{
            //    Console.WriteLine("输入密码长度不符合要求");
            //    return;
            //}
            //bool haszimu = Regex.IsMatch(pwd, @"[a-zA-Z]");
            //bool hasshuzi = Regex.IsMatch(pwd, @"[0-9]");
            //bool hasfuhao = Regex.IsMatch(pwd, @"[^a-zA-Z0-9]");

            //int count = 0;
            //if(hasfuhao) count++;
            //if(hasshuzi) count++;
            //if(haszimu) count++;

            //string mimaqiangdu = "";
            //if(count == 1) mimaqiangdu = "密码轻度 ==> 弱";
            //if(count == 2) mimaqiangdu ="密码轻度 ==> 中";
            //if(count == 3) mimaqiangdu = "密码轻度 ==> 强";

            //Console.WriteLine(mimaqiangdu);


        }
    }
}
