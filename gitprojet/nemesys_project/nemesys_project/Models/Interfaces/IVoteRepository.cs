using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace nemesys_project.Models.Interfaces
{
    public interface IVoteRepository
    {
         Vote Add(int reportId);
        void UpVote(int reportId);
        void DownVote(int reportId);
        Task<Vote> FindVoteWithReport(int id);
        
    }
}
