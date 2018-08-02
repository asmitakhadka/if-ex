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
            Random random = new Random();
            int myNum = random.Next(1, 10);
            
            Console.WriteLine("Guess the number between 1 to 10");
            int userNum = int.Parse(Console.ReadLine());

            if (userNum == myNum)
                Console.WriteLine("Your guess is right.");

            else
                Console.WriteLine("Your guess is wrong");
               
        }
    }
}
