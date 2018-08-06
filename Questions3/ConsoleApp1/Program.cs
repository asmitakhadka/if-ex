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
            Console.WriteLine("Please enter your final mark. ");
            int i = int.Parse(Console.ReadLine());

            if (i <= 90)
            {
                Console.WriteLine("Your grade is A+");
                int num = Convert.ToInt32(Console.ReadLine());
            }
            else if(i >= 80 || i < 90)
            {
                Console.WriteLine("Your grade is A");
                int num = Convert.ToInt32(Console.ReadLine());

            }
            else if (i >= 70 || i < 80)
            {
                Console.WriteLine("Your grade is B+");
               

            }
            else if (i >= 60 || i < 70)
            {
                Console.WriteLine("Your grade is B");
          

            }
            else if (i >= 50 || i < 60)
            {
                Console.WriteLine("Your grade is C");
                

            }
            else if (i < 50)
            {
                Console.WriteLine("Your grade is F");
               
            }
        }
    }
}
