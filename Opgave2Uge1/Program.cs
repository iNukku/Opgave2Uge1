using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave2Uge1
{
    class Program
    {
        static void Main(string[] args)
        {
            string a;
            string b;
            bool c = false;

            Console.WriteLine("Enter first text");
            a = Console.ReadLine();
            Console.WriteLine("Ok now for second text");
            b = Console.ReadLine();

            Comparisson x = new Comparisson(a, b);
            c = x.compair();

            Console.WriteLine("The texts are acronyms: " + c.ToString());

            Console.ReadLine();
            
        }
    }
}
