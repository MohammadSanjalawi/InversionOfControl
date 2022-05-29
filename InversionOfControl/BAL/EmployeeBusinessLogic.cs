using InversionOfControl.DAL;
using InversionOfControl.DOL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InversionOfControl.BAL
{
    internal class EmployeeBusinessLogic
    {
        EmployeeDataAccess employeeDataAccess;


        public EmployeeBusinessLogic()
        {
            employeeDataAccess = new EmployeeDataAccess();  
        }


       public Employee GetEmployeeDetails(int id)
        {
            return employeeDataAccess.GetEmployeeDetails(id);   
        }
    }
}
