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
            int t, a, b;
            t = Convert.ToInt16(Console.ReadLine());
            while (t-- > 0)
            {
                a = Convert.ToInt16(Console.ReadLine());
                b = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine((a + b));
            }
            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
