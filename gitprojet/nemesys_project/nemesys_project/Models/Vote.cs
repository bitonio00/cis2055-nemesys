using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace nemesys_project.Models
{
    public class Vote
    {
        public int VoteId { get; set; }
        public int Score { get; set; }
        public  Report Report { get; set; }
        public ICollection<NemesysUserVote> NemesysUserVotes { get; set; }
    }
}
