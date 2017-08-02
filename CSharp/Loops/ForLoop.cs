using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    public static class ForLoop
    {
        public static void Execute(int length)
        {
            Console.WriteLine("For loop is executing!");
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine(i+1);
            }
        }
    }
}
