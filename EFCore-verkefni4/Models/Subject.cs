using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_verkefni4.Models
{
    public class Subject
    {
        public int SubjectId { get; set; }
        public string Title { get; set; }

        public ICollection<SubjectTeacher> SubjectTeachers { get; set; }
    }
}
