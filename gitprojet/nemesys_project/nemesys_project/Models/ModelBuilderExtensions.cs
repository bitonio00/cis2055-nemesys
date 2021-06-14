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
            var hasher = new PasswordHasher<NemesysUser>();
            const string ADMIN_ID = "a18be9c0-aa65-4af8-bd17-00bd9344e575";
            const string ROLE_ID = "7e33859e-d3ac-400e-b593-31f7009e3266";
            modelBuilder.Entity<NemesysUserVote>()
   .HasKey(nv => new { nv.NemesysUserId, nv.VoteId });
            modelBuilder.Entity<NemesysUserVote>()
                .HasOne(nv => nv.NemesysUser)
                .WithMany(nv => nv.NemesysUserVotes)
                .HasForeignKey(nv => nv.NemesysUserId);
            modelBuilder.Entity<NemesysUserVote>()
                .HasOne(nv => nv.Vote)
                .WithMany(nv => nv.NemesysUserVotes)
                .HasForeignKey(nv => nv.VoteId);

            modelBuilder.Entity<Status>().HasData(
                new Status { StatusId = 1, StatusOfReport = "no current investigation" },
                new Status {StatusId=2, StatusOfReport = "closed" },
                new Status { StatusId = 3, StatusOfReport = "no action required" }, 
                new Status {StatusId=4,  StatusOfReport = "being investigated" }
                ) ;
            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole {Id=ROLE_ID, Name = "admin", NormalizedName = "ADMIN" },
              new IdentityRole { Name = "reporter", NormalizedName = "REPORTER" },
              new IdentityRole { Name = "investigator", NormalizedName = "INVESTIGATOR" }
                                                        );
             
            modelBuilder.Entity<NemesysUser>().HasData(
                new NemesysUser
                {
                    Id= ADMIN_ID,
                    UserName = "admin@gmail.com",
                    NormalizedUserName = "ADMIN@GMAIL.COM",
                    Email = "admin@gmail.com",
                    NormalizedEmail = "ADMIN@GMAIL.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "Admin00."),
                    SecurityStamp = string.Empty   
                }) ;
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = ROLE_ID,
                UserId = ADMIN_ID
            });











        }
    }
}
