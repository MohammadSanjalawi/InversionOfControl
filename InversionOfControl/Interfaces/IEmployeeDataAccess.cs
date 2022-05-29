using InversionOfControl.DOL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InversionOfControl.Interfaces
{
    internal interface IEmployeeDataAccess
    {
        Employee GetEmployeeDetails(int id);
    }
}
