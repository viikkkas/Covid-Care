using CovidCare.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CovidCare
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
            services.AddDbContext<ContactDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("Myconnection")));
            services.AddDbContext<QuarantineContext>(options => options.UseSqlServer(Configuration.GetConnectionString("MyConnection")));
            services.AddDbContext<RegistrationContext>(options => options.UseSqlServer(Configuration.GetConnectionString("MyConnection")));
            services.AddControllersWithViews();
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
            }
            app.UseStaticFiles();

            app.UseRouting();

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

public class RegistrationContext: DbContext
{
    public RegistrationContext(DbContextOptions<RegistrationContext> options) : base(options) { }
    public DbSet<Registration> Registrations { get; set; }
}

public class QuarantineContext : DbContext
{
    public QuarantineContext(DbContextOptions<QuarantineContext> options) : base(options) { }
    public DbSet<Quarantine> Quarantines { get; set; }
}
