namespace PetBlazor.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int Count { get; set; }
        public int CategoryId { get; set; }
        public int ManufacturerId { get; set; }
        public Category? Category { get; set; }
        public Manufacturer? Manufacturer { get; set; }
        public List<Bucket> Buckets { get; set; }
    }
}
