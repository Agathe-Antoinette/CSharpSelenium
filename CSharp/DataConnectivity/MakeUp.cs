namespace DataConnectivity
{
    using System.ComponentModel.DataAnnotations;

    public class MakeUp
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