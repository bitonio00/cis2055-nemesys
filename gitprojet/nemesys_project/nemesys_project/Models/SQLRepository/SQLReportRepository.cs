using Microsoft.EntityFrameworkCore;
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
            int i=report.ReportId;
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
            return DbContext.Reports.Include(c => c.Status).Include(c=>c.Reporter).Include(c=>c.Vote);
        }

        public IEnumerable<Report> GetAllNotInvestigateReportsLocartion()
        {
           
            return DbContext.Reports.Include(c => c.Status).Include(c => c.Reporter).Include(c => c.Vote).Where(u => u.StatusRefId==1);
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
        /*public Report UpdateV2(Report report)
        {
            DbContext.Reports.
        }*/
        public async Task<Report> Find(int id)
        {
            //foreach(Report in DbContext.Reports)
            //{
            // if(DbContext.Reports.Find(id))
             var report =await  DbContext.Reports.Include(c => c.Status).FirstOrDefaultAsync(i=>i.ReportId==id);
            //}

            var a=report.ReportId;

            return report;
        }

        public void UpdateStatus(int id, int StatusChange)
        {
           var report=  DbContext.Reports.Find(id);
            report.StatusRefId = StatusChange;
            DbContext.SaveChanges();
           
            
        }
        public void UpdateInvestigation(int id, int InvestigationRefId)
        {
            var report = DbContext.Reports.Find(id);
            report.InvestigationRefId = InvestigationRefId;
            DbContext.SaveChanges();


        }
        public int GetVoteId(int reportId)
        {
           var report= DbContext.Reports.Find(reportId);
            var i=report.VoteRefId;
            if(i==null)
            {
                return 0;
            }
            else
            {
            return (int)i;
            }
            
           
        }

        public List<Report> GetAllNotInvestigateReports()
        {
            List<Report> reports=new List<Report>();
            foreach(var report in DbContext.Reports.Include(c => c.Status).Include(c => c.Reporter))
            {
                if(report.StatusRefId==1)
                {
                    reports.Add(report);
                }
            }
            return reports;
        }

        public void Vote(int id)
        {
            Report report = DbContext.Reports.Find(id);
            report.UpVote++;
            DbContext.SaveChanges();


        }
    }
}
