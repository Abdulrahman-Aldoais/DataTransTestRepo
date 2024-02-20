using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace DataTransTest.DTOs
{
    public class ProductDTOs
    {
        public int Id { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }

        [Precision(16, 2)]
        public decimal Price { get; set; }

        public string Description { get; set; }
    }
}
