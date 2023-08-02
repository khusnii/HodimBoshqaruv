﻿using System.ComponentModel.DataAnnotations;

namespace HodimBoshqaruv.Models
{
    public class Staff
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "First Name")]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        [MaxLength(50)]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Email")]
        [RegularExpression("^\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*$", ErrorMessage ="Email is not valid.")]
        public string  Email { get; set; }

        [Required]
        [Display(Name = "Deparments")]
        public Departments? Department { get; set; }
    }
}
