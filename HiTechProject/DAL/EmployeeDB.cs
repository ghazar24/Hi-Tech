using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HiTechProject.BLL;
using System.Data.SqlClient;

namespace HiTechProject.DAL
{
    public class EmployeeDB
    {
        


        public static void SaveRecord(Employee emp)
        {
            
            SqlConnection conn = UtilityDB.ConnectDB();
            
            
            SqlCommand cmdInsert = new SqlCommand();
            cmdInsert.CommandText = "INSERT INTO Employees(EmployeeID,First_Name,Last_Name,Phone_Number,Email) " +
                                    " VALUES (@EmployeeID,@First_Name,@Last_Name,@Phone_Number,@Email)";
            cmdInsert.Parameters.AddWithValue("@EmployeeID", emp.EmployeeID);
            cmdInsert.Parameters.AddWithValue("@First_Name", emp.First_Name);
            cmdInsert.Parameters.AddWithValue("@Last_Name", emp.Last_Name);
            cmdInsert.Parameters.AddWithValue("@Phone_Number", emp.Phone_Number);
            cmdInsert.Parameters.AddWithValue("@Email", emp.Email);
            
            cmdInsert.Connection = conn;
            cmdInsert.ExecuteNonQuery();

            
            conn.Close();
        }
        public static List<Employee> ListAllRecords()
        {
            List<Employee> listEmp = new List<Employee>();
            
            SqlConnection conn = UtilityDB.ConnectDB();
            conn = UtilityDB.ConnectDB();
            SqlCommand cmdSelect = new SqlCommand();
            cmdSelect.CommandText = "SELECT * FROM Employees ";
            cmdSelect.Connection = conn;
            SqlDataReader sqlReader = cmdSelect.ExecuteReader();
            Employee emp;

            while (sqlReader.Read())
            {
                emp = new Employee();
                emp.EmployeeID = Convert.ToInt32(sqlReader["EmployeeID"]);
                emp.First_Name = sqlReader["First_Name"].ToString();
                emp.Last_Name = sqlReader["Last_Name"].ToString();
                emp.Email = sqlReader["Email"].ToString();
                emp.Phone_Number = sqlReader["Phone_Number"].ToString();
               

                listEmp.Add(emp);

            }
            return listEmp;
        }
        public static void DeleteRecord(int empId)
        {
            // Step 1: Connect the database
            SqlConnection conn = UtilityDB.ConnectDB();
            // Step 2: Perform DELETE Statement
            SqlCommand cmdDelete = new SqlCommand();
            cmdDelete.CommandText = "DELETE FROM Employees " +
                                    "WHERE EmployeeId= @EmployeeId";
            cmdDelete.Parameters.AddWithValue("@EmployeeId", empId);
            cmdDelete.Connection = conn;
            cmdDelete.ExecuteNonQuery();
            //Step 3: Close the DB connection
            conn.Close();
        }
        public static Employee SearchRecord(int Id)
        {
            Employee emp = new Employee();
            SqlConnection conn = UtilityDB.ConnectDB();
            conn = UtilityDB.ConnectDB();
            SqlCommand cmdSelect = new SqlCommand();
            cmdSelect.CommandText = "SELECT * FROM Employees " +
                                    "WHERE EmployeeID = @EmployeeID";
            cmdSelect.Parameters.AddWithValue("@EmployeeID", Id);

            cmdSelect.Connection = conn;
            SqlDataReader sqlReader = cmdSelect.ExecuteReader();
            if (sqlReader.Read()) // found
            {
                
                emp.EmployeeID = Convert.ToInt32(sqlReader["EmployeeID"]);
                emp.First_Name = sqlReader["First_Name"].ToString();
                emp.Last_Name = sqlReader["Last_Name"].ToString();
                emp.Email = sqlReader["Email"].ToString();
                emp.Phone_Number = sqlReader["Phone_Number"].ToString(); ;
            }
            else // not found
            {
                emp = null;
            }

            return emp;
        }
        public static List<Employee> SearchRecord(string name)
        {
            List<Employee> listEmp = new List<Employee>();
            //Employee emp = new Employee();
            SqlConnection conn = UtilityDB.ConnectDB();
            conn = UtilityDB.ConnectDB();
            SqlCommand cmdSelect = new SqlCommand();
            cmdSelect.CommandText = "SELECT * FROM Employees " +
                                    "WHERE First_Name = @First_Name " +
                                    " Or Last_Name = @Last_Name ";
            cmdSelect.Parameters.AddWithValue("@First_Name", name);
            cmdSelect.Parameters.AddWithValue("@Last_Name", name);

            cmdSelect.Connection = conn;
            SqlDataReader sqlReader = cmdSelect.ExecuteReader();
            Employee emp;

            while (sqlReader.Read())
            {
                emp = new Employee();
                emp.EmployeeID = Convert.ToInt32(sqlReader["EmployeeID"]);
                emp.First_Name = sqlReader["First_Name"].ToString();
                emp.Last_Name = sqlReader["Last_Name"].ToString();
                emp.Email = sqlReader["Email"].ToString();
                emp.Phone_Number = sqlReader["Phone_Number"].ToString();


                listEmp.Add(emp);


            }
            return listEmp;
        }
        public static void UpdateRecord(Employee emp)
        {
            
            SqlConnection conn = UtilityDB.ConnectDB();
            
            SqlCommand cmdUpdate = new SqlCommand();
            cmdUpdate.CommandText = "UPDATE Employees " +
                                    "SET    EmployeeID = @EmployeeID," +
                                    "       First_Name = @First_Name," +
                                    "       Last_Name = @Last_Name," +
                                    "       Email = @Email, " +
                                    "       Phone_Number = @Phone_Number " +
                                    "WHERE  EmployeeID = @EmployeeID";
            cmdUpdate.Parameters.AddWithValue("@EmployeeID", emp.EmployeeID);
            cmdUpdate.Parameters.AddWithValue("@First_Name", emp.First_Name);
            cmdUpdate.Parameters.AddWithValue("@Last_Name", emp.Last_Name);
            cmdUpdate.Parameters.AddWithValue("@Phone_Number", emp.Phone_Number);
            cmdUpdate.Parameters.AddWithValue("@Email", emp.Email);
            cmdUpdate.Connection = conn;
            cmdUpdate.ExecuteNonQuery();
            
            conn.Close();
        }
        
    }
   
}

