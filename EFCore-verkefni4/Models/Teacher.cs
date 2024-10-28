using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_verkefni4.Models
{
    public class Teacher
    {
        public int TeacherId { get; set; }
        public int Category { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public ICollection<SubjectTeacher> SubjectTeachers { get; set; }
    }
}
