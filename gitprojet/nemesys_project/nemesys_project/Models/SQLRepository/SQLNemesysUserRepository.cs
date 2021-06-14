using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using nemesys_project.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace nemesys_project.Models.SQLRepository
{
    public class SQLNemesysUserRepository : INemesysUserRepository
    {
        private readonly NemesysDbContext DbContext;
        private readonly UserManager<NemesysUser> userManager;
        public SQLNemesysUserRepository(NemesysDbContext DbContext, UserManager<NemesysUser> userManager)
        {
            this.DbContext = DbContext;
            //alex
            this.userManager = userManager;
        }
        public IEnumerable<Report> GetAllUserReports(string Id)
        {
            var userMessages = DbContext.Reports.Include(c=>c.Reporter).Include(c => c.Status).Include(c=>c.Vote)
              .Where(u => u.ReporterRefId.Equals(Id));
          
            return userMessages;
        }
        public IEnumerable<Investigation> GetAllUserInvestigations(string Id)
        {
            var userMessages = DbContext.Investigations.Include(c => c.Report).Include(c => c.Report.Status).Include(c => c.Report.Reporter)
              .Where(u => u.InvestigatorRefId.Equals(Id));

            return userMessages;
        }
        public IEnumerable<NemesysUser> GetAllUsers()
        {
            var users = DbContext.Users;
            return users;
        }
        public IEnumerable<Report> GetAllReports()
        {
            return DbContext.Reports;
        }
        public void Delete(string id)
        {
           var user= DbContext.Users.Find(id);
            if (user != null)
            {
             foreach(var report in GetAllUserReports(id))
                {
                    DbContext.Reports.Remove(report);
                }
                DbContext.Users.Remove(user);
                DbContext.SaveChanges();
            }
        }
        //Alex
        public List<(string, int)> GetSortedUser()
        {
            List<(string,int)> mylist = new List<(string,int )>();
            var reportlist = DbContext.Reports.Include(c => c.Reporter).ToList();
            foreach (var user in userManager.Users)
            {
                int cnt = 0;
                foreach(var report in reportlist)
                {
                    if(report.Reporter.Email.Equals(user.Email))
                    {
                        cnt++;
                    }
                }
                mylist.Add((user.Email,cnt));
                
            }
            var list = mylist.OrderByDescending(x => x.Item2).ToList();

            return list;
        }
        
        
    }
}
