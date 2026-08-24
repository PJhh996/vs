using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;



/*
新要求：
1. 将阶段考试项目代码自己写一遍
2. 将其中重复的代码 封装
3. 添加校验
    - id： int  
    - 薪资： double
*/
namespace kaoshi8_21_3_1
{
    internal class Employee
    {

        private string EmpId;
        private string EmpName;
        private string Department;
        private string Salary;

        public string _EmpId
        {
            get { return EmpId; }
            set { this.EmpId = value; }
        }
        public string _EmpName
        {
            get { return EmpName; }
            set { this.EmpName = value; }
        }
        public string _Department
        {
            get { return Department; }
            set { this.Department = value; }
        }
        public string _Salary
        {
            get { return Salary; }
            set { this.Salary = value; }
        }

        public Employee(string _EmpId, string _EmpName, string _Department, string _Salary)
        {
            this._EmpId = _EmpId;
            this._EmpName = _EmpName;
            this._Department = _Department;
            this._Salary = _Salary;
        }

        public Employee()
        {

        }

        public void ShowEmpInfo()
        {
            Console.WriteLine($"员工编号：{this._EmpId} -- 姓名：{this._EmpName} -- 部门：{this._Department} -- 薪资：{this._Salary}");
            return;
        }

        //封装重复代码
        public void One(List<Employee> list)
        {
            string res = JsonSerializer.Serialize(list, this.jsonOpt);
            File.WriteAllText(path, res);
        }

        public void isPath()
        {
            if (!File.Exists(this.path))
            {
                Console.WriteLine("暂时没有员工！！！\n");
                return;
            }
        }

        public List<Employee> Read()
        {
            string jsonStr = File.ReadAllText(this.path);
            List<Employee> list = JsonSerializer.Deserialize<List<Employee>>(jsonStr);
            return list;
        }

        private string path { get; } = "./emp.json";
        private JsonSerializerOptions jsonOpt { get; } = new JsonSerializerOptions
        {
            WriteIndented = true,
            AllowTrailingCommas = true,
            //下面这个是为了让json序列化时中文不改变
            Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping
        };

        //新增员工方法
        public void empAdd(string id, string empname, string bumen, string xinzi)
        {
            List<Employee> empList = new List<Employee>();
            //判断是否有文件存在
            if (File.Exists(path)) empList = Read();
            //利用编号判断这名员工是否存在了
            Employee emp = new Employee(id, empname, bumen, xinzi);
            if (empList.Exists(item => item.EmpId == id))
            {
                Console.WriteLine("该员工已存在，请勿重复添加！！！\n");
                return;
            }
            //添加  序列化 写入文件
            empList.Add(emp);
            One(empList);
            Console.WriteLine("新增员工成功！！！\n");

        }

        //查看所有员工方法
        public void chaKan()
        {
            //判断文件是否存在 ==> 不存在 ==> 没有员工信息            
            isPath();
            //存在  则读取文件
            List<Employee> allList = Read();
            //遍历输出list里的数据
            foreach (Employee item in allList)
            {
                item.ShowEmpInfo();
            }

        }


        //根据编号调整薪资（改）
        public void Gai(string empid)
        {
            //判断文件是否存在
            isPath();
            //读取文件
            List<Employee> empList = Read();
            //找到对应编号员工
            Employee emp = empList.Find(item => int.Parse(item.EmpId) == int.Parse(empid));
            if (emp == null)
            {
                Console.WriteLine("没有找到该员工！！！\n");
                return;
            }
            Console.WriteLine("请输入调整的薪资：");
            string empSalary = Console.ReadLine();
            if (!Regex.IsMatch(empSalary, @"^\d+(\.[0-9]+)?$"))
            {
                Console.WriteLine("输入薪资格式有误！！！\n");
                return;
            }
            emp.Salary = empSalary;
            //写入文件
            One(empList);
            Console.WriteLine("调整成功！！！\n");
        }

        //根据编号删除员工（删）
        public void Remove(string id)
        {
            //判断
            isPath();
            //读文件
            List<Employee> empList = Read();

            Employee emp = empList.Find(item => int.Parse(item.EmpId) == int.Parse(id));
            if (emp == null)
            {
                Console.WriteLine("没有找到该员工！！！\n");
                return;
            }
            empList.Remove(emp);
            One(empList);
            Console.WriteLine("删除成功！！！\n");

        }

        //按薪资条件筛选员工
        public void Xinzi(string sl)
        {
            isPath();
            //读
            List<Employee> list = Read();

            List<Employee> empList = list.FindAll(item => double.Parse(item._Salary) > double.Parse(sl));
            if (empList.Count == 0)
            {
                Console.WriteLine("无对应薪资条件的员工\n");
                return;
            }
            foreach (Employee item in empList)
            {
                item.ShowEmpInfo();
            }

        }


    }
}
