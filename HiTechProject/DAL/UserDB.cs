using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HiTechProject.BLL;
using System.Data.SqlClient;


namespace HiTechProject.DAL
{
    public static class UserDB
    {
        public static User CheckUser(int Id, string pass)
        {
            User us = new User();
            SqlConnection conn = UtilityDB.ConnectDB();
            conn = UtilityDB.ConnectDB();
            SqlCommand cmdSelect = new SqlCommand();
            cmdSelect.CommandText = "SELECT * FROM Users " +
                                    "WHERE UserID = @UserID and Password=@Password";

            cmdSelect.Parameters.AddWithValue("@UserID", Id);
            cmdSelect.Parameters.AddWithValue("@Password", pass);
            cmdSelect.Connection = conn;
            SqlDataReader sqlReader = cmdSelect.ExecuteReader();
            if (sqlReader.Read())
            {

                us.UserID = Convert.ToInt32(sqlReader["UserID"]);
                us.Password = sqlReader["Password"].ToString();
                us.First_Name = sqlReader["First_Name"].ToString();
                us.Last_Name = sqlReader["Last_Name"].ToString();
                us.Phone_Number = sqlReader["Phone_Number"].ToString();
                us.Email = sqlReader["Email"].ToString();
                us.JobID = Convert.ToInt32(sqlReader["JobID"]);
            }
            else
            {
                us = null;
            }

            return us;
        }
        public static void SaveRecord(User us)
        {
            
            SqlConnection conn = UtilityDB.ConnectDB();

            SqlCommand cmdInsert = new SqlCommand();
            cmdInsert.CommandText = "INSERT INTO Users(UserID,First_Name,Last_Name,Phone_Number,Email,Password,JobID,EmployeeID) " +
                                    " VALUES (@UserID,@First_Name,@Last_Name,@Phone_Number,@Email,@Password,@JobID,@EmployeeID)";
            cmdInsert.Parameters.AddWithValue("@UserID", us.UserID);
            cmdInsert.Parameters.AddWithValue("@First_Name", us.First_Name);
            cmdInsert.Parameters.AddWithValue("@Last_Name", us.Last_Name);
            cmdInsert.Parameters.AddWithValue("@Phone_Number", us.Phone_Number);
            cmdInsert.Parameters.AddWithValue("@Email", us.Email);
            cmdInsert.Parameters.AddWithValue("@Password", us.Password);
            cmdInsert.Parameters.AddWithValue("@JobID", us.JobID);
            cmdInsert.Parameters.AddWithValue("@EmployeeID", us.UserEmpID);

            cmdInsert.Connection = conn;
            cmdInsert.ExecuteNonQuery();

            
            conn.Close();
        }

