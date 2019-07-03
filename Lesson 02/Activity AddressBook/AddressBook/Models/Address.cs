using System.ComponentModel.DataAnnotations;

namespace AddressBook.Models
{
    public class Address
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string FirstLine { get; set; }
        
        public string SecondLine { get; set; }

        [Required]
        [MaxLength(10)]
        public string PostCode { get; set; }

        [Required]
        [MaxLength(25)]
        public string City { get; set; }

        [Required]
        [MaxLength(56)]
        public string Country { get; set; }
    }
}