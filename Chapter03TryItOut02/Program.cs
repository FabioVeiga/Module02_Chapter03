using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter03TryItOut02
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNumber, secondNumber;
            string userName;
            Console.Write("Enter your name: ");
            userName = Console.ReadLine();
            Console.WriteLine("Welcome {0}!", userName);
            Console.Write("Now give me a number: ");
            firstNumber = Convert.ToDouble(Console.ReadLine());
            Console.Write("Now give me another number: ");
            secondNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The sum of {0} and {1} is {2}.", firstNumber, secondNumber, firstNumber + secondNumber);
            Console.WriteLine("The result of substracting {0} and {1} is {2}.", firstNumber, secondNumber, firstNumber - secondNumber);
            Console.WriteLine("The the product of {0} and {1} is {2}.", firstNumber, secondNumber, firstNumber * secondNumber);
            Console.WriteLine("The result of dividing {0} and {1} is {2}.", firstNumber, secondNumber, firstNumber / secondNumber);
            Console.WriteLine("The remainder after {0} by {1} is {2}.", firstNumber, secondNumber, firstNumber % secondNumber);
            Console.ReadKey();
        }
    }
}
