using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drob
{
    class Program
    {
        static void Main(string[] args)
        {
            Fraction f1 = new Fraction(1, 2);
            Fraction f2 = new Fraction(1, 2);
            Fraction actually = f1 + f2;
            Console.WriteLine(actually.ToString()  );
            Console.ReadKey();
        }
    }
}
