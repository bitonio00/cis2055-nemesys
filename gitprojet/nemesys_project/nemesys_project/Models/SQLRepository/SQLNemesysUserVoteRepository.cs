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
        public  bool Add(string idUser, int reportId,string type)
        {
            
            
            if(HaveVoted(idUser,reportRepository.GetVoteId(reportId),type).Equals("CanVoted"))
            {
                if(reportRepository.GetVoteId(reportId)==0)
                {
                    var vote=voteRepository.Add(reportId);
                    DbContext.NemesysUserVotes.Add(new NemesysUserVote { NemesysUserId = idUser, VoteId = vote.VoteId,TypeOfVote=type });
                }
                else
                {
                    DbContext.NemesysUserVotes.Add(new NemesysUserVote { NemesysUserId = idUser, VoteId = reportRepository.GetVoteId(reportId),TypeOfVote=type });
                }
            
            DbContext.SaveChanges();
                return true;
            }
            else if(HaveVoted(idUser, reportRepository.GetVoteId(reportId), type).Equals("ChangeVoted"))
            {
                UpdateTypeOfVote( idUser, reportRepository.GetVoteId(reportId), "Neutral" );
                return true;
            }
            else if((HaveVoted(idUser, reportRepository.GetVoteId(reportId), type).Equals("NeutralVote")))
            {
                UpdateTypeOfVote(idUser, reportRepository.GetVoteId(reportId), type);
                return true;
            }
            else
            {
                return false;
            }
            
        }
        public void UpdateTypeOfVote(string idUser,int voteId,string typeOfVote)
        {
           //var a= DbContext.NemesysUserVotes.Where(c => (c.VoteId = voteId && c.NemesysUserId.Equals(idUser)));
            foreach (var nemesysUserVote in DbContext.NemesysUserVotes)
            {
                if (nemesysUserVote.NemesysUserId.Equals(idUser) && nemesysUserVote.VoteId == voteId )
                {
                    nemesysUserVote.TypeOfVote = typeOfVote;
                    
                }
  
            }
            DbContext.SaveChanges();

        }
        public string HaveVoted(string userId,int voteId,string type)
        {
          //  string option=" ";
            foreach(var nemesysUserVote in DbContext.NemesysUserVotes)
            {
                if(nemesysUserVote.NemesysUserId.Equals(userId) && nemesysUserVote.VoteId==voteId && nemesysUserVote.TypeOfVote.Equals(type))
                {
                    //option= "HaveVoted";
                    return "HaveVoted";
                } 
                else if(nemesysUserVote.NemesysUserId.Equals(userId) && nemesysUserVote.VoteId == voteId && nemesysUserVote.TypeOfVote.Equals("Neutral"))
                {
                   // option = "NeutralVote";
                   return "NeutralVote"; 
                }
                else if(nemesysUserVote.NemesysUserId.Equals(userId) && nemesysUserVote.VoteId == voteId && nemesysUserVote.TypeOfVote.Equals(type)==false)
                {
                    //option= "ChangeVoted";
                    return "ChangeVoted"; 
                }
               
               /* else if()
                {
                    option= "CanVoted";
                }*/
               
            }
            return "CanVoted";
           
        }
    }
}
