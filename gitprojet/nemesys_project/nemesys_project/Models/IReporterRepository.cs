using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace nemesys_project.Models
{
    public interface IReporterRepository
    {
        Reporter GetReporter(int Id);
        IEnumerable<Reporter> GetAllReporters();
        Reporter Add(Reporter reporter);
        Reporter Update(Reporter reporterChanges);
        Reporter Delete(int id);

    }
}
