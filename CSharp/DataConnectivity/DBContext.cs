namespace DataConnectivity
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Data.Entity;
    using System.Linq;

    public class DBContext : DbContext
    {
        // Your context has been configured to use a 'DBContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'DataConnectivity.DBContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'DBContext' 
        // connection string in the application configuration file.
        public DBContext()
            : base("name=DBContext")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Bag> Bags { get; set; }
        public virtual DbSet<MakeUpItem> MakeUpItems { get; set; }
    }

    public class Bag
    {
        public Bag()
        {
            this.MakeUpItems = new List<MakeUpItem>();
        }

        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        [Range(1,4)]
        public int Size { get; set; }

        public virtual ICollection<MakeUpItem> MakeUpItems { get; set; }
    }

    public class MakeUpItem
    {
        [Key]
        public int Id { get; set; }

        public int BagId { get; set; }

        public Bag Bag { get; set; }

        public decimal Price { get; set; }

        public bool IsWaterproof { get; set; }

        public string Colour { get; set; }

        public override string ToString()
        {
            var oldStringInterpolation = string.Format("Article {0} has price {1} and has colour {2} and {3} waterproof.",
                this.Id, this.Price, this.Colour, this.IsWaterproof ? "is" : "is not");

            string isWaterproof = this.IsWaterproof ? "is" : "is not";
            var newStringInterpolation = $"Article {this.Id} has price {this.Price} and has colour {this.Colour} and {isWaterproof} waterproof.";

            return oldStringInterpolation;
        }
    }
}