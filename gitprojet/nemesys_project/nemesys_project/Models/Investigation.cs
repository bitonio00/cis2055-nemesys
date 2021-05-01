using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace nemesys_project.Models
{
    public class Investigation
    {
        public int InvestigationId { get; set; }
        public string Description { get; set; }
        public DateTime DateOfCreation { get; set; }
        public DateTime DateOfAction { get; set; }
        public bool Status { get; set; } 

        [ForeignKey("Investigator")]
        public string? InvestigatorRefId { get; set; }
        public NemesysUser Investigator { get; set; }

        [ForeignKey("Report")]
        public int ReportRefId { get; set; }
        public virtual Report Report { get; set; }
    }
}
