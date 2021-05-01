using Microsoft.EntityFrameworkCore;
using nemesys_project.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace nemesys_project.Models.SQLRepository
{
    public class SQLNemesysUserRepository : INemesysUserRepository
    {
        private readonly NemesysDbContext DbContext;
        public SQLNemesysUserRepository(NemesysDbContext DbContext)
        {
            this.DbContext = DbContext;
        }
        public IEnumerable<Report> GetAllUserReports(string Id)
        {
            var userMessages = DbContext.Reports.Include(c=>c.Reporter).Include(c => c.Status)
              .Where(u => u.ReporterRefId.Equals(Id));
          
            return userMessages;
        }
        public IEnumerable<Investigation> GetAllUserInvestigations(string Id)
        {
            var userMessages = DbContext.Investigations.Include(c => c.Report).Include(c => c.Report.Status).Include(c => c.Report.Reporter)
              .Where(u => u.InvestigatorRefId.Equals(Id));

            return userMessages;
        }
        public IEnumerable<Report> GetAllReports()
        {
            return DbContext.Reports;
        }
    }
}
