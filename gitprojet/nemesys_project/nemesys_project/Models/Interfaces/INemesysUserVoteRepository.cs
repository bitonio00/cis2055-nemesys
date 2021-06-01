using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace nemesys_project.Models.Interfaces
{
    public interface INemesysUserVoteRepository
    {
        bool Add(string idUser,int idReport,string type);
        string HaveVoted(string userId, int voteId,string type);
        void UpdateTypeOfVote(string idUser, int voteId, string typeOfVote);
    }
}
