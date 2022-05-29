using InversionOfControl.BAL;
using InversionOfControl.DAL;
using InversionOfControl.DOL;

EmployeeBusinessLogic BL = new EmployeeBusinessLogic(new EmployeeDataAccess());
Employee employeeDetails = BL.GetEmployeeDetails(1);
Console.WriteLine();
Console.WriteLine("Employee Details:");
Console.WriteLine("ID : {0}, Name : {1}, Department : {2}, Salary : {3}",
                    employeeDetails.ID, employeeDetails.Name, employeeDetails.Department,
                    employeeDetails.Salary);
Console.ReadKey();