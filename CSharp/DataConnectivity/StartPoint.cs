using Dapper;
using System;
using System.Configuration;
using System.Data.Entity;
using System.Data.OleDb;
using System.Linq;

namespace DataConnectivity
{
    class StartPoint
    {
        static void Main(string[] args)
        {
            UsingDatabase();
            Console.WriteLine();
            UsingDapper();
        }

        private static void UsingDapper()
        {
            var dataSourcePath = ConfigurationManager.AppSettings["DataSourcePath"];

            var connectionString = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={dataSourcePath};Extended Properties=\"Excel 12.0 Xml;HDR=Yes;IMEX=1;\"";

            using (var connection = new OleDbConnection(connectionString))
            {
                var bag = connection.Query<Bag>("select * from [Bag$]");
            }

            using (var connection = new OleDbConnection(connectionString))
            {
                var makeUpItems = connection.Query<MakeUp>("select * from [MakeUp$]");

                foreach (var makeUp in makeUpItems)
                {
                    Console.WriteLine(makeUp);
                }
            }
        }

        private static void UsingDatabase()
        {
            using (var context = new ShopContext())
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
                    var foundation = new MakeUp { BagId = makeUpBag.Id, Price = 24.40M, Colour = "Ivory", IsWaterproof = true };
                    var blush = new MakeUp { BagId = makeUpBag.Id, Price = 100.00M, Colour = "Orgasm", IsWaterproof = false };
                    var mascara = new MakeUp { BagId = makeUpBag.Id, Price = 30.00M, Colour = "Black", IsWaterproof = false };
                    var lipstick = new MakeUp { BagId = makeUpBag.Id, Price = 40.00M, Colour = "Burgundy", IsWaterproof = true };
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
