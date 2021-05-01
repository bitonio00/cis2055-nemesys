using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace nemesys_project.ViewModel
{
    public class EditInvestigationViewModel
    {
        [Required]
        public string Description { get; set; }
        public int StatusId { get; set; }
        public DateTime DateOfAction { get; set; }
        public int InvestigationId { get; set; }
        public DateTime DateOfCreation { get; set; }
        public bool Status { get; set; }
        public string InvestigatorRefId { get; set; }
        public int ReportRefId { get; set; }

    }
}
