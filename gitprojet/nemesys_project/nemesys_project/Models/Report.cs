using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace nemesys_project.Models
{
    public class Report
    {

        public int ReportId { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime HazardDate { get; set; }
        public string HazardType { get; set; }
        public string Description { get; set; }
        public string HazardLocation { get; set; }
        public double LongitudeLocation { get; set; }
        public double LatitudeLocation { get; set; }
        public int UpVote { get; set; }
        public string ImageUrl { get; set; }

        [ForeignKey("Status")]
        public int StatusRefId { get; set; }
        public Status Status { get; set; }

        [ForeignKey("Reporter")]
        public string? ReporterRefId { get; set; }
        public NemesysUser Reporter { get; set; }

        [ForeignKey("Investigation")]
        public int? InvestigationRefId { get; set; }
        public Investigation Investigation { get; set; }
        
        [ForeignKey("Vote")]
        public int? VoteRefId { get; set; }
        public Vote Vote { get; set; }

    }
}
