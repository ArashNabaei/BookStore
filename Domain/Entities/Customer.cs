using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Customer
    {

        [Key]
        public int Id { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

        
        public float Balance { get; set; }

        public int Orders { get; set; }

        public List<Book> Books { get; set; } = new List<Book>();

    }
}
