using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercise1.Types;

namespace Exercise1
{
    class CSharpTypes
    {
        static void Main(string[] args)
        {
            int number = 5;
            int numberTwo;
            int numberTree = default(int);
            var numberFour = default(int);
            decimal money = 100.5M;
            var moneyTwo = 100.5M;

            string text = "Hello";
            Money myMoney = new Money(money);
            String textTwo = "Hello";
            var moneyTwoType = moneyTwo.GetType();
            bool isEqual = 10 == 10;

            //Console.WriteLine(myMoney.Value);

            //if (isEqual)
            //{
            //    Console.WriteLine(true);
            //}

            decimal result = CalculateArea(money, moneyTwo);

            Console.WriteLine(result);
        }
        private static decimal CalculateArea(decimal a, decimal b)
        {
            decimal result = a * b;

            return result;
        }
    }
}
