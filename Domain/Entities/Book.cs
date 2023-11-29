using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class Book
    {

        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public float Price { get; set; }

        public string Genre { get; set; }

        [ForeignKey("CustomerId")]
        public int CustomerId { get; set; }

        public Customer Customer { get; set; }

        [ForeignKey("AuthorId")]
        public int AuthorId { get; set; }

        public Author Author { get; set; }

    }
}
