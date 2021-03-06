﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Limak.Areas.Admin.ViewModels
{
    public class AdminsAddAdminViewModel
    {
        [Required(ErrorMessage = "Mütləqdir")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Mütləqdir")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Mütləqdir")]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = "Please enter a valid email address.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Mütləqdir")]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "Mütləqdir")]
        [DataType(DataType.Password)]
        [MinLength(6, ErrorMessage = "Minimum uzunluq 6")]
        public string Password { get; set; }
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Passwords not same")]
        [Required(ErrorMessage = "Mütləqdir")]
        public string ConfirmPassword { get; set; }
        [Required(ErrorMessage = "Mütləqdir")]
        public string SeriaNumber { get; set; }
        [Required(ErrorMessage = "Mütləqdir")]
        public string CitizenShip { get; set; }
        [Required(ErrorMessage = "Mütləqdir")]
        public string DayOfBirth { get; set; }
        [Required(ErrorMessage = "Mütləqdir")]
        public string MonthOfBirth { get; set; }
        [Required(ErrorMessage = "Mütləqdir")]
        public string YearOfBirth { get; set; }
        [Required(ErrorMessage = "Mütləqdir")]
        public string Gender { get; set; }
        [Required(ErrorMessage = "Mütləqdir")]
        public string FinCode { get; set; }
        [Required(ErrorMessage = "Mütləqdir")]
        public string IdAddress { get; set; }
    }
}
