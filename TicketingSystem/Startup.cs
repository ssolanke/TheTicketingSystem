using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using TicketingSystem.Data;
using TicketingSystem.Models;
using ServiceBusMessaging;

namespace TicketingSystem
{
    public class Startup
    {
        private IHostingEnvironment _hostingEnvironment { get; set; }

        private IConfiguration _configuration { get; set; }

        /// <summary>
        /// Creates a new instance of this class
        /// </summary>
        /// <param name="env">The hosting environment</param>
        /// <param name="config">The configuration settings for the application</param>
        public Startup(IHostingEnvironment env, IConfiguration config)
        {
            _hostingEnvironment = env;
            _configuration = config;
        }

        /// <summary>
        /// Configures the services for this application
        /// </summary>
        /// <param name="services">The service container for this application</param>
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            services.AddSingleton<ServiceBusSender>();

            services.AddDbContext<SystemContext>(options =>
                options.UseSqlServer(_configuration.GetConnectionString("SqlConnection"), x => x.EnableRetryOnFailure(5, TimeSpan.FromSeconds(10), null)));

            services.AddSingleton<IServiceBusConsumer, ServiceBusConsumer>();
            services.AddSingleton<IProcessData, ProcessData>();

            services.AddIdentity<Technician, IdentityRole>().AddEntityFrameworkStores<SystemContext>().AddDefaultTokenProviders();

            services.Configure<IdentityOptions>(options =>
            {
                options.Password.RequireDigit = false;
                options.Password.RequiredLength = 1;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;
                options.Password.RequireLowercase = false;
                options.Password.RequiredUniqueChars = 1;
            });
        }

        /// <summary>
        /// Configures the application pipeline and pre-startup operations
        /// </summary>
        /// <param name="app">For configuring the application pipeline</param>
        /// <param name="context"></param>
        /// <param name="logger"></param>
        /// <param name="applicationLifetime"></param>
        /// <param name="userManager"></param>
        public void Configure(IApplicationBuilder app, SystemContext context, ILogger<Startup> logger, IApplicationLifetime applicationLifetime, UserManager<Technician> userManager)
        {
            if (_hostingEnvironment.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();

            app.UseAuthentication();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Clients}/{action=All}/{id?}");
            });

            var bus = app.ApplicationServices.GetService<IServiceBusConsumer>();
            bus.RegisterOnMessageHandlerAndReceiveMessages();

        }
    }
}
