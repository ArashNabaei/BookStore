
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Publisher
    {

        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Address { get; set; }

        public string Information { get; set; }

    }
}
