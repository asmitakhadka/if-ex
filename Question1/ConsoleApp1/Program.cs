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
            Console.WriteLine("Please enter a number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter another number");
            int num2 = int.Parse(Console.ReadLine());

           
       
            if (num1 > num2)
            Console.WriteLine("num1 is larger.");

            else if (num2 > num1>
            Console.WriteLine("num2 is larger");
            
            
            if (num1 == num2)
            Console.WriteLine("The both the numbers are equal.");
           
        }
    }
}
