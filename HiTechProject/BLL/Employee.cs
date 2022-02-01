using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HiTechProject.DAL;

namespace HiTechProject.BLL
{
    public class Employee
    {
        private int employeeID;
        private string first_Name;
        private string last_Name;
        private string phone_Number;
        private string email;
        

        public int EmployeeID { get => employeeID; set => employeeID = value; }
        public string First_Name { get => first_Name; set => first_Name = value; }
        public string Last_Name { get => last_Name; set => last_Name = value; }
        public string Phone_Number { get => phone_Number; set => phone_Number = value; }
        public string Email { get => email; set => email = value; }
        

        public void SaveEmployee(Employee emp)
        {
            EmployeeDB.SaveRecord(emp);
        }

        public List<Employee> ListEmployees()
        {
            return EmployeeDB.ListAllRecords();
        }
        public void DeleteEmployee(int eId)
        {
            EmployeeDB.DeleteRecord(eId);
        }
        public Employee SearchEmployee(int empId)
        {

            return EmployeeDB.SearchRecord(empId);
        }
        public List<Employee> SearchEmployee(string name)
        {

            return EmployeeDB.SearchRecord(name);
        }
        public void UpdateEmployee(Employee emp)
        {
            EmployeeDB.UpdateRecord(emp);
        }
        
    }
}
