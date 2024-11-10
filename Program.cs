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
                DepartmentService departments = new DepartmentService();

                DepartmentService CSE = new DepartmentService
                {
                    Department_ID = 1,
                    Department_Name = "Computer Science & Engineering",
                    Department_Type = DepartmentTypes.CSE.ToString()
                };
                DepartmentService CSEUpdatedToEEE = new DepartmentService
                {
                    Department_ID = 1,
                    Department_Name = "Electrical & Electronics Engineering",
                    Department_Type = DepartmentTypes.EEE.ToString()
                };
                DepartmentService EEE = new DepartmentService
                {
                    Department_ID = 2,
                    Department_Name = "Electrical & Electronics Engineering",
                    Department_Type = DepartmentTypes.EEE.ToString()
                };
                DepartmentService Marketing = new DepartmentService
                {
                    Department_ID = 3,
                    Department_Name = "Marketing",
                    Department_Type = DepartmentTypes.Marketing.ToString()
                };
                DepartmentService Astronomy = new DepartmentService
                {
                    Department_ID = 3,
                    Department_Name = "Marketing",
                    Department_Type = DepartmentTypes.Astronomy.ToString()
                };

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
                employees.PrintEmployee(2);
                Console.WriteLine($"Employee Type: {employees.GetEmployeeType(3)}");
                Console.WriteLine(employees.UpdateEmployee(3, PartTimeEmployeeUpdatedToFulltime));

                EmployeeService getEmployee = employees.GetEmployee(3);
                Console.WriteLine($"--------------\nEmployee ID: {getEmployee.Employee_ID}");
                Console.WriteLine($"Employee Name: {getEmployee.Employee_Name}");
                Console.WriteLine($"Employee Type: {getEmployee.Employee_Type}");

                Console.WriteLine(employees.RemoveEmployee(2));
                //---------------------------------------------
                departments.CreateDepartment(CSE);
                departments.CreateDepartment(EEE);
                departments.CreateDepartment(Astronomy);
                departments.CreateDepartment(Marketing);
                
                DepartmentService department2 = departments.GetDepartmentService(2);
                Console.WriteLine($"Department ID: {department2.Department_ID}");
                Console.WriteLine($"Department Name: {department2.Department_Name}");
                Console.WriteLine($"Department Type: {department2.Department_Type}");

                DepartmentService department1 = departments.GetDepartmentService(1);
                Console.WriteLine($"Before Update:");
                Console.WriteLine($"Department ID: {department1.Department_ID}");
                Console.WriteLine($"Department Name: {department1.Department_Name}");
                Console.WriteLine($"Department Type: {department1.Department_Type}");
                departments.UpdateDepartment(1, CSEUpdatedToEEE);
                Console.WriteLine($"After Update:");
                Console.WriteLine($"Department ID: {department1.Department_ID}");
                Console.WriteLine($"Department Name: {department1.Department_Name}");
                Console.WriteLine($"Department Type: {department1.Department_Type}");
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Error: {ex}");
            }
            //Created Branch From here
        }
    }
}