using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PHONEBOOK.DOMAIN.CONTRACT;
using PHONEBOOK.ENDPOINT.MVC.Models.AAA;
using PHONEBOOK.INFRASTRUCTURE.DAL;
using PHONEBOOK.INFRASTRUCTURE.DAL.Repository;

namespace PHONEBOOK.ENDPOINT.MVC
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
            //services.AddMvc();
            services.AddControllersWithViews();
            //services.AddDbContext<PHONEBOOK_DB>(v=> v.uses );
            //services.AddDbContext<PHONEBOOK_DB>;
            //services.AddDbContext<PHONEBOOK_DB>(c => c.UseSqlServer
            //("Data Source=.;Initial Catalog=PHONEBOOK;Integrated Security=True;"));
            services.AddDbContext<PHONEBOOK_DB>(ServiceLifetime.Scoped);

            
            //("Data Source=.;Initial Catalog=PHONEBOOK;Integrated Security=True;"));

            services.AddScoped<IPersonRepository, PersonRepo>();
            services.AddScoped<ITagRepository, TagRepo>();
            services.AddScoped<IPhoneRepository, PhoneRepo>();

            services.AddIdentity<Appuser, IdentityRole>(c=> {

                c.Password.RequireDigit = false;
                c.Password.RequiredLength = 5;
                c.Password.RequireNonAlphanumeric = false;
                //c.Password.RequireNonLetterOrDigi = false;

                c.Password.RequireUppercase = false;
                c.Password.RequireLowercase= false;


            }).AddEntityFrameworkStores<UserDbContext>();
            services.AddDbContext<UserDbContext>(c => c.UseSqlServer(Configuration.GetConnectionString("aaa")));

            //services.AddControllersWithViews();

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

            app.UseAuthentication();//FOR atu


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");

                //id? basgad ya nabashad
            });
        }
    }
}
