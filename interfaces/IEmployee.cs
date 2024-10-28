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
        EmployeeService GetEmployee(int id, EmployeeService employee);
        
    }
}