using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EmployeeSys.Models;
namespace EmployeeSys.Services
{
    public class EmployeeService
    {
        private List<Employee> _employees = new();
        public void AddEmployee(Employee emp) => _employees.Add(emp);
        public List<Employee> GetAll() => _employees;
        public bool DeleteEmployee(string id)
        {
            var emp = _employees.FirstOrDefault(e => e.Id == id);
            return emp != null && _employees.Remove(emp);
        }
    }
}
