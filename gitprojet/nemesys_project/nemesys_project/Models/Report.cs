using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace nemesys_project.Models
{
    public class Report
    {
        public int ReportId { get; set; }
        public DateTime CreationDate { get; set;}
        public DateTime ProblemDate { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public double LongitudeLocation { get; set; }
        public double LatitudeLocation { get; set; }
        public int UpVote { get; set; }
        public string ReporterInfo { get; set; }
        public int? ReporterId { get; set; }
        public Reporter Reporter { get; set; }

        public virtual Investigation Investigation { get; set; }



    }
}
