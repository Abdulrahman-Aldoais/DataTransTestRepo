using System.ComponentModel.DataAnnotations;

namespace DataTransTest.Domain.Entity
{
    public class Product
    {
        public int Id { get; set; }

        [MaxLength(100)]
        public string Name { get; set; } = "";

        public decimal Price { get; set; }

        public string Description { get; set; } = "";

        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
