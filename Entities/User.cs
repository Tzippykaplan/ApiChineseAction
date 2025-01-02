using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class User:Person
    {
        [Required]
        public string Password { get; set; }
        [Phone]
        public string Phone { get; set; }
    }
}
