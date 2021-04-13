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
        public enum TypeHazard
        {
            [Display(Name = "Unsafe act")]
            Unsafe_act,
            [Display(Name = "Condition")]
            Condition,
            [Display(Name = " Equipement ")]
            Equipement,
            [Display(Name = " Structure ")]
            Structure
        }
        public int ReportId { get; set; }
        public DateTime CreationDate { get; set;}
        public DateTime ProblemDate { get; set; }
        public  TypeHazard Type { get; set; }
        public string Description { get; set; }
        public double LongitudeLocation { get; set; }
        public double LatitudeLocation { get; set; }
        public int UpVote { get; set; }
        public string ReporterInfo { get; set; }
        public int? ReporterId { get; set; }
        public Reporter Reporter { get; set; }

        [ForeignKey("Status")]
        public int StatusRefId { get; set; }
        public Status Status { get; set; }

        public virtual Investigation Investigation { get; set; }



    }
}
