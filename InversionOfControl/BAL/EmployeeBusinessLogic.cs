using InversionOfControl.DAL;
using InversionOfControl.DOL;
using InversionOfControl.Factory;
using InversionOfControl.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InversionOfControl.BAL
{
    internal class EmployeeBusinessLogic
    {
        IEmployeeDataAccess employeeDataAccess;


        public EmployeeBusinessLogic(IEmployeeDataAccess objDataAccess)
        {
            employeeDataAccess = objDataAccess;
        }


       public Employee GetEmployeeDetails(int id)
        {
            return employeeDataAccess.GetEmployeeDetails(id);   
        }
    }
}
