using nemesys_project.Context;
using nemesys_project.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace nemesys_project.Models.SQLRepository
{
    public class SQLNemesysUserVoteRepository : INemesysUserVoteRepository
    {
        private readonly NemesysDbContext DbContext;
        private readonly IVoteRepository voteRepository;
        private readonly IReportRepository reportRepository;
        public SQLNemesysUserVoteRepository(NemesysDbContext DbContext, IVoteRepository voteRepository, IReportRepository reportRepository)
        {
            this.DbContext = DbContext;
            this.voteRepository = voteRepository;
            this.reportRepository = reportRepository;
        }
        public  bool Add(string idUser, int reportId)
        {
            
            
            if(HaveVoted(idUser,reportRepository.GetVoteId(reportId))==false)
            {
                if(reportRepository.GetVoteId(reportId)==0)
                {
                    var vote=voteRepository.Add(reportId);
                    DbContext.NemesysUserVotes.Add(new NemesysUserVote { NemesysUserId = idUser, VoteId = vote.VoteId });
                }
                else
                {
                    DbContext.NemesysUserVotes.Add(new NemesysUserVote { NemesysUserId = idUser, VoteId = reportRepository.GetVoteId(reportId) });
                }
            
            DbContext.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
            
        }
        public bool HaveVoted(string userId,int voteId)
        {
            foreach(var nemesysUserVote in DbContext.NemesysUserVotes)
            {
                if(nemesysUserVote.NemesysUserId.Equals(userId) && nemesysUserVote.VoteId==voteId)
                {
                    return true;
                }
               
            }
            return false;
        }
    }
}
