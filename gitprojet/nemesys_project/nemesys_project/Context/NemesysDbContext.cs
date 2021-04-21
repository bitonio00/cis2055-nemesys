using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using nemesys_project.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace nemesys_project.Context
{
    public class NemesysDbContext : IdentityDbContext<NemesysUser>
    {

        public NemesysDbContext(DbContextOptions<NemesysDbContext> options)
                    : base(options)
        {
           
        }
        
        public DbSet<Investigation> Investigations { get; set; }
        public DbSet<Investigator> Investigators { get; set; }
        public DbSet<Report> Reports { get; set; }
        public DbSet<Reporter> Reporters { get; set; }
        public DbSet<Status> Status { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Seed();
            base.OnModelCreating(builder);
            

        }


    }



}
