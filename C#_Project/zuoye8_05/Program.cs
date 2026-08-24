using System.Reflection.Metadata;
using System.Security;

namespace zuoye8_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*************************************************************************/
            //账号密码验证（练习分支嵌套）：账号规定是"admin"，密码规定是"123456"。
            //让用户输入账号和密码，判断账号和密码是否正确，账号和密码都正确就输出登入成功；
            //账号不对，就输出账号不存在；密码不对，就输出密码错误。

            //Console.WriteLine("请输入账号：");
            //string user = Console.ReadLine();

            //if (user == "admin")
            //{
            //    Console.WriteLine("请输入密码：");
            //    int mima = int.Parse(Console.ReadLine());
            //    if (mima == 123456)
            //    {
            //        Console.WriteLine("登录成功");
            //    }
            //    else
            //    {
            //        Console.WriteLine("密码错误");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("账号不存在");
            //}

            /*************************************************************************/
            //选择菜单（add/edit/del）执行操作（练习多分支和switch）：
            //提示用户选择菜单（add/edit/del），判断输入的是add，就输出新增成功；
            //输入的是edit，就输出编辑成功；输入的是del，就输出删除成功。

            //Console.WriteLine("请选择菜单（add/edit/del）");
            //string aa = Console.ReadLine();
            //switch (aa)
            //{
            //    case "add": Console.WriteLine("新增成功");break;
            //    case "edit": Console.WriteLine("编辑成功"); break;
            //    case "del": Console.WriteLine("删除成功"); break;
            //        default: Console.WriteLine("请输入正确指令");break;
            //}

            /*************************************************************************/
            //会员打折满1000打9折，普通用户满2000打9.5折（练习多分支和分支嵌套）：
            //让用户输入自己的类型（VIP/USER）和消费金额，如果是VIP，
            //判断消费金额是否达到1000，如果达到了，就输出他应该支付的金额，如果没有达到，也输出他应该支付的金额；
            //如果是USER，判断消费金额是否达到2000，如果达到了和没有达到，都输出他应该支付的金额。

            //Console.WriteLine("请输入客户身份（VIP/USER）：");
            //String user = Console.ReadLine();           
            //if (user == "VIP" || user == "vip")
            //{
            //    Console.WriteLine("请输入金额：");
            //    double qian = double.Parse(Console.ReadLine());
            //    if (qian >= 1000)
            //    {
            //        Console.WriteLine($"实际金额：{(qian * 0.9):F2}");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"实际金额:{qian}");
            //    }
            //}
            //else if (user == "USER" || user == "user")
            //{
            //    Console.WriteLine("请输入金额：");
            //    double qian = double.Parse(Console.ReadLine());
            //    if (qian >= 2000)
            //    {
            //        Console.WriteLine($"实际金额：{(qian * 0.95):F2}");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"实际金额：{qian}");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("请输入客户身份（VIP/USER）：");
            //}

            /*************************************************************************/
            //通过月份判断季节（练习switch的穿透写法）：
            //用户输入月份，判断月份如果是3、4、5月份，就输出这是春季；
            //如果是6、7、8月份，就输出这是夏季；如果是9、10、11月份，就输出这是秋季，
            //如果是12、1、2月份，就输出这是冬季。

            //Console.WriteLine( "请输入月份（1~12）：" );
            //int yue = int.Parse(Console.ReadLine());
            //switch (yue)
            //{
            //    case 1:
            //    case 2:
            //    case 12: Console.WriteLine($"{yue}-冬季"); break;
            //    case 3:
            //    case 4:
            //    case 5: Console.WriteLine($"{yue}-春季"); break;
            //    case 6:
            //    case 7:
            //    case 8: Console.WriteLine($"{yue}-夏季"); break;
            //    case 9:
            //    case 10:
            //    case 11: Console.WriteLine($"{yue}-秋季"); break;
            //        default: Console.WriteLine("出错"); break;
            //}

            /*************************************************************************/
            //快递运费（练习多分支）：输入快递重量，单位是Kg，如果重量小于1Kg，输出快递费10元；
            //如果重量在1Kg~5Kg之间，就输出快递费20元；如果重量超过5Kg，就输出快递费50元。

            //Console.WriteLine("请输入快递重量（kg）：");
            //double kd = double .Parse(Console.ReadLine());
            //if (kd < 1)
            //{
            //    Console.WriteLine("快递费：10元");
            //}
            //else if (kd < 5 && kd >= 1)
            //{
            //    Console.WriteLine("快递费：20元");
            //}
            //else if (kd >= 5)
            //{
            //    Console.WriteLine("快递费：50元");
            //}
            //else 
            //{
            //    Console.WriteLine("请重新输入（kg）：");
            //}

            /*************************************************************************/
            //会员等级优惠（练习多分支和switch）：输入会员等级，等级是3~5的整数，判断等级如果是5，输出终身免运费；
            //等级是4，输出每月可领优惠券；等级是3，输出购物打9折，否则没有福利。

            //Console.WriteLine("是否是会员（y/n）:");
            //string user = Console.ReadLine();
            //if (user == "Y" || user == "y")
            //{
            //    Console.WriteLine("请输入会员等级（3~5）：");
            //    int i = int.Parse(Console.ReadLine()); 
            //    switch (i)
            //    {
            //        case 3: Console.WriteLine("购物打9折"); break;
            //        case 4: Console.WriteLine("每月可领优惠券"); break;
            //        case 5: Console.WriteLine("终身免运费"); break;
            //        default: Console.WriteLine("请输入正确等级："); break;
            //    }   
            //}
            //else if (user == "n" || user == "N")
            //{
            //    Console.WriteLine("无福利");
            //}
            //else
            //{
            //    Console.WriteLine("请重新确认身份：");
            //}

            /*************************************************************************/
            //自动售货机选商品（练习多分支和switch）：
            //输入商品编号整数，1就输出已购买可乐；2输出已购买雪碧；
            //3输出已购买矿泉水；否则输出无此商品。

            //Console.WriteLine("请输入商品编号（1/2/3）：");
            //int haha = int .Parse(Console.ReadLine());
            //string res = haha switch
            //{
            //    1 => "已购买可乐",
            //    2 => "已购买雪碧",
            //    3 => "已购买矿泉水",
            //    _ => "无此商品"
            //};
            //Console.WriteLine(res);

            /*************************************************************************/
            //速度分级（练习多分支）：输入当前速度，如果在0~30，输出低速通过；
            //30~60输出中速通过；60~100输出高速通过；100~120输出超速通过。

            //Console.WriteLine("请输入速度：");
            //int su = int.Parse(Console.ReadLine());
            //if (su > 0 && su <= 30)
            //{
            //    Console.WriteLine("低速通过");
            //}
            //else if (su > 30 && su <= 60)
            //{
            //    Console.WriteLine("中速通过");
            //}
            //else if (su > 60 && su <= 100)
            //{
            //    Console.WriteLine("高速通过");
            //}
            //else if (su > 100 && su <= 120)
            //{
            //    Console.WriteLine("超速通过");
            //}
            //else
            //{
            //    Console.WriteLine("不是哥们你飞机啊");
            //}

        }
    }
}
