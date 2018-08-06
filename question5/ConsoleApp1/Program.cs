using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int pin1 = 0;
            int pin2 = 0;
            Console.WriteLine("Enter a 4-digit PIN number.");
            int pin = int.Parse(Console.ReadLine());

            if (pin < 1000 || pin > 9999)
            {
                Console.WriteLine("This PIN number is not within the right parameters.");
                 pin1 = int.Parse(Console.ReadLine());

            }
            else 
            { 
                Console.WriteLine("Please re-enter a PIN");
                 pin2 = int.Parse(Console.ReadLine());
            }
            if (pin == pin2)
            {
                Console.WriteLine("Your PIN is set.");
                pin2 = int.Parse(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("Your PIN did not match.");
            }
        }
    }
}
