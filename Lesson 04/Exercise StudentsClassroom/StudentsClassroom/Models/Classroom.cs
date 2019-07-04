using System.Collections.Generic;

namespace StudentsClassroom.Models
{
    public class ClassRoom
    {
        public IList<Student> Students { get; set; }
                            = new List<Student>();
    }

}