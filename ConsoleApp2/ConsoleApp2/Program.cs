using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string incomestr = Console.ReadLine();
            string daysstr = Console.ReadLine();
            int inc = Convert.ToInt32(incomestr);
            int days = Convert.ToInt32(daysstr);
            int brt = inc * days;
            int prc;
            if (brt >= 1000)
            {
                prc = brt * 18/100;
            }
            else
            {
                prc = brt * 4/100;
            }
            var netinc = brt - prc;
            Console.WriteLine(prc.ToString());
            Console.WriteLine(netinc.ToString());
            Console.ReadLine();
        }
    }
}
