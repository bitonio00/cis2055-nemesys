using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace nemesys_project.Models
{
    public class NemesysUser:IdentityUser
    {
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Upvote")]
        public int Upvote { get; set; }
        public ICollection<Investigation> Investigations { get; set; }
        public ICollection<Report> Reports { get; set; }
        public ICollection<NemesysUserVote> NemesysUserVotes { get; set; }

    }
}
