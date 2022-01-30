using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;
            int result = 0;

            Console.WriteLine("Enter first number: ");
            string sNum1 = Console.ReadLine();

            Console.WriteLine("Enter second number: ");
            string sNum2 = Console.ReadLine();

            Int32.TryParse(sNum1, out num1);
            Int32.TryParse(sNum2, out num2);

            result = num1 + num2;
            Console.WriteLine("Result: " + result);
            Console.ReadLine();
        }
    }
}
