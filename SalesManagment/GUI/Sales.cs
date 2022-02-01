using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using SalesManagment.Validation;
using SalesManagment;


namespace SalesManagment.GUI
{
    public partial class Sales : Form
    {

        SqlDataAdapter da;
        DataSet dsHiTech;
        DataTable dtCustomers;
        SqlCommandBuilder sqlBuilder;
        public Sales()
        {
            InitializeComponent();
        }
        public bool ValidCustomerForm()
        {
            string id = textBoxCustomerID.Text.Trim();
            string name = textBoxCustomerName.Text.Trim();
            string street = textBoxCustomerstreet.Text.Trim();
            string city = textBoxCustomerCity.Text.Trim();
            string postalcode = textBoxCustomerPostalCode.Text.Trim();
            string phonenumber = textBoxCustomerPhone.Text.Trim();
            string fax = textBoxCustomerFax.Text.Trim();
            string credit = textBoxCustomerCreditLimit.Text.Trim();
            if (!(Validator.IsValidName(name)) || !(Validator.IsEmpty(name)))
            {
                MessageBox.Show("wrong Name- must be charecters only", "error");
                return false;
            }
            if (!(Validator.IsValidPostal(postalcode)) || !(Validator.IsEmpty(postalcode)))
            {
                MessageBox.Show("Postal Code must be in A0A1B1", "error");
                return false;
            }
            if (!(Validator.IsValidPhone(phonenumber)) || !(Validator.IsEmpty(phonenumber)))
            {
                MessageBox.Show("wrong phone- Must be 10 Digits", "error");
                return false;
            }
            if (!(Validator.IsValidPhone(fax)) || !(Validator.IsEmpty(fax)))
            {
                MessageBox.Show("wrong fax- Must be 10 Digits", "error");
                return false;
            }
            if (!(Validator.IsValidId(id)) || !(Validator.IsEmpty(id)))
            {
                MessageBox.Show("wrong ID", "error");
                return false;
            }
            if (!(Validator.IsValidstreet(street)) || !(Validator.IsEmpty(street)))
            {
                MessageBox.Show("wrong street", "error");
                return false;
            }
            
            if (!(Validator.IsValidName(city)) || !(Validator.IsEmpty(city)))
            {
                MessageBox.Show("wrong city- must be charecters only", "error");
                return false;
            }
            if (!(Validator.IsEmpty(credit)))
            {
                MessageBox.Show("please fill in Credit limit- must be numbers only", "error");
                return false;
            }
            return true;

            
        }
    
    

        private void Sales_Load(object sender, EventArgs e)
        {
            dsHiTech = new DataSet("HiTechDS");
            dtCustomers = new DataTable("Customers");
            dsHiTech.Tables.Add(dtCustomers);
            dtCustomers.Columns.Add("CustomerID", typeof(Int32));
            dtCustomers.Columns.Add("Name", typeof(string));
            dtCustomers.Columns.Add("Street", typeof(string));
            dtCustomers.Columns.Add("City", typeof(string));
            dtCustomers.Columns.Add("Postal_Code", typeof(string));
            dtCustomers.Columns.Add("Phone_Number", typeof(string));
            dtCustomers.Columns.Add("Fax_Number", typeof(string));
            dtCustomers.Columns.Add("Credit_Limit", typeof(int));
            dtCustomers.Columns["CustomerID"].AutoIncrement = true;
            dtCustomers.Columns["CustomerID"].AutoIncrementStep = 1;
            dtCustomers.Columns["CustomerID"].AutoIncrementSeed = 1;
            dtCustomers.PrimaryKey = new DataColumn[] { dtCustomers.Columns["CustomerID"] };
            da = new SqlDataAdapter("SELECT * FROM Customers", UtilityDB.ConnectDB());
            sqlBuilder = new SqlCommandBuilder(da);
            da.Fill(dsHiTech.Tables["Customers"]);
        }

