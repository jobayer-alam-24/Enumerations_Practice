using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Enumerations_Practice.models;

namespace Enumerations_Practice.interfaces
{
    public interface IEmployee
    {
        void CreateEmployee(EmployeeService employee);
        EmployeeService GetEmployee(int id);
        string UpdateEmployee(int id, EmployeeService service);
        string RemoveEmployee(int id);
    }
}