using nemesys_project.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace nemesys_project.Models
{
    public class SQLStatusRepository : IStatusRepository
    {
        private readonly NemesysDbContext DbContext;
        public SQLStatusRepository(NemesysDbContext context)
        {
            this.DbContext = context;
            
        }
        public Status Add(Status status)
        {
            DbContext.Status.Add(status);
            DbContext.SaveChanges();
            
            return status;
        }

        public void IsValid()
        {
            //if (!DbContext.Status.Any())
            //{
                Add(new Status { StatusOfReport = "closed" });
                Add(new Status { StatusOfReport = "being investigated" });
                Add(new Status { StatusOfReport = "no action required" });
            //}
        }

        public Status Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Status> GetAllStatus()
        {
            throw new NotImplementedException();
        }

        public Status GetStatus(int Id)
        {
            throw new NotImplementedException();
        }

        public Status Update(Status statusChanges)
        {
            throw new NotImplementedException();
        }
        public int FindRefId(string statusOfReport)
        {
            foreach(var status in DbContext.Status)
            {
                if(status.StatusOfReport.Equals(statusOfReport))
                {
                    var id = status.StatusId;
                    return id;
                }
            }
            return 1;
        }
            
    }
}
