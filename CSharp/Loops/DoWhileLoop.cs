using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    public static class DoWhileLoop
    {
        public static void Execute(int length)
        {
            Console.WriteLine("DoWhile Loop is executing!");
            do
            {
                length++;
                Console.WriteLine(length);
            } while (length < 10);
        }
    }
}
