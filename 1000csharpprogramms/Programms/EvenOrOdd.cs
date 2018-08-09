using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1000csharpprogramms.Programms
{
    class EvenOrOdd
    {
        public void EvenOdd(int num)
        {
            if(num % 2 == 0)
            {
                Console.Write("Entered number is even.");
                Console.ReadKey();
            }
            else
            {
                Console.Write("Entered number od odd.");
                Console.ReadKey();
            }
        }
    }
}
