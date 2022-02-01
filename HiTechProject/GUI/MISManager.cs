using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HiTechProject.BLL;
using HiTechProject.DAL;
using HiTechProject.Validation;

namespace HiTechProject
{
    public partial class Form1 : Form
    {
        int jobID;
        
        public Form1()
        {
            InitializeComponent();
        }


        public bool Validatuserform() 
        {

            string id = textBoxUserID.Text.Trim();
            string name = textBoxUserFirstName.Text.Trim();
            string email = textBoxUserEmail.Text.Trim();
            string phone = textBoxUserPhone.Text.Trim();

            if (!(Validator.IsValidName(name)) || !(Validator.IsEmpty(name)))
            {
                MessageBox.Show("wrong Name- must be charecters only", "error");
                return false;
            }
            if (!(Validator.IsValidEmail(email)) || !(Validator.IsEmpty(email)))
            {
                MessageBox.Show("wrong email adresse", "error");
                return false;
            }
            if (!(Validator.IsValidPhone(phone)) || !(Validator.IsEmpty(phone)))
            {
                MessageBox.Show("wrong phone- Must be 10 Digits", "error");
                return false;
            }
            if (!(Validator.IsValidId(id)) || !(Validator.IsEmpty(id)))
            {
                MessageBox.Show("wrong ID Format", "error");
                return false;
            }
            return true;
        }
        public bool ValidEmployeeForm()
        {
            string name = textBoxEmployeeFirstName.Text.Trim();
            string email = textBoxEmployeeEmail.Text.Trim();
            string phone = textBoxEmployeePhone.Text.Trim();
            string id = textBoxEmployeeID.Text.Trim();
            if (!(Validator.IsValidName(name)) || !(Validator.IsEmpty(name)))
            {
                MessageBox.Show("wrong Name- must be charecters only", "error");
                return false;
            }
            if (!(Validator.IsValidEmail(email)) || !(Validator.IsEmpty(email)))
            {
                MessageBox.Show("wrong email adresse", "error");
                return false;
            }
            if (!(Validator.IsValidPhone(phone)) || !(Validator.IsEmpty(phone)))
            {
                MessageBox.Show("wrong phone- Must be 10 Digits", "error");
                return false;
            }
            if (!(Validator.IsValidId(id)) || !(Validator.IsEmpty(id)))
            {
                MessageBox.Show("wrong ID", "error");
                return false;
            }
            return true;
        }
        private void buttonUserAdd_Click(object sender, EventArgs e)
        {
            User userV = new User();
            User userE = new User();
            User user = new User();
            string id = textBoxUserID.Text.Trim();
            if (!Validatuserform())
            {
                return;
            }


            userV = userV.SearchUser(Convert.ToInt32(id));

            if (userV != null)
            {
                MessageBox.Show("User already exist", "error");
                return;
            }
            userE = userE.SearchEmpInUser(Convert.ToInt32(id));
            if (userE != null)
            {
                MessageBox.Show("Employee already assigned", "error");
                return;
            }

            if (comboBoxUserEmployeeID.SelectedIndex == -1)
            {
                MessageBox.Show("Please select the employee.", "Error");
                return;
            }
            int employeeid = Convert.ToInt32(comboBoxUserEmployeeID.SelectedValue);
            user.UserID = Convert.ToInt32(textBoxUserID.Text.Trim());
            user.First_Name = textBoxUserFirstName.Text.Trim();
            user.Last_Name = textBoxUserLastName.Text.Trim();
            user.Email = textBoxUserEmail.Text.Trim();
            user.Phone_Number = textBoxUserPhone.Text.Trim();
            user.Password = textBoxUserPassword.Text.Trim();
            user.UserEmpID = employeeid;

            user.JobID = jobID;


            user.AddUser(user);

            MessageBox.Show("User data saved successfully.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

        } 
        private void buttonEmployeeAdd_Click(object sender, EventArgs e)
        {
            string id = textBoxEmployeeID.Text.Trim();
            if (!ValidEmployeeForm())
            {
                return;
            }
            Employee empid = new Employee();
            empid = empid.SearchEmployee(Convert.ToInt32(id));

            if (empid != null)
            {
                MessageBox.Show("Employee already exist", "error");
                return;
            }
            Employee emp = new Employee();
            emp.EmployeeID = Convert.ToInt32(textBoxEmployeeID.Text.Trim());
            emp.First_Name = textBoxEmployeeFirstName.Text.Trim();
            emp.Last_Name = textBoxEmployeeLastName.Text.Trim();
            emp.Email = textBoxEmployeeEmail.Text.Trim();
            emp.Phone_Number = textBoxEmployeePhone.Text.Trim();
            emp.SaveEmployee(emp);
            MessageBox.Show("Employee data saved successfully.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void comboBoxUserJob_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            int indexSelected = comboBoxUserJob.SelectedIndex;

            switch (indexSelected)
            {
                case 0:
                    jobID = 1;
                    break;
                case 1:
                    jobID = 2;
                    break;
                case 2:
                    jobID = 3;
                    break;
                case 3:
                    jobID = 4;
                    break;


                default:
                    break;
            }
        }

        private void buttonEmployeeListAll_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            List<Employee> listEmp = emp.ListEmployees();
            listViewEmployees.Items.Clear();
            if (listEmp.Count != 0)
            {
                foreach (Employee anEmp in listEmp)
                {
                    ListViewItem item = new ListViewItem(anEmp.EmployeeID.ToString());
                    item.SubItems.Add(anEmp.First_Name);
                    item.SubItems.Add(anEmp.Last_Name);
                    item.SubItems.Add(anEmp.Email);
                    item.SubItems.Add(anEmp.Phone_Number);
                    listViewEmployees.Items.Add(item);
                }

            }
            else
            {
                MessageBox.Show("Empty List!", "No Employee");
            }
        }

        private void buttonEmployeeDelete_Click(object sender, EventArgs e)
        {
            DialogResult delete = MessageBox.Show("Deleting This Employee will remove all his/her records", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (delete == DialogResult.Yes)
            {
                Employee emp = new Employee();
                int EmployeeID = Convert.ToInt32(textBoxEmployeeID.Text.Trim());
                emp.DeleteEmployee(EmployeeID);
                MessageBox.Show("Employee Succefully Deleted");
            }
            else
            {
                textBoxEmployeeID.Text = string.Empty;
                MessageBox.Show("employee couldn't be found!", "Error");
            }

        }

        private void buttonUserDelete_Click(object sender, EventArgs e)
        {
            DialogResult delete = MessageBox.Show("Do really want to delete this user?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (delete == DialogResult.Yes)
            {
                User us = new User();
                int userID = Convert.ToInt32(textBoxUserID.Text.Trim());
                us.DeleteUser(userID);
                MessageBox.Show("User Succefully Deleted");
            }
            else
            {
                textBoxEmployeeID.Text = string.Empty;
                MessageBox.Show("User couldn't be found!", "Error");
            }
        }

        private void buttonUserListAll_Click(object sender, EventArgs e)
        {

            User us = new User();
            List<User> listusr = us.ListUsers();
            listViewUsers.Items.Clear();
            if (listusr.Count != 0)
            {
                foreach (User usr in listusr)
                {
                    ListViewItem item = new ListViewItem(usr.UserID.ToString());
                    item.SubItems.Add(usr.First_Name);
                    item.SubItems.Add(usr.Last_Name);
                    item.SubItems.Add(usr.Phone_Number);
                    item.SubItems.Add(usr.Email);
                    item.SubItems.Add(usr.JobID.ToString());
                    item.SubItems.Add(usr.UserEmpID.ToString());
                    item.SubItems.Add(usr.Password);
                    listViewUsers.Items.Add(item);
                }

            }
            else
            {
                MessageBox.Show("User List!", "No User");
            }
        }

        private void buttonUserSearch_Click(object sender, EventArgs e)
        {
            int indexSelected = comboBoxEmployeeSearch.SelectedIndex;
            string id = textBoxUserSearch.Text.Trim();
            if (!(Validator.IsValidId(id)) || !(Validator.IsEmpty(id)))
            {
                MessageBox.Show("wrong ID", "error");
                return;
            }
            switch (indexSelected)
            {
                case 0:

                    User use = new User();
                    use.UserID = Convert.ToInt32(textBoxUserSearch.Text);
                    use = use.SearchUser (use.UserID);
                    listViewEmployees.Items.Clear();
                    if (use != null)
                    {
                        ListViewItem item = new ListViewItem(use.UserID.ToString());
                        item.SubItems.Add(use.First_Name);
                        item.SubItems.Add(use.Last_Name);
                        item.SubItems.Add(use.Email);
                        item.SubItems.Add(use.Phone_Number);
                        item.SubItems.Add(use.Password);
                        item.SubItems.Add(use.JobID.ToString()); 
                        item.SubItems.Add(use.Phone_Number);
                        listViewEmployees.Items.Add(item);
                    }
                    else
                    {
                        MessageBox.Show("User not found");
                    }
                    break;
                case 1:

                    User use1 = new User();
                    List<User> listusr = use1.SearchUser(textBoxUserSearch.Text.ToString());
                    listViewEmployees.Items.Clear();
                    if (listusr.Count != 0)
                    {
                        foreach (User usr in listusr)
                        {
                            ListViewItem item = new ListViewItem(usr.UserID.ToString());
                            item.SubItems.Add(usr.First_Name);
                            item.SubItems.Add(usr.Last_Name);
                            item.SubItems.Add(usr.Email);
                            item.SubItems.Add(usr.Phone_Number);
                            item.SubItems.Add(usr.Password);
                            item.SubItems.Add(usr.JobID.ToString());
                            item.SubItems.Add(usr.Phone_Number);
                            listViewEmployees.Items.Add(item);
                        }

                    }
                    else
                    {
                        MessageBox.Show("User not found!", "Error");
                    }
                    break;

                case 2:
                    User use2 = new User();
                    List<User> listusr2 = use2.SearchUser(textBoxUserSearch.Text.ToString());
                    listViewEmployees.Items.Clear();
                    if (listusr2.Count != 0)
                    {
                        foreach (User us in listusr2)
                        {
                            ListViewItem item = new ListViewItem(us.UserID.ToString());
                            item.SubItems.Add(us.First_Name);
                            item.SubItems.Add(us.Last_Name);
                            item.SubItems.Add(us.Email);
                            item.SubItems.Add(us.Phone_Number);
                            item.SubItems.Add(us.Password);
                            item.SubItems.Add(us.JobID.ToString());
                            item.SubItems.Add(us.Phone_Number);
                            listViewEmployees.Items.Add(item);
                        }

                    }
                    else
                    {
                        MessageBox.Show("User not found!", "Error");
                    }
                    break;
                    
                default:
                    break;

            }

        }

        private void buttonEmployeeSearch_Click(object sender, EventArgs e)
        {
            int indexSelected = comboBoxEmployeeSearch.SelectedIndex;
            string id = textBoxEmployeeSearch.Text.Trim();
            if (!(Validator.IsValidId(id)) || !(Validator.IsEmpty(id)))
            {
                MessageBox.Show("wrong ID", "error");
                return;
            }
            switch (indexSelected)
            {
                case 0:
                    
                    Employee emp = new Employee();
                    emp.EmployeeID = Convert.ToInt32(textBoxEmployeeSearch.Text);
                    emp = emp.SearchEmployee(emp.EmployeeID);
                    listViewEmployees.Items.Clear();
                    if (emp != null)
                    {
                        ListViewItem item = new ListViewItem(emp.EmployeeID.ToString());
                        item.SubItems.Add(emp.First_Name);
                        item.SubItems.Add(emp.Last_Name);
                        item.SubItems.Add(emp.Email);
                        item.SubItems.Add(emp.Phone_Number);
                        listViewEmployees.Items.Add(item);
                    }
                    else
                    {
                        MessageBox.Show("Employee not found");
                    }
                    break;
                case 1:
                   
                    Employee emp1 = new Employee();
                    List<Employee> listEmp = emp1.SearchEmployee(textBoxEmployeeSearch.Text.ToString());
                    listViewEmployees.Items.Clear();
                    if (listEmp.Count != 0)
                    {
                        foreach (Employee anEmp in listEmp)
                        {
                            ListViewItem item = new ListViewItem(anEmp.EmployeeID.ToString());
                            item.SubItems.Add(anEmp.First_Name);
                            item.SubItems.Add(anEmp.Last_Name);
                            item.SubItems.Add(anEmp.Email);
                            item.SubItems.Add(anEmp.Phone_Number);
                            listViewEmployees.Items.Add(item);
                        }

                    }
                    else
                    {
                        MessageBox.Show("Employee not found!", "Error");
                    }
                    break;
                    
                case 2:
                    Employee emp2 = new Employee();
                    List<Employee> listEmp2 = emp2.SearchEmployee(textBoxEmployeeSearch.Text.ToString());
                    listViewEmployees.Items.Clear();
                    if (listEmp2.Count != 0)
                    {
                        foreach (Employee anEmp in listEmp2)
                        {
                            ListViewItem item = new ListViewItem(anEmp.EmployeeID.ToString());
                            item.SubItems.Add(anEmp.First_Name);
                            item.SubItems.Add(anEmp.Last_Name);
                            item.SubItems.Add(anEmp.Email);
                            item.SubItems.Add(anEmp.Phone_Number);
                            listViewEmployees.Items.Add(item);
                        }

                    }
                    else
                    {
                        MessageBox.Show("Employee not found!", "Error");
                    }
                    break;
                default:
                    break;

            }
        }

        private void buttonEmployeeUpdate_Click(object sender, EventArgs e)
        {
            if (!ValidEmployeeForm())
            {
                return;
            }
            Employee emp = new Employee();
            emp.EmployeeID = Convert.ToInt32(textBoxEmployeeID.Text.Trim());
            emp.First_Name = textBoxEmployeeFirstName.Text.Trim();
            emp.Last_Name = textBoxEmployeeLastName.Text.Trim();
            emp.Email = textBoxEmployeeEmail.Text.Trim();
            emp.Phone_Number = textBoxEmployeePhone.Text.Trim();
            DialogResult answer = MessageBox.Show("Do you really want to update this employee info? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (answer == DialogResult.Yes)
            {
                emp.UpdateEmployee(emp);
            }
        }

        private void buttonUserUpdate_Click(object sender, EventArgs e)
        {
            if (!Validatuserform())
            {
                return;
            }
            User usr = new User();
            usr.UserEmpID = Convert.ToInt32(comboBoxUserEmployeeID.SelectedValue);
            usr.First_Name = textBoxUserFirstName.Text.Trim();
            usr.Last_Name = textBoxUserLastName.Text.Trim();
            usr.Password = textBoxUserPassword.Text.Trim();
            usr.Phone_Number = textBoxUserPhone.Text.Trim();
            usr.Email= textBoxUserEmail.Text.Trim();
            usr.JobID = Convert.ToInt32(jobID);
            usr.UserID = Convert.ToInt32(textBoxUserID.Text.Trim());
            DialogResult answer = MessageBox.Show("Do you really want to update this User info? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (answer == DialogResult.Yes)
            {
                usr.UpdateUser(usr);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            List<Employee> listEmp4 = emp.ListEmployees();
            foreach (Employee emp4 in listEmp4)
            {
                comboBoxUserEmployeeID.DisplayMember = "First_Name";
                comboBoxUserEmployeeID.ValueMember = "EmployeeID";
                comboBoxUserEmployeeID.DataSource = listEmp4;


            }
        }

        private void comboBoxUserEmployeeID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            List<Employee> listEmp4 = emp.ListEmployees();
            foreach (Employee emp4 in listEmp4)
            {
                comboBoxUserEmployeeID.DisplayMember = "First_Name";
                comboBoxUserEmployeeID.ValueMember = "EmployeeID";
                comboBoxUserEmployeeID.DataSource = listEmp4;


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult exit = MessageBox.Show("Do you really want to exit the application?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (exit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id = 1;
            User ff = new User();
            ff = ff.SearchEmpInUser(id);
            MessageBox.Show(ff.Password);
        }
    }
}