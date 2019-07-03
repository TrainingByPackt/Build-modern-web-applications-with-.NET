using System.ComponentModel.DataAnnotations;

namespace AddressBook.Models
{
    public class ContactDetails
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public ContactDetailsType ContactDetailsType { get; set; }

        [Required]
        [MaxLength(25)]
        public string Details { get; set; }
    }
}