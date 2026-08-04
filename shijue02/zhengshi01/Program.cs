namespace zhengshi01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            ////在程序中数据是由类型的
            //Console.WriteLine(123);
            //Console.WriteLine("abc");
            //c#中简单的数据类型：int(整形)，double(浮点型)，string(字符串类型)，bool(布尔型)
            //int n = 10;
            //int res = n++ + ++n + n++ + ++n;//10 + 12 + 12 + 14 
            //Console.WriteLine($"res:{res}");
            //Console.WriteLine($"n:{n}");


            //---------------第一题--------------------
            //int n, m;
            //Console.WriteLine("请输入第一个整数：");
            //n = int.Parse(Console.ReadLine());

            //Console.WriteLine("请输入第二个整数：");
            //m = int.Parse(Console.ReadLine());

            //int x = n + m;
            //Console.WriteLine($"和为：{x}");
            //---------------------------------------------
            //---------------------第二题------------------
            //double a, b;
            //Console.WriteLine("请输入华氏温度：");
            //a = double.Parse(Console.ReadLine());
            //b = (a - 32) * 5 / 9;
            //Console.WriteLine($"华氏温度：{a:F3}°,摄氏度：{b:F3}°");
            //---------------------------------------------
            //---------------------第三题------------------
            //int a, b, c;
            //Console.WriteLine("请输入a：");
            //a = int.Parse(Console.ReadLine());
            //Console.WriteLine("请输入b：");
            //b = int.Parse(Console.ReadLine());

            //c = a;
            //a = b;
            //b = c;

            //Console.WriteLine($"交换后a={a},b={b}");
            //---------------------------------------------
            //---------------------第四题------------------
            //int a = 89;
            //int b = 89 / 24;
            //int c = 89 % 24;
            //Console.WriteLine($"{b}天零{c}小时");
            //---------------------------------------------

            //List<string> ars = new List<string>() {"A","B","C","D" };

            //ars.Add("Z");
            //Console.WriteLine(ars.Count);
            //ars.Insert(2,"X");
            //ars.AddRange(["Q","W","E"]);
            //Console.WriteLine(ars.Count);
            //Console.WriteLine(ars[0]);
            //Console.WriteLine(ars[1]);
            //Console.WriteLine(ars[2]);
            //Console.WriteLine(ars[3]);
            //Console.WriteLine(ars[4]);
            //Console.WriteLine(ars[5]);
            //Console.WriteLine(ars[6]);
            //Console.WriteLine(ars[7]);
            //Console.WriteLine(ars[8]);

            //List<string> sArr2 = new List<string>() { "a","b","c"};
            //Console.WriteLine(sArr2.Contains("b"));
            //Console.WriteLine(sArr2.Contains("f"));


            List<string> names = new List<string>() { "张三","李四","王五","赵六"
            
            
            };

            Random r = new Random();
            int index = r.Next(names.Count);

            string randomName = names[index];
            Console.WriteLine($"被点到的人：{randomName}");
            

            //int n = r.Next(4);
            //Console.WriteLine($"被点到的人：{names[n]}");
        }
    }
}
