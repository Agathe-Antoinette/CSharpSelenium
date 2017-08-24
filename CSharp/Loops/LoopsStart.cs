using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class LoopsStart
    {
        static void Main(string[] args)
        {
            int number = 5;
            ForLoop.Execute(number);
            WhileLoop.Execute(number);
            DoWhileLoop.Execute(number);

            var list = new List<int>() { 1, 7, 43, 59 };
            var arr = new int[] { 77, 310, 11, 76 };
            var dict = new Dictionary<int, string>();
            dict[66] = "Sofia";
            dict[75] = "Plovdiv";
            dict[91] = "Varna";
            ForEachLoop.Execute(arr);
            ForEachLoop.Execute(list);
            ForEachLoop.Execute(dict.Keys);
            ForEachLoop.Execute(dict.Values);
        }
    }
}
