using Enumerations_Practice.enums;
using Enumerations_Practice.models;
using Microsoft.Win32;
namespace Enumerations_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                EmployeeService employees = new EmployeeService();

                EmployeeService InternEmployee = new EmployeeService()
                {
                    Employee_ID = 1,
                    Employee_Name = "Rony Khan",
                    Employee_Type = EmployeeTypes.Intern.ToString(),
                };
                EmployeeService FullTimeEmployee = new EmployeeService()
                {
                    Employee_ID = 2,
                    Employee_Name = "Jony Khan",
                    Employee_Type = EmployeeTypes.FullTime.ToString()
                };
                EmployeeService PartTimeEmployee = new EmployeeService
                {
                    Employee_ID = 3,
                    Employee_Name = "Mirza Karim",
                    Employee_Type = EmployeeTypes.PartTime.ToString()
                };
                EmployeeService PartTimeEmployeeUpdatedToFulltime = new EmployeeService
                {
                    Employee_ID = 3,
                    Employee_Name = "Mirza Karim Kaka",
                    Employee_Type = EmployeeTypes.FullTime.ToString()
                };
                EmployeeService ContractEmployee = new EmployeeService
                {
                    Employee_ID = 4,
                    Employee_Name = "Faraz Karim",
                    Employee_Type = EmployeeTypes.Contract.ToString()
                };

                employees.CreateEmployee(FullTimeEmployee);
                employees.CreateEmployee(PartTimeEmployee);
                employees.CreateEmployee(InternEmployee);
                employees.CreateEmployee(ContractEmployee);
                employees.PrintEmployee(3);
                employees.UpdateEmployee(3, PartTimeEmployeeUpdatedToFulltime);
                employees.PrintEmployee(2);

                EmployeeService getEmployee = employees.GetEmployee(3);
                Console.WriteLine($"--------------\nEmployee ID: {getEmployee.Employee_ID}");
                Console.WriteLine($"Employee Name: {getEmployee.Employee_Name}");
                Console.WriteLine($"Employee Type: {getEmployee.Employee_Type}");

            }
            catch(Exception ex)
            {
                Console.WriteLine($"Error: {ex}");
            }
        }
    }
}