using nemesys_project.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace nemesys_project.Models
{
    public class SQLReportRepository:IReportRepository
    {
        private readonly NemesysDbContext DbContext;
        public SQLReportRepository(NemesysDbContext context)
        {
            this.DbContext = context;
        }

        public Report Add(Report report)
        {
            DbContext.Reports.Add(report);
            DbContext.SaveChanges();
            return report;
        }

        public Report Delete(int id)
        {
            Report report = DbContext.Reports.Find(id);
            if (report != null)
            {
                DbContext.Reports.Remove(report);
                DbContext.SaveChanges();
            }
            return report;
        }

        public IEnumerable<Report> GetAllReports()
        {
            return DbContext.Reports;
        }

        public Report GetReport(int Id)
        {
            return DbContext.Reports.Find(Id);
        }

        public Report Update(Report reportChanges)
        {
            var report = DbContext.Reports.Attach(reportChanges);
            report.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            DbContext.SaveChanges();
            return reportChanges;
        }
    }
}
