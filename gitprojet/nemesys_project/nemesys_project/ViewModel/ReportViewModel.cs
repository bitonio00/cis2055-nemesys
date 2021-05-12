using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace nemesys_project.ViewModel
{
    public class ReportViewModel
    {
        [Required(ErrorMessage = "The date of the hazard is required")]
        public DateTime HazardDate { get; set; }

        [Required(ErrorMessage = "The type of the hazard is required")]
        public string HazardType { get; set; }

        [Required(ErrorMessage = "The description of the hazard is required")]
        public string Description { get; set; }

        [Required(ErrorMessage = "The location of the hazard is required")]
        public string HazardLocation { get; set; }
        public double Lat { get; set; }

        public double Lng { get; set; }
        public string ImageUrl { get; set; }
        public IFormFile ImageToUpload { get; set; } //used only when submitting form



    }
}
