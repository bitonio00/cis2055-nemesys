using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using nemesys_project.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using nemesys_project.Models;
using Microsoft.AspNetCore.Identity;
using nemesys_project.Models.SQLRepository;
using nemesys_project.Models.Interfaces;
using NETCore.MailKit;
using NETCore.MailKit.Extensions;
using NETCore.MailKit.Infrastructure.Internal;

namespace nemesys_project
{
    
    public class Startup
    {
        private IConfiguration Configuration;

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContextPool<NemesysDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("NemesysDbConnection")));
            services.AddIdentity<NemesysUser, IdentityRole>(options =>
            {
                options.Password.RequireUppercase = false;
                options.SignIn.RequireConfirmedEmail = true;
            }).AddEntityFrameworkStores<NemesysDbContext>().AddDefaultTokenProviders();
            var mailKitOptions = Configuration.GetSection("Email").Get<MailKitOptions>();
            services.AddMailKit(Configuration => Configuration.UseMailKit(mailKitOptions/*Configuration.GetSection("Email").Get<MailKitOptions>()*/));
           

            services.AddControllersWithViews();
            services.AddScoped<IReportRepository, SQLReportRepository>();
            services.AddScoped<IStatusRepository, SQLStatusRepository>();
            services.AddScoped<INemesysUserRepository, SQLNemesysUserRepository>();
            services.AddScoped<IInvestigationRepository, SQLInvestigationRepository>();
            services.AddScoped<IVoteRepository, SQLVoteRepository>();
            services.AddScoped<INemesysUserVoteRepository, SQLNemesysUserVoteRepository>();

            



        }


        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
