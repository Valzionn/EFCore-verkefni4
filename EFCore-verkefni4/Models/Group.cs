using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_verkefni4.Models
{
    public class Group
    {
        public int GroupId { get; set; }
        public string Name { get; set; }

        public ICollection<Student> Students { get; set; }
    }

}
