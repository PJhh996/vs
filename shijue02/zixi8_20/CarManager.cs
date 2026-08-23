using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace zixi8_20
{
    internal class CarManager
    {

        #region 属性赋值器
        private string Path { get; } = "./car.json";// 属性的赋值器 ===> 直接给属性初始值
        private JsonSerializerOptions jsonOpt { get; } = new JsonSerializerOptions
        {
            WriteIndented = true,
            AllowTrailingCommas = true,
            //下面这个是为了让json序列化时中文不改变
            Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping
        };
        #endregion

        #region 新增车辆方法
        //新增车辆 方法
        public string CarAdd(string card,string type,string price)
        {
            //定义一个新list
            List<Car> carList = new();
            //判断文件是否存在 ===> 存在就读取文件，反序列化
            if (File.Exists(Path))
            {
                string jsonStr = File.ReadAllText(this.Path);
                carList = JsonSerializer.Deserialize<List<Car>>(jsonStr);
                    if (carList.Exists(item => item.Card == card)) return "添加失败，该车牌已存在！！！\n";
            }
            //接收数据组成的Car 实例对象 ===> 添加进carList
            Car cAdd = new Car(carList.Count+1,card,type,true,double.Parse(price));
            carList.Add(cAdd);
            //序列化写入json文件
            string resStr = JsonSerializer.Serialize(carList,this.jsonOpt);
            File.WriteAllText(this.Path, resStr);
            return "新增成功！！！\n";

        }
        #endregion

        #region 查询所有车辆信息方法
        //查询所有车辆信息 方法
        public void SearchAll()
        {
            //判断文件是否存在 ==> 不存在 ==> 没有车辆信息
            if (!File.Exists(Path))
            {
                Console.WriteLine("暂时没有车辆信息，请先添加！！！\n");
                return;
            }
            //存在  则读取文件
            string jsonStr = File.ReadAllText(Path);
            //创建list接收反序列化的 文件内容
            List<Car> carList = JsonSerializer.Deserialize<List<Car>>(jsonStr);
            //遍历输出list里的数据
            foreach (Car item in carList)
            {
                string statusStr = item.Status ? "空闲中" : "出租中";
                Console.WriteLine($"id：{item.Id} -- 车牌：{item.Card} -- 类型：{item.Type} -- 状态：{statusStr} -- 时租费：{item.Price}\n");
            }

        }
        #endregion

        #region 根据Id查看一辆车的信息方法
        //查单独一辆车信息 方法
        public void SearchOne(int Id)
        {

            //判断文件是否存在 ==> 不存在 ==> 没有车辆信息
            if (!File.Exists(Path))
            {
                Console.WriteLine("暂时没有车辆信息，请先添加！！！\n");
                return;
            }
            //存在  则读取文件
            string jsonStr = File.ReadAllText(Path);
            //创建list接收反序列化的 文件内容
            List<Car> carList = JsonSerializer.Deserialize<List<Car>>(jsonStr);
            //将对应id的车辆信息存进 carCar中
            Car carCar = carList.Find(item => item.Id == Id);
            //判断carCar是否为空  为空则没找到    不为空则继续
            if (carCar == null)
            {
                Console.WriteLine("没有找到对应ID的车辆！！！\n");
                return;
            }

            string isFree = carCar.Status ? "空闲中" : "出租中";
            Console.WriteLine($"id：{carCar.Id} -- 车牌：{carCar.Card} -- 类型：{carCar.Type} -- 状态：{isFree} -- 时租费：{carCar.Price}\n");



        }
        #endregion

        #region 查询所有空闲车辆方法
        //查询所有空闲车辆 方法
        public void SearchFree()
        {
            //判断文件是否存在 ==> 不存在 ==> 没有车辆信息
            if (!File.Exists(Path))
            {
                Console.WriteLine("暂时没有车辆信息，请先添加！！！\n");
                return;
            }
            //存在  则读取文件
            string jsonStr = File.ReadAllText(Path);
            //创建list接收反序列化的 文件内容
            List<Car> carList = JsonSerializer.Deserialize<List<Car>>(jsonStr);
            //通过list高级方法 FindAll 找出所有空闲车辆
            List<Car> freeCar = carList.FindAll(item => item.Status);
            //判断carCar是否为空  为空则没找到    不为空则继续
            if (freeCar == null)
            {
                Console.WriteLine("没有空闲的车辆！！！\n");
                return;
            }
            foreach (Car car in freeCar)
            {
                Console.WriteLine($"id：{car.Id} -- 车牌：{car.Card} -- 类型：{car.Type} -- 时租费：{car.Price}\n");
            }
        }
        #endregion

        #region 通过id来改变车辆状态 实现租车方法
        public (string ,bool) RentCar(int carId)
        {
            //判断文件是否 存在
            if (!File.Exists(this.Path)) return ("没有找到该车辆！！！\n", false);
            
            //有文件，读取文件，反序列化
            string jsonStr = File.ReadAllText(this.Path);
            List<Car> carList = JsonSerializer.Deserialize<List<Car>>(jsonStr);
            //找到对应车辆，改变车辆的状态
            Car oneCar = carList.Find(item => item.Id == carId);
            //如果oneCar数据为null那么 找不到该车辆
            if (oneCar == null) return ("没有找到该车辆！！！\n", false);
            if (oneCar.Status == false) return ("该车已出租！！！\n", false);
            //判断车辆状态为true后  改变车辆状态，实现租车 然后序列化重新写入文件
            oneCar.Status = false;

            string res = JsonSerializer.Serialize(carList, this.jsonOpt);
            File.WriteAllText(this.Path, res);
            return ("租车成功！！！\n",true);
       
        }

        #endregion

        #region 获取时租费方法
        // 修改状态并获取 时租费
        public double GetPriceAndGetStatus(int id)
        {
            // 读取文件，反序列化，根据id查找，修改状态 并获取数据返回
            string jsonStr = File.ReadAllText(this.Path);
            List<Car> carList = JsonSerializer.Deserialize<List<Car>>(jsonStr);

            Car carObj = carList.Find(item => item.Id == id);

            // 修改车辆状态
            carObj.Status = true;
            // 将修改后的 cars列表 序列化 写回文件
            string resStr = JsonSerializer.Serialize(carList, this.jsonOpt);
            File.WriteAllText(this.Path, resStr);

            return carObj.Price;
        }
        #endregion

    }
}
