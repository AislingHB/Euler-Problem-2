using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler_Problem_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = 0;
            int second = 1;
            int current = 0;
            int total = 0;

            do
            {
                if(current%2 == 0)
                    total += current;

                first = second;
                second = current;
                current = first + second;
            }
            while (current < 4000000);

            Console.WriteLine(total);
            Console.ReadLine();
        }
    }
}
