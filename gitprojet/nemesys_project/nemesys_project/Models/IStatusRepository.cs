using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace nemesys_project.Models
{
    public interface IStatusRepository
    {
        Status GetStatus(int Id);
        IEnumerable<Status> GetAllStatus();
        Status Add(Status status);
        Status Update(Status statusChanges);
        Status Delete(int id);
        void IsValid();
        
    }
}
