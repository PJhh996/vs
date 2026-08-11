using System.Text.Json;
using System.Text.RegularExpressions;

namespace zixi8_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "清风漫过湖畔，午间薄雾缓缓消散，夜色悄然而至，河水静静流淌，渡船缓缓靠岸，渡口游人往来，相逢知己相交，互换见闻感受，留心世间风情，记录山河晚报。";

            //通过下标获取到情报内容：
            //string salt = "7-16-30-38-49-52-63-70";
            //string[] nums = salt.Split("-");
            //string res = "";
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    int index = int .Parse(nums[i]);
            //    res += text[index];
            //}
            //Console.WriteLine(res);

            //通过情报内容获取到下标：
            //string salt = "午夜渡口交换情报";
            //List<int> nums = [];
            //for (int i = 0; i < salt.Length; i++)
            //{
            //    int index = text.IndexOf(salt[i]);
            //    nums.Add(index);
            //}
            //string res = string.Join("-",nums);
            //Console.WriteLine(res);

            //为了更安全，生成密文的时候可以调整下标：（上一个字符）：
            //string salt = "午夜渡口交换情报";
            //List<int> nums = [];
            //for (int i = 0; i < salt.Length; i++)
            //{
            //    int index = text.IndexOf(salt[i]) - 1;
            //    nums.Add(index);
            //}
            //string res = string.Join("-", nums);
            //Console.WriteLine(res);

            //通过密文获获取情报的时候，需要在原本的下标基础上+1：
            //string salt = "6-15-29-37-48-51-62-69";
            //string[] nums = salt.Split("-");
            //string res = "";
            //for (int i = 0; i < nums.Length; i++)
            //{ 
            //    int index = int .Parse(nums[i]) + 1;
            //    res += text[index];
            //}
            //Console.WriteLine(res);

            //还可以在生成密文的时候，奇数就 - 1，偶数就 + 1：
            //string salt = "午夜渡口交换情报";
            //List<int> nums = [];
            //string res = "";
            //for (int i = 0; i < salt.Length; i++)
            //{
            //    int index = text.IndexOf(salt[i]);
            //    if (index % 2 == 0)
            //    {
            //        index += 1;
            //    }
            //    else
            //    { 
            //        index -= 1;
            //    }
            //    nums.Add(index);
            //}
            //res = string.Join("-", nums);
            //Console.WriteLine(res );

            //此时找到情报的时候，也要判断下标是奇数还是偶数，奇数就-1，偶数就+1：
            //string result = "";
            //string[] nums1 = res.Split("-");
            //for (int i = 0; i < nums1.Length; i++)
            //{
            //    int idx = int.Parse(nums1[i]);
            //    idx += idx % 2 == 0 ? 1 : -1;
            //    result += text[idx];
            //}
            //Console.WriteLine(result);


            /********************************************************************************/

            //int money = 200005;
            //string str = money.ToString();
            //// 0    1    2   3   4  。。。
            //// 零   壹   贰  叁  肆
            //// 对应关系：数字当作下标，从下面的集合中用下标获取汉字
            //// 创建汉字数组
            //string[] arr = ["零", "壹", "贰", "叁", "肆", "伍", "陆", "柒", "捌", "玖"];
            //// 创建单位数组
            //string[] units = ["", "拾", "佰", "仟", "萬", "拾", "佰", "仟", "亿"];
            //string result = "";
            //for (int i = str.Length - 1; i >= 0; i--)
            //{
            //    int arrIdx = int.Parse(str[i].ToString());
            //    int unitIdx = str.Length - 1 - i;
            //    string unit = units[unitIdx];
            //    if (arrIdx != 0)
            //    {
            //        result = arr[arrIdx] + units[unitIdx] + result;
            //    }
            //    else 
            //    {
            //        if (i == str.Length - 5)
            //        {
            //            result = arr[arrIdx] + units[4] + result;
            //        }
            //        else 
            //        {
            //            result = arr[arrIdx] + result;
            //        }
            //    }
            //}
            //result = Regex.Replace(result, @"零+","零");
            //result = Regex.Replace(result, @"零萬", "萬");
            //if (result.EndsWith("零"))
            //{
            //    result = result.Substring(0,result.Length- 1);
            //}
            //Console.WriteLine(result);

            /********************************************************************************/

             // 使用的库

            // 要序列化的List数据
            List<Dictionary<string, dynamic>> singerList = new List<Dictionary<string, dynamic>>
            {
                new Dictionary<string, dynamic>
                {
                    {"singerId", 1001},
                    {"singerName", "周杰伦"},
                    {"genre", "流行"}
                },
                new Dictionary<string, dynamic>
                {
                    {"singerId", 1002},
                    {"singerName", "林俊杰"},
                    {"genre", "华语流行"}
                },
                new Dictionary<string, dynamic>
                {
                    {"singerId", 1003},
                    {"singerName", "邓紫棋"},
                    {"genre", "流行、摇滚"}
                }
            };

            // 配置序列化
            //var options = new JsonSerializerOptions
            //{
            //    WriteIndented = true,// JSON序列化时候美化
            //    AllowTrailingCommas = true, // JSON反序列化时候允许 最后出现逗号
            //};
            //string json = JsonSerializer.Serialize(singerList, options);
            //Console.WriteLine(json);

            //// 反序列化
            //var result1 = JsonSerializer.Deserialize<List<Dictionary<string, dynamic>>>(json);
            //foreach (var item in result1)
            //{
            //    Console.WriteLine(item["singerName"]);
            //}

            // 将unicode编码汉字转成中文汉字
            string source = "\\u6C11\\u8C23\\u6D41\\u884C";
            // 将需要反序列化的数据前面加双引号和大括号
            string json = $"\"{source}\"";
            string result = JsonSerializer.Deserialize<string>(json);
            Console.WriteLine(result); // 民谣流行


        }
    }
}
