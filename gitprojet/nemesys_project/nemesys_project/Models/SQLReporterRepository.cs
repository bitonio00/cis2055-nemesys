using nemesys_project.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace nemesys_project.Models
{
    public class SQLReporterRepository : IReporterRepository
    {
        private readonly NemesysDbContext DbContext;
        public SQLReporterRepository(NemesysDbContext context)
        {
            this.DbContext = context;
        }


        public Reporter Add(Reporter reporter)
        {
            DbContext.Reporters.Add(reporter);
            DbContext.SaveChanges();
            return reporter;
        }

        public Reporter Delete(int id)
        {
            Reporter reporter = DbContext.Reporters.Find(id);
            if(reporter !=null)
            {
                DbContext.Reporters.Remove(reporter);
                DbContext.SaveChanges();
            }
            return reporter;
        }

        public IEnumerable<Reporter> GetAllReporters()
        {
            return DbContext.Reporters;
        }

        public Reporter GetReporter(int Id)
        {
            return DbContext.Reporters.Find(Id);
        }

        public Reporter Update(Reporter reporterChanges)
        {
          var reporter=  DbContext.Reporters.Attach(reporterChanges);
            reporter.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            DbContext.SaveChanges();
            return reporterChanges;
        }
    }
}
