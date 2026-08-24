using System.Text.RegularExpressions;

namespace kaoshi8_21_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //定义一个字符窜数组
            string[] str = ["17807879875","   SEVEN   ","HaHa","   00999888777   ","hAhAhA"] ;
            

            for (int i =0;i<=4;i++)
            {
                string aaa = str[i].Trim().ToLower();
                if (Regex.IsMatch(aaa, @"^1[3-57-8]\d{9}$"))
                {
                    Console.WriteLine($"合法手机号:{aaa}");
                }
                else if (Regex.IsMatch(aaa, @"\D"))
                {

                    Console.WriteLine($"普通文本:{aaa}");
                }
                else if(Regex.IsMatch(aaa, @"\d")) { Console.WriteLine($"非法手机号:{aaa}"); }
                
            }   

            


        }
    }
}
