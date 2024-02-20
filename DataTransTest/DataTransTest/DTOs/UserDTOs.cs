using System.ComponentModel.DataAnnotations;

namespace DataTransTest.DTOs
{
    public class UserDTOs
    {
        public int Id { get; set; }
        [Required, MaxLength(100)]
        public string FirstName { get; set; } = "";

        [Required, MaxLength(100)]
        public string LastName { get; set; } = "";

        [MaxLength(20)]
        public string? Phone { get; set; }

        [Required, MaxLength(100)]
        public string Address { get; set; } = "";
        public string Email { get; set; }

    }
}
