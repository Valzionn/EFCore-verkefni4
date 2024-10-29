using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_verkefni4.Models
{
    public class Mark
    {
        [Key]
        public int MarkId { get; set; }

        [Required]
        public int StudentId { get; set; }

        [Required]
        public int SubjectId { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Range(0, 100)]
        public int Value { get; set; }  // Range constraint for a typical mark value

        [ForeignKey("StudentId")]
        public Student Student { get; set; }

        [ForeignKey("SubjectId")]
        public Subject Subject { get; set; }
    }

}
