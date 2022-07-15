﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverFlow.DataBase.Blogs
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string MainComment { get; set; }

    }
}
