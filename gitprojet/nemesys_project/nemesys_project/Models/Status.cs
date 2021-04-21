using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace nemesys_project.Models
{
    public class Status
    {
        
        public int StatusId { get; set; }
        public string StatusOfReport { get; set; }
        public ICollection<Report> Reports { get; set; }
    }
}
