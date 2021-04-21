using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace nemesys_project.Models
{
    public interface IReportRepository
    {
        Report GetReport(int Id);
        IEnumerable<Report> GetAllReports();
        Report Add(Report report);
        Report Update(Report reportChanges);
        Report Delete(int id);

    }
}
