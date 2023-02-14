namespace APISample.Domain.Models
{
    internal class Product
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public decimal Cost { get; set; }

        public bool Available
        {
            get
            {
                return Stock > 0;
            }
        }

        public int Stock { get; set; }

        public bool IsPublished { get; set; }
    }
}
