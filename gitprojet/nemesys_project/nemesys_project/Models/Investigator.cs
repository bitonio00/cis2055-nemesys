using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace nemesys_project.Models
{
    public class Investigator
    {
        public int InvestigatorId { get; set; }
        public ICollection<Investigation> Investigations { get; set; }
    }
}
