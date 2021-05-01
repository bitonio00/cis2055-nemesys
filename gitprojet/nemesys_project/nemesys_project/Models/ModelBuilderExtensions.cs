using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace nemesys_project.Models
{
    public static class ModelBuilderExtensions
    {
       // private readonly RoleManager roleManager;
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Status>().HasData(
                new Status { StatusId = 1, StatusOfReport = "no current investigation" },
                new Status {StatusId=2, StatusOfReport = "closed" },
                new Status { StatusId = 3, StatusOfReport = "no action required" }, 
                new Status {StatusId=4,  StatusOfReport = "being investigated" }
                ) ;
            modelBuilder.Entity<IdentityRole>().HasData(
              new IdentityRole { Name = "reporter", NormalizedName = "REPORTER" },
              new IdentityRole { Name = "investigator", NormalizedName = "INVESTIGATOR" }
                                                        );
            





        }
    }
}
