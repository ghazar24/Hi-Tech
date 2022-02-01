using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HiTechProject.DAL;

namespace HiTechProject.BLL
{
    public class User
    {
        private int userID;
        private string password;
        private string first_Name;
        private string last_Name;
        private string phone_Number;
        private string email;
        private int jobID;
        private int userEmpID;

        public int UserID { get => userID; set => userID = value; }
        public string Password { get => password; set => password = value; }
        public string First_Name { get => first_Name; set => first_Name = value; }
        public string Last_Name { get => last_Name; set => last_Name = value; }
        public int JobID { get => jobID; set => jobID = value; }
        public string Phone_Number { get => phone_Number; set => phone_Number = value; }
        public string Email { get => email; set => email = value; }
        public int UserEmpID { get => userEmpID; set => userEmpID = value; }

        public User CheckUser(int userID, string password)
        {
            return UserDB.CheckUser(userID, password);
        }
        public void AddUser(User us)
        {
             UserDB.SaveRecord(us);
        }
        public void DeleteUser(int uId)
        {
            UserDB.DeleteRecord(uId);
        }
        public List<User> ListUsers()
        {
            return UserDB.ListAllRecords();
        }
        public void UpdateUser(User us)
        {
             UserDB.UpdateRecord(us);
        }
        public User SearchUser(int usrId)
        {

            return UserDB.SearchRecord(usrId);
        }
        public List<User> SearchUser(string name)
        {

            return UserDB.SearchRecord(name);
        }
        public User SearchEmpInUser (int usrID)
        {
            return UserDB.SearchEmpUsr(usrID);
        }

    }
}
