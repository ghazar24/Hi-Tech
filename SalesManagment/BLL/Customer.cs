using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagment.BLL
{
    public class Customer
    {
            private int customerID;
            private string name;
            private string street;
            private string city;
            private string postal_Code;
            private string phone_Number;
            private string fax_Number;
            private int credit_Limit;

        public int CustomerID { get => customerID; set => customerID = value; }
        public string Name { get => name; set => name = value; }
        public string Street { get => street; set => street = value; }
        public string City { get => city; set => city = value; }
        public string Postal_Code { get => postal_Code; set => postal_Code = value; }
        public string Phone_Number { get => phone_Number; set => phone_Number = value; }
        public string Fax_Number { get => fax_Number; set => fax_Number = value; }
        public int Credit_Limit { get => credit_Limit; set => credit_Limit = value; }
    }
}
