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
            int i;
            Console.WriteLine("Please enter your final mark. ");
            i = int.Parse(Console.ReadLine());

            if (i <= 90)
            {
                Console.WriteLine("Your grade is A+");

            }
            else if (i >= 80 || i <= 89)
            {
                Console.WriteLine("Your grade is A");

            }
            else if (i >= 70 || i <= 79)
            {
                Console.WriteLine("Your grade is B+");

            }
            else if (i >= 60 || i <= 69)
            {
                Console.WriteLine("Your grade is B");

            }
            else if (i >= 50 || i <= 59)
            {
                Console.WriteLine("Your grade is C");

            }
            else if (i >= 40 || i <= 49)
            {
                Console.WriteLine("Your grade id D");

            }
            else if (i < 50)
            {
                Console.WriteLine("Your grade is F");
            }
               
            }
        }
    }
}
