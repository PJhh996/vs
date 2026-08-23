namespace kaoshi8_21_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            int res = 0;
            for (int i = 0; i <= 9; i++)
            {
                
                Random r = new Random();
                arr[i] = r.Next(1,50);
                res += arr[i];
                Console.WriteLine($"元素{i}：{arr[i]}");
            }
            double num = (double)res / 10;
            Console.WriteLine($"总和：{res}");
            Console.WriteLine($"平均值：{num}");


        }
    }
}
