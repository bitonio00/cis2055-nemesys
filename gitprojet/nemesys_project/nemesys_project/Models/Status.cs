using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace nemesys_project.Models
{
    public class Status
    {
        public enum StatusOfRep
        {
            [Display(Name = " Closed ")]
            Closed,
            [Display(Name = " Being Investigated ")]
            BeingInvestigated,
            [Display(Name = "  No Action Required ")]
            NoActionRequired

        }
        public int StatusId { get; set; }
        public StatusOfRep StatusOfReport { get; set; }
        public ICollection<Report> Reports { get; set; }
    }
}