        public static void DeleteRecord(int uid)
        {
            
            SqlConnection conn = UtilityDB.ConnectDB();
            SqlCommand cmdDelete = new SqlCommand();
            cmdDelete.CommandText = "DELETE FROM Users " +
                                    "WHERE UserID= @UserID";
            cmdDelete.Parameters.AddWithValue("@UserID", uid);
            cmdDelete.Connection = conn;
            cmdDelete.ExecuteNonQuery();
            
            conn.Close();
        }
        public static List<User> ListAllRecords()
        {
            List<User> listusr = new List<User>();

            SqlConnection conn = UtilityDB.ConnectDB();
            conn = UtilityDB.ConnectDB();
            SqlCommand cmdSelect = new SqlCommand();
            cmdSelect.CommandText = "SELECT * FROM Users ";
            cmdSelect.Connection = conn;
            SqlDataReader sqlReader = cmdSelect.ExecuteReader();
            User us;

            while (sqlReader.Read())
            {
                us = new User();
                us.UserID = Convert.ToInt32(sqlReader["UserID"]);
                us.First_Name = sqlReader["First_Name"].ToString();
                us.Last_Name = sqlReader["Last_Name"].ToString();
                us.Email = sqlReader["Email"].ToString();
                us.Phone_Number = sqlReader["Phone_Number"].ToString();
                us.Password = sqlReader["Password"].ToString();
                us.JobID = Convert.ToInt32(sqlReader["JobID"]);
                us.UserEmpID = Convert.ToInt32(sqlReader["EmployeeID"]);


                listusr.Add(us);

            }
            return listusr;
        }
        public static void UpdateRecord(User us)
        {

            SqlConnection conn = UtilityDB.ConnectDB();

            SqlCommand cmdUpdate = new SqlCommand();
            cmdUpdate.CommandText = "UPDATE Users " +
                                    "SET    UserID = @UserID," +
                                    "       First_Name = @First_Name," +
                                    "       Last_Name = @Last_Name," +
                                    "       Email = @Email, " +
                                    "       Password = @Password, " +
                                    "       EmployeeID = @EmployeeID, " +
                                    "       JobID = @JobID, "+
                                    "       Phone_Number = @Phone_Number "+
                                    "WHERE  UserID = @UserID";
            cmdUpdate.Parameters.AddWithValue("@UserID", us.UserID);
            cmdUpdate.Parameters.AddWithValue("@First_Name", us.First_Name);
            cmdUpdate.Parameters.AddWithValue("@Last_Name", us.Last_Name);
            cmdUpdate.Parameters.AddWithValue("@Phone_Number", us.Phone_Number);
            cmdUpdate.Parameters.AddWithValue("@Email", us.Email);
            cmdUpdate.Parameters.AddWithValue("@Password", us.Password);
            cmdUpdate.Parameters.AddWithValue("@JobID", us.JobID);
            cmdUpdate.Connection = conn;
            cmdUpdate.ExecuteNonQuery();

            conn.Close();
        }
        public static User SearchRecord(int Id)
        {
            User usr = new User();
            SqlConnection conn = UtilityDB.ConnectDB();
            conn = UtilityDB.ConnectDB();
            SqlCommand cmdSelect = new SqlCommand();
            cmdSelect.CommandText = "SELECT * FROM Users " +
                                    "WHERE UserID = @UserID";
            cmdSelect.Parameters.AddWithValue("@UserID", Id);

            cmdSelect.Connection = conn;
            SqlDataReader sqlReader = cmdSelect.ExecuteReader();
            if (sqlReader.Read()) 
            {

                usr.UserID = Convert.ToInt32(sqlReader["UserID"]);
                usr.First_Name = sqlReader["First_Name"].ToString();
                usr.Last_Name = sqlReader["Last_Name"].ToString();
                usr.Email = sqlReader["Email"].ToString();
                usr.Password = sqlReader["Password"].ToString();
                usr.UserEmpID = Convert.ToInt32(sqlReader["EmployeeID"]);
                usr.Phone_Number = sqlReader["Phone_Number"].ToString();
                usr.JobID = Convert.ToInt32(sqlReader["JobID"]);
            }
            else 
            {
                usr = null;
            }

            return usr;
        }
        public static User SearchEmpUsr(int Id)
        {
            User usr = new User();
            SqlConnection conn = UtilityDB.ConnectDB();
            conn = UtilityDB.ConnectDB();
            SqlCommand cmdSelect = new SqlCommand();
            cmdSelect.CommandText = "SELECT * FROM Users " +
                                    "WHERE EmployeeID = @EmployeeID";
            cmdSelect.Parameters.AddWithValue("@EmployeeID", Id);

            cmdSelect.Connection = conn;
            SqlDataReader sqlReader = cmdSelect.ExecuteReader();
            if (sqlReader.Read())
            {

                usr.UserID = Convert.ToInt32(sqlReader["UserID"]);
                usr.First_Name = sqlReader["First_Name"].ToString();
                usr.Last_Name = sqlReader["Last_Name"].ToString();
                usr.Email = sqlReader["Email"].ToString();
                usr.Password = sqlReader["Password"].ToString();
                usr.UserEmpID = Convert.ToInt32(sqlReader["EmployeeID"]);
                usr.Phone_Number = sqlReader["Phone_Number"].ToString();
                usr.JobID = Convert.ToInt32(sqlReader["JobID"]);
            }
            else
            {
                usr = null;
            }

            return usr;
        }
        public static List<User> SearchRecord(string name)
        {
            List<User> listusr = new List<User>();
            
            SqlConnection conn = UtilityDB.ConnectDB();
            conn = UtilityDB.ConnectDB();
            SqlCommand cmdSelect = new SqlCommand();
            cmdSelect.CommandText = "SELECT * FROM Users " +
                                    "WHERE First_Name = @First_Name " +
                                    " Or Last_Name = @Last_Name ";
            cmdSelect.Parameters.AddWithValue("@First_Name", name);
            cmdSelect.Parameters.AddWithValue("@Last_Name", name);

            cmdSelect.Connection = conn;
            SqlDataReader sqlReader = cmdSelect.ExecuteReader();
            User usr;

            while (sqlReader.Read())
            {
                usr = new User();
                usr.UserID = Convert.ToInt32(sqlReader["UserID"]);
                usr.First_Name = sqlReader["First_Name"].ToString();
                usr.Last_Name = sqlReader["Last_Name"].ToString();
                usr.Email = sqlReader["Email"].ToString();
                usr.Password = sqlReader["Password"].ToString();
                usr.UserEmpID = Convert.ToInt32(sqlReader["EmployeeID"]);
                usr.Phone_Number = sqlReader["Phone_Number"].ToString();
                usr.JobID = Convert.ToInt32(sqlReader["JobID"]);


                listusr.Add(usr);


            }
            return listusr;
        }
    }
}
