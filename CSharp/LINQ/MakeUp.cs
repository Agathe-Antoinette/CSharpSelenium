using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public class MakeUp : IDiscountable
    {
        public int Id { get; set; }

        public decimal Price { get; set; }

        public MakeUpType Type { get; set; }

        public bool IsWaterproof { get; set; }

        public string Colour { get; set; }

        public void ApplyDiscount(decimal percent)
        {
            this.Price = this.Price - this.Price * percent / 100;
        }

        public override string ToString()
        {
            var oldStringInterpolation = string.Format("Article {0} with type {1} has price {2} and has colour {3} and {4} waterproof.",
                this.Id, this.Type, this.Price, this.Colour, this.IsWaterproof ? "is" : "is not");

            string isWaterproof = this.IsWaterproof ? "is" : "is not";
            var newStringInterpolation = $"Article {this.Id} with type {this.Type} has price {this.Price} and has colour {this.Colour} and {isWaterproof} waterproof.";

            return oldStringInterpolation;
        }
    }
}
