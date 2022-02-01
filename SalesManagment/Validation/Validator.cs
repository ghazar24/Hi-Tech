using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace SalesManagment.Validation
{
    public static class Validator
    {
        public static bool IsValidPostal(string postal)
        {
            if (!(Regex.IsMatch(postal, @"^[a-zA-Z0-9_]+$")))
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
            if (!(Regex.IsMatch(input, @"\d{10}")))
            {
                return false;

            }

            return true;
        }
        public static bool IsValidName(string input)
        {
            
            if (!(Regex.IsMatch(input, @"^[a-zA-Z]+$")))
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
        public static bool IsValidstreet(string input)
        {

            if (!(Regex.IsMatch(input, @"^[a-zA-Z0-9]+$")))
            {
                return false;
            }
            return true;
        }
        
    }
}