using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Threading.Tasks;

namespace Enumerations_Practice.models
{
    public class DepartmentService
    {
        private List<DepartmentService> departmentServicesLists = new List<DepartmentService>();
        private int DepartmentID;   
        private string DepartmentName;   
        private string DepartmentType;   

        public int Department_ID
        {
            get {return DepartmentID;}
            set {DepartmentID = value;}
        }
        public string Department_Name
        {
            get {return DepartmentName;}
            set {DepartmentName = value;}
        }
        public string Department_Type
        {
            get {return DepartmentType;}
            set {DepartmentType = value;}
        }
        public void CreateDepartment(DepartmentService department)
        {
            departmentServicesLists.Add(department);
        }
        public DepartmentService GetDepartmentService(int id)
        {
            CheckId(id);
            DepartmentService department = departmentServicesLists.FirstOrDefault(single => single.Department_ID == id);
            CheckNull(department);

            return department;
        }
        public string UpdateDepartment(int id, DepartmentService service)
        {
            CheckId(id);
            DepartmentService UpdatedDepartment = departmentServicesLists.FirstOrDefault(single => single.Department_ID == id);
            CheckNull( UpdatedDepartment);

            departmentServicesLists.Remove(UpdatedDepartment);
            UpdatedDepartment.Department_ID = service.Department_ID;
            UpdatedDepartment.Department_Name = service.Department_Name;
            UpdatedDepartment.Department_Type = service.Department_Type;
            departmentServicesLists.Add( UpdatedDepartment);

            return "Messege: Updated Department Successfully!";
        }
        public string RemoveDepartment(int id)
        {
            CheckId(id);
            DepartmentService RemoveDept = departmentServicesLists.FirstOrDefault(single => single.Department_ID == id);
            CheckNull(RemoveDept);

            departmentServicesLists.Remove(RemoveDept);
            return "Messege: Removed Successfully!";
        }

        private void CheckId(int id)
        {
            if(id <= 0) throw new ArgumentException("Invalid ID! Must be Positive Integer.");
        }
        private void CheckNull(DepartmentService service)
        {
            if(service == null) throw new ArgumentException("Empty Lists!");
        }
    }
}