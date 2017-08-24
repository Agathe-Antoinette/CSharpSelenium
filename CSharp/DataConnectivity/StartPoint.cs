using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataConnectivity
{
    class StartPoint
    {
        static void Main(string[] args)
        {
            using (var context = new DBContext())
            {
                if (!context.Bags.Any(b => b.Name == "Valentino"))
                {
                    var bag = new Bag();
                    bag.Name = "Valentino";
                    bag.Size = 4;
                    context.Bags.Add(bag);
                    context.SaveChanges();
                }

                var makeUpBag = context.Bags.Include(b => b.MakeUpItems).FirstOrDefault(b => b.Name == "Valentino");

                if (!context.MakeUpItems.Any())
                {
                    var foundation = new MakeUpItem {BagId = makeUpBag.Id, Price = 24.40M, Colour = "Ivory", IsWaterproof = true };
                    var blush = new MakeUpItem { BagId = makeUpBag.Id, Price = 100.00M, Colour = "Orgasm", IsWaterproof = false };
                    var mascara = new MakeUpItem { BagId = makeUpBag.Id, Price = 30.00M, Colour = "Black", IsWaterproof = false };
                    var lipstick = new MakeUpItem { BagId = makeUpBag.Id, Price = 40.00M, Colour = "Burgundy", IsWaterproof = true };
                    context.MakeUpItems.Add(foundation);
                    context.MakeUpItems.Add(blush);
                    context.MakeUpItems.Add(mascara);
                    context.MakeUpItems.Add(lipstick);
                    context.SaveChanges();
                }

                foreach (var makeup in makeUpBag.MakeUpItems)
                {
                    Console.WriteLine(makeup);
                }

                //TODO: Create DB with 2 classes and relation between them.
            }
        }
    }
}
