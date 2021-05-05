using Microsoft.EntityFrameworkCore;
using nemesys_project.Context;
using nemesys_project.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace nemesys_project.Models.SQLRepository
{
    public class SQLInvestigationRepository : IInvestigationRepository
    {
        private readonly NemesysDbContext DbContext;
        private readonly IReportRepository reportRepository;
        public SQLInvestigationRepository(NemesysDbContext context,IReportRepository reportRepository)
        {
            this.DbContext = context;
            this.reportRepository = reportRepository;
        }
        public Investigation Add(Investigation investigation)
        {
            DbContext.Investigations.Add(investigation);
            DbContext.SaveChanges();
            return investigation;
        }

        public Investigation Delete(int id)
        {
            Investigation investigation = DbContext.Investigations.Find(id);
            if (investigation != null)
            {
                reportRepository.UpdateStatus(investigation.ReportRefId, 1);
                DbContext.Investigations.Remove(investigation);
                DbContext.SaveChanges();
            }
            return investigation;
        }

        public async Task<Investigation> Find(int id)
        {
            var investigation = await DbContext.Investigations.Include(c => c.Report).Include(c=>c.Investigator).FirstOrDefaultAsync(i => i.InvestigationId == id);
            return investigation;
        }

        public IEnumerable<Investigation> GetAllInvestigation()
        {
            return DbContext.Investigations;
        }

        public async Task<Investigation> GetInvestigation(int Id)
        {
            var invest= await DbContext.Investigations.Include(c => c.Report).Include(c => c.Investigator).FirstOrDefaultAsync(i => i.InvestigationId == Id);
            
            return invest;
        }

        public Investigation Update(Investigation investigationChanges)
        {
            var investigation = DbContext.Investigations.Attach(investigationChanges);
            investigation.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            DbContext.SaveChanges();
            return investigationChanges;
        }
    }
}
