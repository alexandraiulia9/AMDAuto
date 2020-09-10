using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AMDAuto.Code.ExtensionMethods;
using AMDAuto.DataAccess;
using AMDAuto.DataAccess.UnitOfWork;
using AutoMapper;
using Hangfire;
using Hangfire.SqlServer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using RouteJs;

namespace AMDAuto
{
    public class Startup
    {
        

        public IConfigurationRoot Configuration { get; }

        public Startup(IHostingEnvironment env)
        {
            var configurationBuilder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true);

            configurationBuilder.AddEnvironmentVariables();
            Configuration = configurationBuilder.Build();
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddSingleton<IActionContextAccessor, ActionContextAccessor>();

            services.AddDbContext<AmdautoContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddScoped<AMDAutoUnitOfWork>();
            services
                .AddMvc(config =>
                {
                });
            services.AddBusinessLogic();
            services.AddAutoMapper(typeof(Startup));

            services.AddAuthentication("AMDAutoCookies")
                    .AddCookie("AMDAutoCookies", options =>
                    {
                        options.AccessDeniedPath = new PathString("/Account/Login");
                        options.LoginPath = new PathString("/Account/Login");
                    });
            services.AddCurrentUser();

            services.AddScoped<Code.RecurringJobManager>();
            services.AddRouteJs();
            services.AddHangfire(config =>
            {
                var options = new SqlServerStorageOptions
                {
                };
                config.UseSqlServerStorage(Configuration.GetConnectionString("HangfireDB"), options);
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, AmdautoContext context, Code.RecurringJobManager jobManager)
        {
            if (env.IsDevelopment())
            {
                app.UseBrowserLink();
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Shared/Error");
            }

            app.UseStaticFiles();
            app.UseAuthentication();

            app.UseHangfireServer();
            app.UseHangfireDashboard();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });

            jobManager.RegisterJobs();
        }
    }
}
