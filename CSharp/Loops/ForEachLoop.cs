using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    public static class ForEachLoop
    {
        public static void Execute(IEnumerable<int> list)
        {
            Console.WriteLine("ForEach Loop is executing!");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
