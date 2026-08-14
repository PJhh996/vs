using System.Reflection.Metadata;

namespace zixi8_14
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region io训练
            //书写函数 实现写入日志操作, 日志内容: 输入内容 + 日期
            // 书写函数 实现写入日志操作, 日志内容: 输入内容+日期
            // 日志文件路径:  ./content.log

            // 如果文件不存在则会创建文件  并写入内容
            //var path1 = @"C:\Users\leon\Desktop\10day\04-资料\day10.log";
            //File.WriteAllText(path1,"hello");

            //var date = DateTime.Now;
            //Console.WriteLine(date.ToString());
            //Action rizhi = () =>
            //{
            //    Console.WriteLine("请输入内容：");
            //    string res = Console.ReadLine();
            //    var path = "./content.log";
            //    var date = DateTime.Now;
            //    File.AppendAllText(path, $"{res}--{date}\n ");

            //};
            //rizhi();


            //定义一个函数，一个参数（接收路径），返回值0 表示啥也不是，1是文件，2是文件夹

            //Func<string, int> isFileOrDir = path =>
            //{
            //    if (File.Exists(path)) return 1;
            //    if (Directory.Exists(path)) return 2;
            //    return 0;
            //};
            //string[] resArr = ["啥也不是","是文件","是文件夹"];
            ////int res = isFileOrDir("./");
            //int res = isFileOrDir("./");
            ////Console.WriteLine(resArr[res]);

            //Func<string, List<string>> getFileAndDir = path => 
            //{
            //    List<string> resList = [];
            //    if (isFileOrDir(path) != 2) throw new Exception("传递的参数有误，必须要是目录路径");
            //    string[] files = Directory.GetFiles(path);
            //    resList.AddRange(files);
            //    string[] dics = Directory.GetDirectories(path);
            //    resList.AddRange(dics);
            //    Directory.GetDirectories(path);
            //    resList.AddRange(dics);
            //    return resList;
            //};
            //var res = getFileAndDir("./");
            //foreach (string file in res) 
            //{
            //    Console.WriteLine(file);
            //}
            #endregion


            


        }
    }
}
