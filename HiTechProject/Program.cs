using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using HiTechProject.GUI;
//using OrderManagment.GUI;



namespace HiTechProject
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LogIn());
            //Application.Run(new Form1());
            //Application.Run(new Inventory_Conroller());

        }
    }
}
