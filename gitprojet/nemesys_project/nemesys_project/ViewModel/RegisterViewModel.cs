using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace nemesys_project.ViewModel
{
    public class RegisterViewModel
    {
        [Required]
        [Display(Name = "Reporter or Investigator")]
        public bool Type { get; set; }

        [Required(ErrorMessage ="Name is Required")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is Required")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Phone Number")]

        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Email is Required")]
        [Display(Name = "Email ID")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Email is not valid")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name ="Confirm password")]
        [Compare("Password",
            ErrorMessage ="Password and confirmation password do not match")]
        public string ConfirmPassword { get; set; }
    }
}
