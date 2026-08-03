namespace xunlian
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //输出
            //语法1：Console.writeLine(内容)  输出时会换行
            //语法2：Console.write(内容)     输出时不会换行
            //快捷键：cw  ======>  Console.WriteLine();
            //Console.WriteLine("hello");
            //Console.WriteLine("world");
            //Console.WriteLine("hello");
            //Console.WriteLine("c#");
            //Console.WriteLine("------------分割线-------------");
            //Console.Write("hello");
            //Console.Write(" world");
            //Console.Write(" hello");
            //Console.WriteLine(" c#");
            //Console.WriteLine("------------分割线-------------");



            ////字符串占位输出，字符串中的{数字} 表示占位，后续，后的内容一次填充
            //Console.WriteLine("今天是第{0}天学习{1}", "1", "c#");


            //int整形
            //double浮点型
            //bool布尔型  两个值true和false，输出时是True和False
            //String字符串型

            //Console.WriteLine("abc");
            //Console.WriteLine(123);
            //Console.WriteLine(1.23);
            //Console.WriteLine("蟾蜍");
            //Console.WriteLine("seven");
            //Console.WriteLine(true);
            //Console.WriteLine(false);


            //变量：程序中存储数据的内容。
            //定义方式： 类型 变量名 ；也可以先定义再赋值  类型 变量名 = 值；

            //注意：1.变量名不能使用关键字
            //      2.=是赋值符号，作用是将右边数据放入左边容器内，执行顺序从左向右
            //程序告诉计算机 需要再内存中开辟一个空间 来存储数据 =====> 定义变量
            //int n;
            //int m = 0;

            //定义好变量后 说明了 变量中可以存储的数据类型，那么该变量就只能存储该类型数据，否则报错
            //变量中存储的数据是可变的
            //int num = 108;
            //Console.WriteLine(num);
            //num = 200;
            //Console.WriteLine(num);

            //输入 程序运行后，让用户可以给程序输入内容
            //String 变量名 = Console.ReadLine();

            //注意：用户输入的数据可以用变量接收，接收到的输入都是字符串。
            //Console.WriteLine("请输入名称：");
            //string userName = Console.ReadLine();
            //Console.WriteLine($"刚才输入的名字是：{userName}");

            //字符串拼接 任意数据和字符串进行加法运算后，都会变成字符串
            // var demo = 4 + "abc"

            //类型转换
            //int.Parse ("123455")

            //String s1 = "abc"


            //Day2
            //var person = new
            //{
            //    name = "张三",
            //    age = 20
            //};
            //Console.WriteLine(person);
            //Random r = new Random();
            //int num = r.Next(9); // 获取0-9的随机整数，不包含9
            //Console.WriteLine(num);
            //double num1 = r.NextDouble(); // 获取随机浮点数,0-1
            //Console.WriteLine(num1);

        }
    }
}
