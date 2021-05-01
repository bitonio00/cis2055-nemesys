using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace nemesys_project.ViewModel
{
    public class InvestigationViewModel
    {
        [Required]
        public string Description { get; set; }
        public int ReportId { get; set; }
        public int StatusId { get; set; }
        public string StatusOfReport { get; set; }
        public DateTime DateOfAction { get; set; }
    }
}
