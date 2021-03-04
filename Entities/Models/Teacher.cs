using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Teacher : Person
    {
        [Column("TeacherId")]
        public Guid Id { get; set; }

        public ICollection<Student> Students { get; set; }
    }
}
