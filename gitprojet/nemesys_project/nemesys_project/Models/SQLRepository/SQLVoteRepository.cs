using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using nemesys_project.Context;
using nemesys_project.Models.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace nemesys_project.Models.SQLRepository
{
    public class SQLVoteRepository:IVoteRepository
    {
        private readonly NemesysDbContext DbContext;
        private readonly UserManager<NemesysUser> userManager;

        public SQLVoteRepository(NemesysDbContext DbContext, UserManager<NemesysUser> userManager)
        {
            this.DbContext = DbContext;
            this.userManager = userManager;
        }

        public Vote Add(int reportId)
        {
            Vote vote = new Vote();
            vote.Score = 0;
            vote.Report = DbContext.Reports.Find(reportId);
            var a = vote.Report.ReportId;
            DbContext.Votes.Add(vote);
            DbContext.SaveChanges();
            return vote;
        }
        public async Task<Vote> FindVoteWithReport(int id)
        {
           var a =await DbContext.Votes.Include(c => c.Report).FirstOrDefaultAsync(i => i.Report.ReportId== id);
            /*var myVote = new Vote();
            foreach (var vote in DbContext.Votes.Include(c => c.Report))
            {
                
                if (vote.Report.ReportId == id)
                {
                    myVote = vote;
                }
            }*/
            return a;

        }
        public  void UpVote(int reportId)
        {
            int voteId = (int)DbContext.Reports.Find(reportId).VoteRefId;
            var vote=DbContext.Votes.Find(voteId);
            vote.Score = vote.Score + 1;
            DbContext.SaveChanges();
           
        }
        public  void DownVote(int reportId)
        {
            int voteId = (int)DbContext.Reports.Find(reportId).VoteRefId;
            var vote = DbContext.Votes.Find(voteId);
            vote.Score = vote.Score -1;
            DbContext.SaveChanges();
        }
    }
}
