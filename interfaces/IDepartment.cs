using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Enumerations_Practice.models;

namespace Enumerations_Practice.interfaces
{
    public interface IDepartment
    {
        void CreateDepartment(DepartmentService department);
        DepartmentService GetDepartmentService(int id);
        string UpdateDepartment(int id, DepartmentService department);
        string RemoveDepartment(int id);
    }
}