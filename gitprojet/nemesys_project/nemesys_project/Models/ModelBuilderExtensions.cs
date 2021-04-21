using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace nemesys_project.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Status>().HasData(
                new Status {StatusId=1, StatusOfReport = "closed" },
                new Status { StatusId = 2, StatusOfReport = "being investigated" },
                new Status { StatusId = 3, StatusOfReport = "no action required" }
                ) ;

        }
    }
}
