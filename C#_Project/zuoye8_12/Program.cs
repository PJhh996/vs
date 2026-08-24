namespace zuoye8_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //作业一
            //装修房间：参数1，圆的半径，计算圆的面积，每平方米收费200元，
            //返回装修总价。计算这个半径的圆装修一半需要多少钱？
            //var zhuangxiu = (double r) =>
            //{
            //    double money = Math.PI * r * r * 200;
            //    return money;
            //};
            //double res = zhuangxiu(5);
            //Console.WriteLine($"{res:f2}");
            //Console.WriteLine($"装修一半的价格是{res / 2:f2}");

            //作业二
            //计算字符在字符串中出现的次数：参数1字符串，参数2某个字符，函数统计次数，并返回
            //var strings = (string n, char m) => 
            //{ 
            //    if (!n.Contains(m)) return 0; 
            //    char[] str =  n.ToArray();
            //    int count = 1;
            //    for(int i = 0; i < n.Length;i++)
            //    {
            //        if (str[i] == m)
            //        {
            //            for (int j = i + 1; j < n.Length; j++)
            //            {
            //                if (str[i] == str[j]) count++;
            //            }
            //            break;
            //        }
            //    }                
            //    return count;
            //};
            //int res = strings("bababaddaab", 'a');
            //Console.WriteLine(res);

            //作业三
            //计算一个整型数组中，最小值第一次出现的下标。
            //方法一
            //int[] arr = [10, 20, 5, 5, 50, 1, 7];
            //Func<int[] ,int> getFirstMinIndex = (int[] nums) =>
            //{
            //    if (nums == null || nums.Length == 0)
            //    {
            //        return -1;
            //    }
            //    int min = nums[0];
            //    for (int i = 1; i < nums.Length; i++)
            //    {
            //        if (nums[i] < min)
            //        {
            //            min = nums[i];
            //        }
            //    }
            //    for (int j = 0; j < nums.Length; j++)
            //    {
            //        if (nums[j] == min)
            //        { 
            //            int index = j;
            //            return index;
            //        }
            //    }
            //    return -1;
            //};
            //int res = getFirstMinIndex(arr);
            //Console.WriteLine(res);

            //方法二
            //int[] arr = [10, 20, 5, 5, 50, 6, 7];
            //Func<int[], int> getFirstMinindex = (int[] nums) =>
            //{
            //    if(nums == null || nums.Length == 0) return 0;
            //    int minIndex = 0;
            //    for (int i = 1; i < nums.Length; i++)
            //    {
            //        if (nums[i] < nums[minIndex])
            //        { 
            //            minIndex = i;
            //        }
            //    }return minIndex;
            //};
            //int res = getFirstMinindex(arr);
            //Console.WriteLine(res);


            //作业四
            //判断一个字符串是否为回文，返回布尔值类型。
            string str = "bbcbbcbb";//aaa接收str
            var strings = (string aaa) =>
            {
                char[] bbb = aaa.ToArray();
                //if (bbb == bbb.Reverse().ToArray())
                //{
                //    return true;
                //}return false;
                int count = 0;
                for (int i = 0; i < bbb.Length; i++)
                {
                    if (bbb[i] == bbb.Reverse().ToArray()[i])
                    {
                        count++;
                    }
                    if (count == bbb.Length)
                    {
                        return true;
                    }
                }
                return false;
            };
            bool res = strings(str);
            Console.WriteLine(res);




        }
    }
}