        private void buttonCustomerAdd_Click(object sender, EventArgs e)
        {
            if (!ValidCustomerForm())
            {
                return;
            }
            DataRow dr = dtCustomers.NewRow();
            dr["Name"] = textBoxCustomerName.Text.Trim();
            dr["Street"] = textBoxCustomerstreet.Text.Trim();
            dr["City"] = textBoxCustomerCity.Text.Trim();
            dr["Postal_Code"] = textBoxCustomerPostalCode.Text.Trim();
            dr["Phone_Number"] = textBoxCustomerPhone.Text.Trim();
            dr["Fax_Number"] = textBoxCustomerFax.Text.Trim();
            dr["Credit_Limit"] = Convert.ToInt32(textBoxCustomerCreditLimit.Text.Trim());
            dtCustomers.Rows.Add(dr);
            //da.Fill(dsHiTech.Tables["Customers"]);
            MessageBox.Show(dr.RowState.ToString());
        }

        private void buttonCustomerSearch_Click(object sender, EventArgs e)
        {

            int searchid = Convert.ToInt32(textBoxCustomerID.Text.Trim());
            DataRow drCustomer = dtCustomers.Rows.Find(searchid);
            if (drCustomer != null)
            {
                textBoxCustomerName.Text = drCustomer["Name"].ToString();
                textBoxCustomerstreet.Text = drCustomer["Street"].ToString();
                textBoxCustomerCity.Text = drCustomer["City"].ToString();
                textBoxCustomerPostalCode.Text = drCustomer["Postal_Code"].ToString();
                textBoxCustomerPhone.Text = drCustomer["Phone_Number"].ToString();
                textBoxCustomerFax.Text = drCustomer["Fax_Number"].ToString();
                textBoxCustomerCreditLimit.Text = drCustomer["Credit_limit"].ToString();

            }
            else
            {
                MessageBox.Show("Customer not found!", "Invalid Customer ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCustomerList_Click(object sender, EventArgs e)
        {

            dataGridViewCustomersDS.DataSource = dsHiTech.Tables["Customers"];
        }

        private void buttonCustomerUpdate_Click(object sender, EventArgs e)
        {
            da.Update(dsHiTech.Tables["Customers"]);
            MessageBox.Show("Database has been updated sucessfully.", "Confirmation");
        }

        private void buttonCustomerModify_Click(object sender, EventArgs e)
        {
            if (!ValidCustomerForm())
            {
                return;
            }
            int searchid = Convert.ToInt32(textBoxCustomerID.Text.Trim());
            DataRow drCustomer = dtCustomers.Rows.Find(searchid);
            if (drCustomer != null)
            {
                drCustomer["Name"] = textBoxCustomerName.Text.Trim();
                drCustomer["Street"] = textBoxCustomerstreet.Text.Trim();
                drCustomer["City"] = textBoxCustomerCity.Text.Trim();
                drCustomer["Postal_Code"] = textBoxCustomerPostalCode.Text.Trim();
                drCustomer["Phone_Number"] = textBoxCustomerPhone.Text.Trim();
                drCustomer["Fax_Number"] = textBoxCustomerFax.Text.Trim();
                drCustomer["Credit_Limit"] = Convert.ToInt32(textBoxCustomerCreditLimit.Text.Trim());
                MessageBox.Show("Customer with ID: #"+ searchid + "  Successfully Modified ", "Comfirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Customer not found!", "Invalid Customer ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCustomerDelete_Click(object sender, EventArgs e)
        {
            int searchid = Convert.ToInt32(textBoxCustomerID.Text.Trim());
            string id = textBoxCustomerID.Text.Trim();
            if(!Validator.IsValidId(id))
            {
                return;
            }
            DataRow drCustomer = dtCustomers.Rows.Find(searchid);
            if (drCustomer != null)
            {
                drCustomer.Delete();
                MessageBox.Show("Customer with ID: #" + searchid + "  Successfully Deleted ", "Comfirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Customer not found!", "Invalid Customer ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            DialogResult exit = MessageBox.Show("Do you really want to exit the application?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (exit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}