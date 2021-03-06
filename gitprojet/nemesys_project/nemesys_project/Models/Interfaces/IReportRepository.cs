using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace nemesys_project.Models
{
    public interface IReportRepository
    {
        Report GetReport(int Id);
        IEnumerable<Report> GetAllReports();
        List<Report> GetAllNotInvestigateReports();
        Report Add(Report report);
        Report Update(Report reportChanges);
        void UpdateStatus(int id, int StatusChange);
        void UpdateInvestigation(int id, int InvestigationRefId);
        Report Delete(int id);
        void Vote(int id);
        Task<Report> Find(int id);
        int GetVoteId(int reportId);

    }
}
