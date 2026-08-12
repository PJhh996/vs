namespace zixi8_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //用函数封装一个猜数字的小游戏，函数中生成一个随机整数（0 - 100）作为目标数字，
            //不停的让用户输入数字，距离目标数字偏大，就提示用户偏大，
            //距离目标数字偏小就输出偏小，用户有5次输入的机会，5次没有猜对，
            //输出GAME OVER，猜对了就输出WIN！
            //void nums() 
            //{
            //    Random r = new Random();
            //    int numRandom = r.Next(100); // 获取0-100的随机整数，不包含100
            //    int count = 0;
            //    for (int i = 0; i <= 5; i++)
            //    {
            //        Console.WriteLine("请输入数字（整数0~100）：");
            //        int numble = int.Parse(Console.ReadLine());
            //        if (numble > 100 || numble < 0)
            //        {
            //            Console.WriteLine("！！！输入数字不在范围内");
            //            break;
            //        }
            //        if (numble == numRandom)
            //        {
            //            Console.WriteLine("WIN");
            //            break;
            //        }
            //        else
            //        {
            //            if (numble > numRandom) { Console.WriteLine("偏大"); }
            //            else { Console.WriteLine("偏小"); }
            //            count++;
            //        }
            //        if (count == 5) { Console.WriteLine("GAME OVER"); break; }
            //    }
            //}
            //nums();

            /***********************************************************************/

            //装修房间：参数1，圆的半径，计算圆的面积，每平方米收费200元，
            //返回装修总价。计算这个半径的圆装修一半需要多少钱？

            var zhuangxiu = (double r) =>
            {
                double money = Math.PI*r*r* 200;
                return money;
            };
            double res = zhuangxiu(5);
            Console.WriteLine($"{res:F2}");
            Console.WriteLine($"装修一半需要的钱：{res/2:F2}");

            




        }
    }
}
