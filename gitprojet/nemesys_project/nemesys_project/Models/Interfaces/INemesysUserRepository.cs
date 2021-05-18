using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace nemesys_project.Models
{
    public interface INemesysUserRepository
    {
        IEnumerable<Report> GetAllUserReports(string Id);
        IEnumerable<Investigation> GetAllUserInvestigations(string Id);
        IEnumerable<Report> GetAllReports();

        // Alex 
        List<(string, int)> GetSortedUser();
    }
}
