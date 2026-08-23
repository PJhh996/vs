using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace kaoshi8_21_3_1
{
    internal class ShouwEmpinfo
    {
        private string path { get; } = "./emp.json";
        private JsonSerializerOptions jsonOpt { get; } = new JsonSerializerOptions
        {
            WriteIndented = true,
            AllowTrailingCommas = true,
            //下面这个是为了让json序列化时中文不改变
            Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping
        };

        public void empAdd(int id , string empname ,string bumen ,double xinzi)
        {
            List<Employee> empList = new List<Employee>();
            //判断是否有文件存在
            if (File.Exists(path))
            {
                //文件存在   则读取文件   反序列化
                string jsonStr = File.ReadAllText(path);
                empList = JsonSerializer.Deserialize<List<Employee>>(jsonStr);
            }
            //利用编号判断这名员工是否存在了
            //Employee emp = empList.Find(item => item.empId == id);
            Employee emp = new Employee(id,empname,bumen,xinzi);
            if (empList.Exists(item => item.EmpId == id))
            {
                Console.WriteLine("该员工已存在，请勿重复添加！！！");
                return;
            }
            //添加  序列化 写入文件
            empList.Add(emp);
            string res = JsonSerializer.Serialize(empList, jsonOpt);
            File.WriteAllText(path, res);
            Console.WriteLine("新增员工成功！！！");

        }

        public void chaKan()
        {
            //判断文件是否存在 ==> 不存在 ==> 没有员工信息
            if (!File.Exists(path))
            {
                Console.WriteLine("暂时没有员工信息！！！");
                return;
            }
            //存在  则读取文件
            string jjsonStr = File.ReadAllText(path);
            //创建list接收反序列化的 文件内容
            List<Employee> allList = JsonSerializer.Deserialize<List<Employee>>(jjsonStr);
            //遍历输出list里的数据
            foreach (Employee item in allList)
            {
                Console.WriteLine($"员工编号：{item.EmpId} -- 姓名：{item.EmpName} -- 部门：{item.Department} -- 薪资：{item.Salary}");
            }
            //return;
        }

    }
}
