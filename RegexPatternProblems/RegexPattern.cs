using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexPatternProblems
{
    internal class RegexPattern
    {
        string pattern = "^[A-Za-z]{3,}$";

        public void Validating()
        {
            Regex regex = new Regex(pattern);
            Console.WriteLine("Validating the first name");
            ValidatingFirstName();
        }

        public void ValidatingFirstName()
        {
            Regex Regex = new Regex(pattern);
            Console.WriteLine("Enter the first name:");
            string input = Console.ReadLine();
            bool res = Regex.IsMatch(input);
            if(res)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}
