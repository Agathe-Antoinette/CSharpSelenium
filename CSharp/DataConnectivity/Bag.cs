namespace DataConnectivity
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Bag
    {
        public Bag()
        {
            this.MakeUpItems = new List<MakeUp>();
        }

        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        [Range(1, 4)]
        public int Size { get; set; }

        public virtual ICollection<MakeUp> MakeUpItems { get; set; }
    }
}