using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class QueringLINQ
    {
        static void Main(string[] args)
        {
            var makeUpBag = new List<MakeUp>();
            var foundation = new MakeUp { Id = 101, Price = 24.40M, Type = MakeUpType.Foundation, Colour = "Ivory", IsWaterproof = true };
            makeUpBag.Add(foundation);
            var blush = new MakeUp { Id = 102, Price = 100.00M, Type = MakeUpType.Blush, Colour = "Orgasm", IsWaterproof = false };
            makeUpBag.Add(blush);
            var mascara = new MakeUp { Id = 103, Price = 30.00M, Type = MakeUpType.Mascara, Colour = "Black", IsWaterproof = false };
            makeUpBag.Add(mascara);
            var lipstick = new MakeUp { Id = 104, Price = 40.00M, Type = MakeUpType.Lipstick, Colour = "Burgundy", IsWaterproof = true };
            makeUpBag.Add(lipstick);


            foreach (var makeUp in makeUpBag)
            {
                makeUp.ApplyDiscount(70M);
                Console.WriteLine(makeUp);
            }

            Console.WriteLine();

            var myBlush = makeUpBag.FirstOrDefault(mu => mu.Colour == "Orgasm");
            myBlush.ApplyDiscount(5);

            Console.WriteLine(myBlush);

            var allLipstickPrices = makeUpBag.Where(mu => mu.Type == MakeUpType.Lipstick).Select(mu => mu.Price);

            //var allLipstickPricesOld = new List<decimal>();
            //foreach (var makeUp in makeUpBag)
            //{
            //    if (makeUp.Type == MakeUpType.Lipstick)
            //    {
            //        allLipstickPricesOld.Add(makeUp.Price);
            //    }
            //}

            Console.WriteLine(string.Join(", ", allLipstickPrices));

            var basicMakeUp = makeUpBag.Where(mu => mu.Type == MakeUpType.Foundation || mu.Type == MakeUpType.Mascara).Select(mu => mu.Price).Sum();
            Console.WriteLine(basicMakeUp);

            var waterproofColours = makeUpBag.Where(mu => mu.IsWaterproof).Select(mu => mu.Colour);
            Console.WriteLine(string.Join(", ", waterproofColours));

            var nonWaterproofPrice = makeUpBag.Where(mu => !mu.IsWaterproof).Select(mu => mu.Price).Where(p => p > 20);
            Console.WriteLine(string.Join(", ", nonWaterproofPrice));

            var nonWaterproofPriceSecond = makeUpBag.Where(mu => !mu.IsWaterproof && mu.Price > 20).Select(mu => mu.Price);
            Console.WriteLine(string.Join(", ", nonWaterproofPriceSecond));

            var sortByPrice = makeUpBag.OrderBy(mu => mu.Price);

            foreach (var makeUp in sortByPrice)
            {
                Console.WriteLine(makeUp);
            }

            Console.WriteLine();
            var sortByPriceDescendindAndId = makeUpBag.OrderByDescending(mu => mu.Price).ThenBy(mu => mu.Id);
            foreach (var makeUp in sortByPriceDescendindAndId)
            {
                Console.WriteLine(makeUp);
            }

            //TODO: Problem from slide 22

            var makeUpWithPriceAbove = makeUpBag.FirstOrDefault(mu => mu.Price < 100);
            Console.WriteLine(makeUpWithPriceAbove.Price);
        }
    }
}
