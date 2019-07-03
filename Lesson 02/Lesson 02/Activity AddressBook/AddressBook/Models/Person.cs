using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AddressBook.Models
{
    public class Person
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [RegularExpression("^[A-Z][a-z]+$")]
        public string LastName { get; set; }

        [Required]
        [RegularExpression("^[A-Z][a-z]+$")]
        public string FirstName { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
        
        [Required]
        public Address Address { get; set; }

        [Required]
        public IEnumerable<ContactDetails> ContactDetails { get; set; }
    }
}