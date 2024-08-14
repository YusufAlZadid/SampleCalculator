using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputValidationLibrary
{
    public static class Validator
    {
        // Method to validate if the input is a valid integer
        public static bool IsValidInteger(string input, out int result)
        {
            return int.TryParse(input, out result);
        }

        // Method to validate if the input is a valid double
        public static bool IsValidDouble(string input, out double result)
        {
            return double.TryParse(input, out result);
        }

        // Method to validate if the input is a non-empty string
        public static bool IsValidString(string input)
        {
            return !string.IsNullOrWhiteSpace(input);
        }
    }
}
