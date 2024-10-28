using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Enumerations_Practice.interfaces;

namespace Enumerations_Practice.models
{
    public class EmployeeService : IEmployee
    {
        private List<EmployeeService> employeeServicesList
        = new List<EmployeeService>();
        private int EmployeeID;
        private string Name;
        private string EmployeeType;
        public int Employee_ID
        {
            get {return EmployeeID;}
            set {EmployeeID = value;}
        }
        public string Employee_Name
        {
            get {return Name;}
            set {Name = value;}
        }
        public string Employee_Type
        {
            get {return EmployeeType;}
            set {EmployeeType = value;}
        }
        public void PrintEmployee(int id)
        {
            if(id <= 0) throw new ArgumentException("Invalid ID! Must be Positive Integer.");
            EmployeeService getEmployee = employeeServicesList.FirstOrDefault(single => single.Employee_ID == id);
            if(getEmployee == null) throw new ArgumentException("Empty List! Could not Found.");

            Console.WriteLine($"=------Employee Information---------=");
            Console.WriteLine($"Employee ID: {getEmployee.Employee_ID}");
            Console.WriteLine($"Employee Name: {getEmployee.Employee_Name}");
            Console.WriteLine($"Employee Type: {getEmployee.Employee_Type}");
        }
        public int TotalEmployee()
        {
            return employeeServicesList.Count();
        }

        public void CreateEmployee(EmployeeService employee)
        {
            employeeServicesList.Add(employee);
        }
        public EmployeeService GetEmployee(int id, EmployeeService employee)
        {
            if(id <= 0) throw new ArgumentException("Invalid ID! Must be Positive Integer.");

            EmployeeService foundEmployee = employeeServicesList.FirstOrDefault(singleEmployee => singleEmployee.Employee_ID == id);

            if(foundEmployee == null) throw new ArgumentException("Empty Employee Lists!");

            return foundEmployee;
        }
    }
}