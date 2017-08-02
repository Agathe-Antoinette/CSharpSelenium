using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    public static class WhileLoop
    {
        public static void Execute(int length)
        {
            Console.WriteLine("While Loop is executing!");

            while (length < 10)
            {
                length++;
                Console.WriteLine(length);
            }
        }
    }
}
