using System.ComponentModel.DataAnnotations;

namespace StudentsClassroom.Models
{
    public class Student
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [RegularExpression("^[A-Z][a-z]+$")]
        public string FirstName { get; set; }

        [Required]
        [RegularExpression("^[A-Z][a-z]+$")]
        public string LastName { get; set; }
    }

}