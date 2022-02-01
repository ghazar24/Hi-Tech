using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrderManagment_InventoryManagment_Entity.Models;

namespace OrderManagment.GUI
{
    
    public partial class OrderClerk : Form
    {
        Hi_TechDBEntities1 dBEntities = new Hi_TechDBEntities1();
        public OrderClerk()
        {
            InitializeComponent();
        }

        private void OrderClerk_Load(object sender, EventArgs e)
        {
            var listbkID = (from b in dBEntities.Books
                            select b).ToList<Book>();
            foreach (Book bk in listbkID)
            {
                comboBoxOrderISBN.DisplayMember = "Title";
                comboBoxOrderISBN.ValueMember = "ISBN";
                comboBoxOrderISBN.DataSource = listbkID;
            }
            var listcst = (from c in dBEntities.Customers
                             select c).ToList<Customer>();
            foreach (Customer cst in listcst)
            {
                comboBoxOrderCustomerID.DisplayMember = "Name";
                comboBoxOrderCustomerID.ValueMember = "CustomerID";
                comboBoxOrderCustomerID.DataSource = listcst;
            }
            // this code here is becasue i couldn't link my solution to Orders Project
            // otherwise i could have put the id of loged in user
            var listusr = (from u in dBEntities.Users
                           select u).ToList<User>();
            foreach (User cst in listusr)
            {
                comboBoxOrderUserID.DisplayMember = "First_Name";
                comboBoxOrderUserID.ValueMember = "UserID";
                comboBoxOrderUserID.DataSource = listusr;
            }

        }

        private void checkBoxOrderSearch_CheckedChanged(object sender, EventArgs e)
        {
            textBoxOrderID.ReadOnly = false;
            checkBoxOrderCancel.Checked=false;
            checkBoxOrderUpdate.Checked = false;
            
        }

        private void checkBoxOrderCancel_CheckedChanged(object sender, EventArgs e)
        {
            textBoxOrderID.ReadOnly = false;
            checkBoxOrderSearch.Checked = false;
            checkBoxOrderUpdate.Checked = false;
            
        }

        private void checkBoxOrderUpdate_CheckedChanged(object sender, EventArgs e)
        {
            textBoxOrderID.ReadOnly = false;
            checkBoxOrderCancel.Checked = false;
            checkBoxOrderSearch.Checked = false;
            
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (checkBoxOrderSearch.Checked)
            {
                int orderid = Convert.ToInt32(textBoxOrderID.Text.Trim());
                var searchOrderid = (from o in dBEntities.Orders
                                    where o.OrderID == orderid
                                     select o).FirstOrDefault();
                if (searchOrderid != null)
                {
                    listViewOrders.Items.Clear();
                    ListViewItem item = new ListViewItem(searchOrderid.OrderID.ToString());

                    item.SubItems.Add(searchOrderid.ISBN);
                    item.SubItems.Add(searchOrderid.CustomerID.ToString());
                    item.SubItems.Add(searchOrderid.UserID.ToString());
                    item.SubItems.Add(searchOrderid.Order_Date.ToString());
                    item.SubItems.Add(searchOrderid.Quantity.ToString());

                    listViewOrders.Items.Add(item);
                }
                else
                {
                    MessageBox.Show("No Order with that ID!", "Error");
                }
           
            }
            else if (checkBoxOrderUpdate.Checked)
            {
                int orderid = Convert.ToInt32(textBoxOrderID.Text.Trim());
                var update = (from o in dBEntities.Orders
                              where o.OrderID == orderid
                              select o).FirstOrDefault();
                if (update != null)
                {
                    comboBoxOrderISBN.Focus();
                    update.ISBN = comboBoxOrderISBN.SelectedValue.ToString();
                    update.CustomerID = Convert.ToInt32(comboBoxOrderCustomerID.SelectedValue);
                    update.UserID = Convert.ToInt32(comboBoxOrderUserID.SelectedValue);
                    update.Order_Date = Convert.ToDateTime(maskedTextBoxOrderDate.Text.Trim());
                    update.Quantity = Convert.ToInt32(textBoxOrderQuantity.Text.Trim());
                    dBEntities.SaveChangesAsync();
                    MessageBox.Show("Order Succesfuly Updated!", "Confirm");
                }
                else
                {
                    MessageBox.Show("Wrong Order ID Number!", "Error");
                }
            }
            else
            {
                DialogResult answer = MessageBox.Show("Do really want to delete this Author?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (answer == DialogResult.Yes)
                {
                    int orderid = Convert.ToInt32(textBoxOrderID.Text.Trim());
                    var delete = (from o in dBEntities.Orders
                                  where o.OrderID == orderid
                                  select o).FirstOrDefault();
                    if (delete != null)
                    {

                        dBEntities.Orders.Remove(delete);
                        dBEntities.SaveChanges();
                        MessageBox.Show("Order Succesfuly Cancelled!", "Confirm");
                    }
                    else
                    {
                        MessageBox.Show("Wrong Order ID or Order already Deleted", "No Order");
                    }
                }
                else
                {
                    textBoxOrderID.Text = string.Empty;
                    return;
                }
            }
        }

        private void buttonOrderCreat_Click(object sender, EventArgs e)
        {
            if (comboBoxOrderISBN.SelectedIndex == -1)
            {
                MessageBox.Show("Please select the Book", "Error");
                return;

            }
            else if (comboBoxOrderCustomerID.SelectedIndex == -1)
            {
                MessageBox.Show("Please select the Customer");
                return;
            }
            else if (comboBoxOrderUserID.SelectedIndex == -1)
            {
                MessageBox.Show("Please select the User", "Error");
                return;
            }
            else {
                
                    Order order = new Order();
                    order.ISBN = comboBoxOrderISBN.SelectedValue.ToString();
                    order.CustomerID = Convert.ToInt32(comboBoxOrderCustomerID.SelectedValue);
                    order.UserID = Convert.ToInt32(comboBoxOrderUserID.SelectedValue);
                    order.Order_Date = Convert.ToDateTime(maskedTextBoxOrderDate.Text.Trim());
                    order.Quantity = Convert.ToInt32(textBoxOrderQuantity.Text.Trim());
                
                
                    dBEntities.Orders.Add(order);
                    dBEntities.SaveChanges();
                    MessageBox.Show("Order Successfuly Places", "Confirm");
                
                
            }
        }

        private void buttonOrderListAll_Click(object sender, EventArgs e)
        {
            listViewOrders.Items.Clear();
            var listorder = dBEntities.Orders.ToList();
            
            if (listorder.Count != 0)
            {
                foreach (var ord in listorder)
                {
                    ListViewItem item = new ListViewItem(ord.OrderID.ToString());

                    item.SubItems.Add(ord.ISBN);
                    item.SubItems.Add(ord.CustomerID.ToString());
                    item.SubItems.Add(ord.UserID.ToString());
                    item.SubItems.Add(ord.Order_Date.ToString());
                    item.SubItems.Add(ord.Quantity.ToString());

                    listViewOrders.Items.Add(item);
                }

            }
            else
            {
                MessageBox.Show("No Orders", "Order List!");
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
    }
}
