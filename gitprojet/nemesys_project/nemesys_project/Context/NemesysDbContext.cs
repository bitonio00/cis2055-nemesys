﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using nemesys_project.Models;
using Microsoft.EntityFrameworkCore;

namespace nemesys_project.Context
{
    public class NemesysDbContext : DbContext
    {
        public NemesysDbContext() 
        {
        }

        public NemesysDbContext(DbContextOptions<NemesysDbContext> options)
                    : base(options)
            {

            }
        public DbSet<Investigation> Investigations { get; set; }
        public DbSet<Investigator> Investigators { get; set; }
        public DbSet<Report> Reports { get; set; }
        public DbSet<Reporter> Reporters { get; set; }


    }

}
