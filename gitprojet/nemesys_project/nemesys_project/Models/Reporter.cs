using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace nemesys_project.Models
{
    public class Reporter
    {
        public int ReporterId { get; set; }
        public ICollection<Report> Reports { get; set; }
    }
}
