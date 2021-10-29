﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SportStore.Models.Dtos
{
    public class UserAddDTO
    {
        [Required]
        [StringLength(150)]
        public String Username { get; set; }

        [Required]
        [EmailAddress]
        [StringLength(150)]
        public String Email { get; set; }

        [Required]
        [StringLength(20)]
        public String Password { get; set; }
    }
}
