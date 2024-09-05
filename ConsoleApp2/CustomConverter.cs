using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class CustomConverter
    {


        public void Convert(string input, out int result)
        {
            if (!int.TryParse(input, out result))
            {
                result = 0;
                Console.WriteLine($"Cannot convert '{input}' to int.");
            }
        }


        public void Convert(string input, out double result)
        {
            if (!double.TryParse(input, out result))
            {
                result = 0.0;
                Console.WriteLine($"Cannot convert '{input}' to double.");
            }
        }
    }
}

