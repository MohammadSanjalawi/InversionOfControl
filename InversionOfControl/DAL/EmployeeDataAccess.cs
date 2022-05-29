using InversionOfControl.DOL;
using InversionOfControl.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InversionOfControl.DAL
{
    internal class EmployeeDataAccess : IEmployeeDataAccess
    {
        public Employee GetEmployeeDetails(int id)
        {
            Employee employee = new Employee()
            {
                ID = id,    
                Name = "Mohammad",
                Department = "IT",
                Salary = 10000
            };

            return employee;
        }
    }
}
