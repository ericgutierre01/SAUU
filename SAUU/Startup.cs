﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SAUU.Data;
using SAUU.Filters;
using SAUU.Helpers;
using SAUU.Models;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace SAUU
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            //AutoMapper
          /*  services.AddAutoMapper(typeof(Startup).Assembly);
            Mapper.Initialize(cfg => new MappingProfile());*/

            services.AddDbContext<SAUUContext>(opcions => opcions.UseSqlServer(Configuration.GetConnectionString("SAUUConnectionString")));

            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
              .AddCookie(options => {
                  options.LoginPath = "/Login";
                  options.LogoutPath = "/Logout";
              });
            services.AddMemoryCache();
            services.AddSession();
            services.AddMvc(options => options.Filters.Add(new ExceptionFilter()))
                .SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
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

            //app.UseHttpsRedirection();
            app.UseStaticFiles();
            //app.UseCookiePolicy();

            app.UseAuthentication();
            //app.UseSession();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Ticket}/{action=Index}/{id?}");
            });
        }
    }
}
