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
            if (result > 45)
            {
                Console.WriteLine("You passed!");
            }
            else
            {
                Console.WriteLine("You failed :( ");
            }
            Console.ReadLine();
        }
    }
}
