using EmployeeManagement.Utilities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.ViewModels
{
    public class RegisterViewModel
    {
        [Required]
        [Display(Name = "Full Name")]
        [MaxLength(20, ErrorMessage = "FullName cannot Exceed 20 Characters")]
        public string FullName { get; set; }

        [Required]
        public int DateOfBirth { get; set; }

        [Required]
        [EmailAddress]
        [Remote(action: "IsEmailInUse", controller: "Account")]
        [ValidEmailDomain(allowedDomain: "gmail.com", ErrorMessage = "Email Domain must be gmail.com ")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare ("Password",
            ErrorMessage = "Password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        [Required]
        [MaxLength(20, ErrorMessage = "City input cannot Exceed 20 Characters")]
        public string City { get; set; }

        [Required]
        [Display(Name = "Marital Status")]
        public string MaritalStatus { get; set; }
    }
}
