﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly1.Models;

using System.ComponentModel.DataAnnotations;

namespace Vidly1.Models
{
    public class Genre
    {
        public byte Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }
       
     
    }
}