using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Carzixi8_22
{
    internal class RentReturnCar
    {

        #region 属性赋值器
        private string Path { get; } = "./RentReturnCar.json";
        private JsonSerializerOptions Options { get; } = new JsonSerializerOptions
        {

            WriteIndented = true,
            AllowTrailingCommas = true,
            Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping

        };
        #endregion

        #region 出租方法
        //出租方法
        public void RentCar(int carId, int userId)
        {
            //判断车辆是否存在，通过车辆id改变车辆状态
            CarManager CM = new CarManager();
            var resRent = CM.RentCar(carId);
            //判断车辆是否存在
            if (!resRent.Item2)
            {
                Console.WriteLine($"{resRent.Item1}");
                return;
            }
            //判断客户是否 存在 实例化UserManager调用SearchOneById方法
            UserManager UM = new UserManager();
            if (!UM.SearchOneById(userId))
            {
                Console.WriteLine("没有找到该客户！！！\n");
                return;
            }
            //租车完成，后续添加租车记录
            //判断文件是否存在 ==> 文件存在则读取文件
            //创建一个新的list接收文件中的数据
            List<RentReturn> rentList = new List<RentReturn>();
            if (File.Exists(this.Path))
            {
                //读取文件
                string jsonStr = File.ReadAllText(this.Path);
                rentList = JsonSerializer.Deserialize<List<RentReturn>>(jsonStr);

            }
            //添加数据到rentList里面
            int id = rentList.Count == 0 ? 1 : rentList[rentList.Count - 1].Id + 1;
            DateTime date = DateTime.Now;
            RentReturn rentCar = new RentReturn(id, userId, carId, date.ToString(), "", 0);
            rentList.Add(rentCar);
            //添加后，写入文件
            string resStr = JsonSerializer.Serialize(rentList,this.Options);
            File.WriteAllText(this.Path,resStr);
            

            Console.WriteLine($"{resRent.Item1}");
        }
        #endregion

        #region 还车方法
        //还车方法
        public void ReturnCar(int id) 
        {
            //判断文件是否存在
            if (!File.Exists(this.Path))
            {
                Console.WriteLine("暂无租车记录！！！\n");
                return;
            }
            //有记录==>读取文件
            string jsonStr = File.ReadAllText(this.Path);
            List<RentReturn> ReturnList = JsonSerializer.Deserialize<List<RentReturn>>(jsonStr);
            RentReturn itemReturn = ReturnList.Find(item => item.Id == id);
            if (itemReturn == null)
            {
                Console.WriteLine("没有找到该租车记录！！！\n");
                return;
            }
            //实例化CarManager，调用GetPriceAndGetStatus方法，取到时租费
            CarManager CM = new CarManager();
            CM.GetPriceAndGetStatus(itemReturn.CarId);
            double payMoney = CM.GetPriceAndGetStatus(itemReturn.CarId);
            //判断itemReturn是否为空
            if (itemReturn == null) 
            {
                Console.WriteLine("没有找到该租车记录！！！\n");
                return;
            }
            if (itemReturn.ReturnTime != "") 
            {
                Console.WriteLine("车辆已归还！！！\n");
                return ;
            }
            itemReturn.ReturnTime = DateTime.Now.ToString();
            //获取时间间隔
            TimeSpan time = DateTime.Now - DateTime.Parse( itemReturn.RentTime);
            itemReturn.PayMoney = (double)time.TotalHours * payMoney;

            //序列化  写入文件
            string resStr = JsonSerializer.Serialize(ReturnList,this.Options);
            File.WriteAllText(this.Path,resStr);
            Console.WriteLine("还车成功！！！\n");

        }
        #endregion

        #region 查看租车记录方法
        //查看租车记录方法
        public void Look()
        {
            //判断文件是否存在
            if (!File.Exists(this.Path))
            {
                Console.WriteLine("暂时没有租车记录！！！\n");
                return;
            }
            //文件存在  读取文件  反序列化
            string jsonStr = File.ReadAllText(this.Path);
            List<RentReturn> carList = JsonSerializer.Deserialize<List<RentReturn>>(jsonStr);
            foreach (RentReturn i in carList)
            {
                Console.WriteLine($"租车id{i.Id} -- 车辆id{i.CarId} -- 客户id{i.UserId} -- 租车时间{i.RentTime} -- 还车时间{i.ReturnTime} -- 费用{i.PayMoney:F2}");
            }

        }

        #endregion

    }
}
