using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverFlow.DataBase.Users
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string UserName { get; set; }
        public string Password { get; set; }
        public string? FullName { get; set; }

        public string? Email { get; set; }

        public string? Address { get; set; }


        public int? RoleId { get; set; }
        public virtual Role? Role { get; set; }
    }
}
