using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carzixi8_22
{

    //车辆类  ===> 车辆数据类型
    //存储车辆信息时的 数据类型
    internal class Car
    {
        public int Id { get; }
        public string Card { get; }
        public string Type { get; set; }
        public bool Status { get; set; }
        public double Price { get; set; }

        //构造函数
        public Car(int Id,string Card,string Type,bool Status,double Price) 
        {
            this.Id = Id;
            this.Card = Card;
            this.Type = Type;
            this.Status = Status;
            this.Price = Price;
        }

    }
    internal class User
    {
        //客户类  ===> 客户数据类型
        //存储客户信息时的 数据类型
        public int Id { get; }
        public string Name { get; }
        public string  IdCard{ get;  }
        public string RegTime { get;  }
        public string Gender { get; set; }
        public string PhoneNo { get; set; }
        public string Motto { get; set; }

        //构造函数
        public User(int Id, string Name, string IdCard, string RegTime, string Gender, string PhoneNo, string Motto)
        {                 
            this.Id = Id;
            this.Name = Name;
            this.IdCard = IdCard;
            this.RegTime = RegTime;
            this.Gender = Gender;
            this.PhoneNo = PhoneNo;
            this.Motto = Motto;
        }
    }

    internal class RentReturn
    {
        //客户类  ===> 客户数据类型
        //存储客户信息时的 数据类型
        public int Id { get; }
        public int CarId { get; }
        public int UserId { get; }
        public string RentTime { get; }
        public string ReturnTime { get; set; }
        public double PayMoney { get; set; }

        //构造函数
        public RentReturn(int Id, int CarId, int UserId, string RentTime, string ReturnTime, double PayMoney)
        {
            this.Id = Id;
            this.CarId = CarId;
            this.UserId = UserId;
            this.RentTime = RentTime;
            this.ReturnTime = ReturnTime;
            this.PayMoney = PayMoney;
        }
    }



}
