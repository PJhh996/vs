using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace kaoshi8_21_3_1
{
    internal class Employee
    {

        static int EmpId ;
        static string EmpName;
        static string Department ;
        static double Salary ;




        public int empId
        {
            get { return EmpId; }
            set { EmpId = value; }
        }
        public string empName
        {
            get { return EmpName; }
            set { EmpName = value; }
        }
        public string department
        {
            get { return Department; }
            set { Department = value; }
        }
        public double salary
        {
            get { return Salary; }
            set { Salary = value; }
        }

        public Employee(int EmpId, string EmpName, string Department, double Salary)
        {
            this.EmpId = EmpId;
            this.EmpName = EmpName;
            this.Department = Department;
            this.Salary = Salary;
        }




    }
}
