using System.ComponentModel.DataAnnotations;

namespace AddressBook.Models
{
    public class ContactDetailsType
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string Detail { get; set; }
    }
}