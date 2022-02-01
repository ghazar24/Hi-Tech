using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace OrderManagment_InventoryManagment_Entity.Validation
{
    public static class Validator
    {
        public static bool IsValidEmail(string Email)
        {
            if (!(Regex.IsMatch(Email, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$")))
            {
                return false;
            }
            return true;
        }
        public static bool IsValidId(string input)
        {
            if (!(Regex.IsMatch(input, @"^[0-9]")))
            {
                return false;
                
            }

            return true;
        }
        public static bool IsValidPhone(string input)
        {
            if (!(Regex.IsMatch(input, @"^\d{10}$")))
            {
                return false;

            }

            return true;
        }
        public static bool IsValidName(string input)
        {
            if (input.Length == 0)
            {
                return false;
            }
            return true;
        }
        public static bool IsEmpty(string input)
        {
            if (input.Length == 0)
            {
                return false;
            }

            return true;
        }
    }
}