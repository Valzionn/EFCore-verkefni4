using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_verkefni4.Models
{
    public class Subject
    {
        [Key]
        public int SubjectId { get; set; }

        [Required]
        public string Title { get; set; }

        public ICollection<SubjectTeacher> SubjectTeachers { get; set; } = new List<SubjectTeacher>();
    }
}
