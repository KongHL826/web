using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EmployeeSys.Models;
using EmployeeSys.Services;

namespace EmployeeSys
{
    class Program
    {
        static void Main(string[] args)
        {
            var service = new EmployeeService();
            while (true)
            {
                Console.WriteLine("\n1.查看所有员工 2.添加员工 3.删除员工 4.退出");
                var input = Console.ReadLine();
                if (input == "4") break;
                if (input == "1") service.GetAll().ForEach(e => Console.WriteLine($"{e.Id} {e.Name} {e.Department} {e.Salary}"));
                else if (input == "2")
                {
                    Console.Write("工号:"); var id = Console.ReadLine();
                    Console.Write("姓名:"); var name = Console.ReadLine();
                    Console.Write("部门: "); var dept = Console.ReadLine();
                    Console.Write("薪资:"); var sal = decimal.Parse(Console.ReadLine());
                    service.AddEmployee(new Employee { Id = id, Name = name, Department = dept, Salary = sal });
                }
            }
        }
    }
}