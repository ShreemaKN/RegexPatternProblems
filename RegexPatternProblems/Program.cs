// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegexPatternProblems;

class Program
{

    static void Main(string[] args)
    {
        Console.WriteLine("User Registration Validating using regular expression!");
        RegexPattern regexPattern = new RegexPattern();
        regexPattern.Validating();

    }
}

