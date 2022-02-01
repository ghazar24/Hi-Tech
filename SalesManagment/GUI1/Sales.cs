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
using SalesManagment.DAL;

namespace SalesManagment.GUI1
{
    public partial class Sales : Form
    {
        SqlDataAdapter da;
        DataSet dsHiTech;
        DataTable dtCustomers;
        SqlCommandBuilder sqlBuilder;
        Customer aCustomer = new Customer();
        public Sales()
        {
            InitializeComponent();
        }
        private void Sales_Load_1(object sender, EventArgs e)
        {
            dsHiTech = new DataSet("HiTechDS");
            dtCustomers = new DataTable("Customers");
            dtCustomers.Columns.Add("CustomerID", typeof(int));
            dtCustomers.Columns.Add("Name", typeof(string));
            dtCustomers.Columns.Add("Street", typeof(string));
            dtCustomers.Columns.Add("City", typeof(string));
            dtCustomers.Columns.Add("Postal_Code", typeof(string));
            dtCustomers.Columns.Add("Phone_Number", typeof(int));
            dtCustomers.Columns.Add("Fax_Number", typeof(int));
            dtCustomers.Columns.Add("Credit_Limit", typeof(int));
            dtCustomers.PrimaryKey = new DataColumn[] { dtCustomers.Columns["CustomerID"] };
            da = new SqlDataAdapter("SELECT * FROM Customers", UtilityDB.ConnectDB());
            sqlBuilder = new SqlCommandBuilder(da);
        }
        private void buttonCustomerAdd_Click(object sender, EventArgs e)
        {
            //Data validation first [ firstName, lastName]
            // add a new row to the DataTable Students in the DataSet
            DataRow dr = dtCustomers.NewRow();
            dr["CustomerID"] = Convert.ToInt32(textBoxCustomerID.Text.Trim());
            dr["Name"] = textBoxCustomerName.Text.Trim();
            dr["Street"] = textBoxCustomerStreet.Text.Trim();
            dr["City"] = textBoxCustomerCity.Text.Trim();
            dr["Postal_Code"] = textBoxCustomerPostalCode.Text.Trim();
            dr["Phone_Number"] = Convert.ToInt32(textBoxCustomerPhone.Text.Trim());
            dr["Fax_Number"] = Convert.ToInt32(textBoxCustomerFax.Text.Trim());
            dr["Credit_Limit"] = Convert.ToInt32(textBoxCustomerCreditLimit.Text.Trim());


            dtCustomers.Rows.Add(dr);
            MessageBox.Show(dr.RowState.ToString());
        }

        private void buttonCustomerSearch_Click_1(object sender, EventArgs e)
        {
            int indexSelected = comboBoxCustomerSearch.SelectedIndex;

            switch (indexSelected)
            {
                case 0:
                    //Data validation first - Do-It-Yourself
                    //Search by StudentId
                    int searchId = Convert.ToInt32(textBoxCustomerSearch.Text.Trim());
                    DataRow drCustomer = dtCustomers.Rows.Find(searchId);
                    if (drCustomer != null) // found
                    {
                        //ListViewItem item = new ListViewItem(drCustomer["CustomerID"].ToString());
                        //item.SubItems.Add(drCustomer["Name"].ToString());
                        //item.SubItems.Add(drCustomer["City"].ToString());
                        //item.SubItems.Add(drCustomer["Street"].ToString());
                        //item.SubItems.Add(drCustomer["Postal_Code"].ToString());
                        //item.SubItems.Add(drCustomer["Phone_Number"].ToString());
                        //item.SubItems.Add(drCustomer["Fax_Number"].ToString());
                        //item.SubItems.Add(drCustomer["Credit.Limit"].ToString());
                        //listViewCustomers.Items.Add(item);
                        dataGridViewStudentDS.DataSource = dsHiTech.Tables["Customers"];

                    }
                    else
                    {
                        MessageBox.Show("Customer not found!", "Invalid Customer ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
            }

            
        }

        private void buttonCustomerListAll_Click(object sender, EventArgs e)
        {
            da.Fill(dsHiTech.Tables["Customers"]);
            dataGridViewStudentDS.DataSource = dsHiTech.Tables["Customers"];
        }

        private void buttonCustomerUpdate_Click(object sender, EventArgs e)
        {
            da.Update(dsHiTech.Tables["Customers"]);
            MessageBox.Show("Database has been updated sucessfully.", "Confirmation");
        }

        private void textBoxCustomerID_TextChanged(object sender, EventArgs e)
        {
            textBoxCustomerID.Text = "hi";
        }
    }
}
