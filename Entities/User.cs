using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public enum RoleType
    {
        USER,
        ADMIN
    }
    public class User:Person
    {
        [Required]
        public string Password { get; set; }
        [Phone]
        public string Phone { get; set; }
        [Required]
        public RoleType Role { get; set; } = RoleType.USER;
    }
}
