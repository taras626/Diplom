
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TsukanovaDesign.Service;
using Microsoft.EntityFrameworkCore;
using TsukanovaDesign.Domain;
using TsukanovaDesign.Domain.Repositories.EntityFramework;
using TsukanovaDesign.Domain.Repositories.Abstract;

namespace TsukanovaDesign
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration) => Configuration = configuration;

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IFeedbackRepository, EFFeedbacksRepository>();
            services.AddTransient<IObjectsOfPortfolioRepository, EFObjectsOfPortfolioRepository>();
            services.AddTransient<IHelperQuestionRepository, EFHelperQuestionRepository>();
            services.AddTransient<IHelperAnswerRepository, EFHelperAnswerRepository>();
            services.AddTransient<IHelperAdviceRepository, EFHelperAdviceRepository>();

            services.AddTransient<DataManager>();

            Configuration.Bind("Project", new Config());

            services.AddDbContext<AppDBContext>(x => x.UseSqlServer(Config.ConnectionString));

            services.AddControllersWithViews().SetCompatibilityVersion(CompatibilityVersion.Version_3_0).AddSessionStateTempDataProvider();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
                app.UseDeveloperExceptionPage();         
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
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
