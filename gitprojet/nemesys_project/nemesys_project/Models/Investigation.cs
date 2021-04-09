using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace nemesys_project.Models
{
    public class Investigation
    {
        [ForeignKey("Report")]
        public int InvestigationId { get; set; }

        public string Description { get; set; }
        public DateTime DateOfAction { get; set; }
        public bool Status { get; set; } 
        public int? InvestigatorId { get; set; }
        public Investigator Investigator { get; set; }

        public virtual Report Report { get; set; }
    }
}
