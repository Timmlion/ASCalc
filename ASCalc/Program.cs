using System;
using System.Text.RegularExpressions;

namespace ASCalc
{
    class Program
    {
        static void Main(string[] args)
        {            
            while (true)
            {
                Console.WriteLine("Input expression:");
                string inputStr = Console.ReadLine();

                var regex = new Regex(@"^(?:[0-9](?!\d))+(?:[\+\-\*\/]\d){1,}$");
                if (regex.Match(inputStr).Success)
                {
                    Calculator calc = new Calculator();
                    Console.Write("Result: ");
                    Console.WriteLine(calc.Calculate(inputStr));                    
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid expression");                   
                }
            }
            Console.ReadKey();
        }
    }
}
