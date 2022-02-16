using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Solve solve = new Solve { k = Convert.ToDouble(Console.ReadLine()), b = Convert.ToDouble(Console.ReadLine())};
            solve.Root();
            Console.ReadKey();

        }

        struct Solve
        {
            public double k;
            public double b;
            public double x;
            
            public void Root()
            {
                x = -b / k;
                Console.WriteLine(x);
            }

        }
    }
}
