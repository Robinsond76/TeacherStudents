using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public abstract class Person
    {
        [Required(ErrorMessage = "First name is a required field.")]
        [MaxLength(20, ErrorMessage = "Maximum length for First Name is 20 characters.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last name is a required field.")]
        [MaxLength(20, ErrorMessage = "Maximum length for Last Name is 20 characters.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Age is a required field.")]
        public int Age { get; set; }

    }
}
