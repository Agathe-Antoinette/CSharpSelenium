using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleArea
{
    class RectangleAreaStart
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, write the value of the side a of a rectangle.");
            var a = double.Parse(Console.ReadLine());
            Console.WriteLine("Please, write the value of the side b of a rectangle.");
            var b = double.Parse(Console.ReadLine());

            double rectangleArea = a * b;

            Console.WriteLine("The area of requested rectangle is {0}.", rectangleArea);
        }
    }
}
