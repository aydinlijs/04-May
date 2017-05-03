using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            string visastr = Console.ReadLine();
            string finalstr = Console.ReadLine();
            int visa = Convert.ToInt32(visastr);
            int final = Convert.ToInt32(finalstr);
            int result = visa * 4 / 10 + final * 6 / 10;
            if (result <= 45)
            {
                Console.WriteLine("You've got an F :( ");
            }
            else if (result>=46 && result <= 60)
            {
                Console.WriteLine("You've got a D, you can do better ;) ");
            }
            else if (result>=61 && result <= 75)
            {
                Console.WriteLine("You've got yourself a C, not bad :) ");
            }
            else if (result>=76 && result <= 90)
            {
                Console.WriteLine("You've got yourself a B, good job!");
            }
            else
            {
                Console.WriteLine("You've got an A, what a success! Congratulations!");
            }
            Console.ReadLine();
        }
    }
}
