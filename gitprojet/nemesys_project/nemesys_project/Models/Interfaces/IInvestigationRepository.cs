using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace nemesys_project.Models.Interfaces
{
    public interface IInvestigationRepository
    {
        Task<Investigation> GetInvestigation(int? Id);
        IEnumerable<Investigation> GetAllInvestigation();
        Investigation Add(Investigation investigation);
        Investigation Update(Investigation investigationChanges);
        Investigation Delete(int id);
        Task<Investigation> Find(int id);
        
    }
}
