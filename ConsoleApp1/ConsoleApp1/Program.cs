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
            int result;
            string a = Console.ReadLine();
            int b = Convert.ToInt32(a);
            if (b % 2 == 0)
            {
                result = b * b;
            }
            else
            {
                result = b * b * b;
            }
            Console.WriteLine(result.ToString());
            Console.ReadLine();
        }
        
    }
}
