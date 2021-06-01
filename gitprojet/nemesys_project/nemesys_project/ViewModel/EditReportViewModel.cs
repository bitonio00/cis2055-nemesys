using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace nemesys_project.ViewModel
{
    public class EditReportViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "The date of the hazard is required")]
        public DateTime HazardDate { get; set; }

        [Required(ErrorMessage = "The type of the hazard is required")]
        public string HazardType { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string HazardLocation { get; set; }
        public string StatusOfHazard { get; set; }
        public int StatusRefId { get; set; }
        public DateTime CreationDate { get; set; }
        public float LongitudeLocation { get; set; }
        public float LatitudeLocation { get; set; }
        public int UpVote { get; set; }
        public string ReporterRefId { get; set; }
        public int? InvestigationRefId { get; set; }
        public int? VoteRefId { get; set; }
        public string ImageUrl { get; set; }
        public IFormFile ImageToUpload { get; set; } //used only when submitting form



    }
}
