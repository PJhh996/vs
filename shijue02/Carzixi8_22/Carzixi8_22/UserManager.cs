using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Carzixi8_22
{
    internal class UserManager
    {
        #region 属性赋值器
        private string Path { get; } = "./user.json";
        private JsonSerializerOptions Options { get;  } = new JsonSerializerOptions { 
        
            WriteIndented = true,
            AllowTrailingCommas = true,
            Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping

        };
        #endregion

        #region 新增客户方法
        public string UserAdd(string usernane,string idcard,string gender,string phoneno,string motto) 
        {
            //新建一个空list 为后续数据存放做准备 数据类型为UserManager里面的User对象
            List<User> userList = new List<User>();
            //判断文件是否存在
            if (File.Exists(Path))
            { 
                //文件存在，我们读取文件，然后反序列化
                string jsonStr = File.ReadAllText(this.Path);
                userList = JsonSerializer.Deserialize<List<User>>(jsonStr);
                if (userList.Exists(item => item.IdCard == idcard)) return "该客户以存在，请勿重复添加！！！\n";
            }
            //不管存不存在都要做一下造作
            //利用参数，实例化对象
            int id = userList.Count == 0 ? 1 : userList[userList.Count - 1].Id + 1;
            string regTime = DateTime.Now.ToString();
            User userItem = new(id,usernane,idcard, regTime,gender, phoneno, motto);
            //添加进userList中  进行序列化  写入文件
            userList.Add(userItem);
            string resStr = JsonSerializer.Serialize(userList,this.Options);
            File.WriteAllText(this.Path,resStr);

            return "恭喜成为新客户！！！\n";
        }
        #endregion

        #region 查看所有客户方法
        public void UserAll()
        {
            //新建list 接收读取文件拿到的数据
            List<User> userAllList = new ();
            //判断文件是否存在
            if (File.Exists(Path))
            {
                //文件存在 则读取文件  反序列化  
                string jsonStr = File.ReadAllText(Path);
                userAllList = JsonSerializer.Deserialize<List<User>>(jsonStr);

            }
            //判断list长度  为零则没有客户
            if (userAllList.Count == 0)
            {
                Console.WriteLine("暂时没有客户，请先添加！！！\n");
                return;
            }

            //遍历userAllList拿到所有客户信息
            
            foreach (var item in userAllList)
            {
                Console.WriteLine($"客户id:{item.Id} -- 姓名:{item.Name} -- 性别:{item.Gender} -- 手机号:{item.PhoneNo} -- 座右铭:{item.Motto} ");
            }
        }
        #endregion

        #region 查询某个用户方法
        public void UserOne(string idcard)
        {
            //新建list 接收读取文件拿到的数据
            List<User> userOneList = new();
            //判断文件是否存在
            if (File.Exists(Path))
            {
                //文件存在 则读取文件  反序列化  
                string jsonStr = File.ReadAllText(Path);
                userOneList = JsonSerializer.Deserialize<List<User>>(jsonStr);

            }
            //使用list高级方法Find找到对应身份证号 的客户
            User oneItem = userOneList.Find(item => item.IdCard == idcard);
            if (oneItem == null)
            {
                Console.WriteLine("没有找到该客户！！！\n");
                return;
            }
            Console.WriteLine("=======================客户信息=======================");
            Console.WriteLine($"客户id:{oneItem.Id} -- 姓名:{oneItem.Name} -- 性别:{oneItem.Gender} -- 手机号:{oneItem.PhoneNo} -- 座右铭:{oneItem.Motto} ");
            Console.WriteLine("======================================================");

        }
        #endregion

        #region 查询每个客户是否存在方法
        //查询客户是否存在方法
        public bool SearchOneById(int id)
        {
            //判断文件是否存在，不存在则客户不存在
            if (!File.Exists(this.Path)) return false;
            //文件存在  读取文件 反序列化  找到客户
            string jsonSre = File.ReadAllText(this.Path);
            List<User> searchOne = JsonSerializer.Deserialize<List<User>>(jsonSre);
            User OneId = searchOne.Find(item => item.Id == id);
            if(OneId == null) return false;
            return true;


        }
        #endregion

    }
}
