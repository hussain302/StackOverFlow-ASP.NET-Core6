using StackOverFlow.DataBase.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverFlow.DataBase.Blogs
{
    public class Blog
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public string Title { get; set; }

        [Required]
        public string? Description { get; set; }

        public string? ImageURL { get; set; }


        public int? CategoryId { get; set; }
        public virtual Category? Category { get; set; }


        public int? UserId { get; set; }
        public virtual User? User { get; set; }

        public int? CommentId { get; set; }
        public virtual Comment? Comment { get; set; }

    }
}
