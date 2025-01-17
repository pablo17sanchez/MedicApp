using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using MedicApp.WebApi.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MedicApp.BusinessLogic.Interfaces;
using MedicApp.BusinessLogic.Implementations;
using MedicApp.UnitOfWork;
using MedicApp.DataAccess;

namespace MedicApp.WebApi
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
            services.AddTransient<ICitasLogic, CitasLogic>();
            services.AddTransient<IUsuarioLogic, UsuarioLogic>();


            services.AddTransient<IArsLogic, ARSLogic>();
            services.AddTransient<IConsultorioLogic, ConsultorioLogic>();
            services.AddTransient<IDocumentosLogic, DocumentosLogic>();
            services.AddTransient<IMedicoLogic, MedicoLogic>();
            services.AddTransient<INCFLogic, NCFLogic>();
            services.AddTransient<IPacienteLogic, PacienteLogic>();
            services.AddTransient<IProvinciaLogic, ProvinciaLogic>();
            services.AddTransient<ISectorLogic, SectorLogic>();
            services.AddTransient<IServicioLogic, ServicioLogic>();


            services.AddSingleton<IUnitOfWork>(option => new MedicAppUnitOfWork(
               Configuration.GetConnectionString("Store")
               ));


            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));
            services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<ApplicationDbContext>();
            services.AddControllersWithViews();
            services.AddRazorPages();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
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
            app.UseCors(option =>
            {
                option.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin();
            });
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });
        }
    }
}
