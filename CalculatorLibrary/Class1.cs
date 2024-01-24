using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary
{
    public class Class1
    {
        public static class CalculatorValidator
        {
            public static bool ValidateNumber(string input)
            {
                return double.TryParse(input, out _);
            }

        }
    }
}
