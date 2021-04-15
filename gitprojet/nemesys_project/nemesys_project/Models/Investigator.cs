using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace nemesys_project.Models
{
    public class Investigator
    {
        public int InvestigatorId { get; set; }

        [Display(Name="First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")] 
        public string LastName { get; set; }

        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage ="Email is Required")]
        [Display(Name ="Email ID")]
        [DataType(DataType.EmailAddress,ErrorMessage ="Email is not valid")]
        public string Email { get; set; }

        [Required]
        [Display(Name ="Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public ICollection<Investigation> Investigations { get; set; }
        
    }
}
