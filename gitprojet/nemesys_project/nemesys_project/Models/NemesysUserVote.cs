using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace nemesys_project.Models
{
    public class NemesysUserVote
    {
        [Key,Column(Order=1)]
        public string NemesysUserId { get; set; }
        public NemesysUser NemesysUser { get; set; }

        [Key, Column(Order = 2)]
        public int  VoteId {get;set;}
        public Vote Vote { get; set; }

        public string TypeOfVote { get; set; }
        
        
    }
}
