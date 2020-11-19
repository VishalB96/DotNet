﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_practice01.Models
{
    public class Employee
    {
        [Required]
        [Display(Name = "Employee ID")]
        public int Id { get; set; }
        [Required(ErrorMessage = "Pl Enter----Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Pl Enter---Gender")]
        public string Gender { get; set; }
        [Required]
        public string City { get; set; }
    }
}