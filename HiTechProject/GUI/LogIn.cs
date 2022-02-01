using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HiTechProject.DAL;
//using System.Data.SqlClient;
using HiTechProject.BLL;
using HiTechProject.GUI;
using SalesManagment.GUI;
//using OrderManagment_InventoryManagment_Entity.Models;
using OrderManagment.GUI;
using HiTechProject.Validation;
     





namespace HiTechProject.GUI
{
    public partial class LogIn : Form
    {
        
        public LogIn()
        {
            InitializeComponent();
        }
        
        private void buttonLogIn_Click(object sender, EventArgs e)
        {

            string id = textBoxLogInUserID.Text.Trim();
            string pass = textBoxLogInPassword.Text.Trim();
            HiTechProject.BLL.User us = new HiTechProject.BLL.User();
            
            if (!(Validator.IsValidId(id)) || !(Validator.IsEmpty(id)))
            {
                MessageBox.Show("wrong ID Format", "error");
                return;
            }
            if (!(Validator.IsEmpty(pass)))
            {
                MessageBox.Show("Please Enter a Password", "error");
                return;
            }
            us = us.CheckUser(Convert.ToInt32(id), pass);
            if (us != null)
            {

                switch (us.JobID)
                {
                    case 1:
                       Form1 frmMISManager = new Form1();

                        frmMISManager.ShowDialog();


                        this.Hide();
                        break;
                    case 2:
                        Sales frmSalesManger = new Sales();
                        frmSalesManger.ShowDialog();
                        this.Hide();
                        break;
                        // i tried so hard to connect my solution to the entity frame work project but i couldnt do it 
                        // i even deleted the whole project once, but still , i couldnt do it
                    case 3:
                        OrderClerk frm = new OrderClerk();
                        frm.ShowDialog();
                        this.Hide();


                        break;


                }


            }
            else if (us == null)
            {
                MessageBox.Show("User not found");
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult exit = MessageBox.Show("Do you really want to exit the application?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (exit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }
    }
}
