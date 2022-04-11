using KutyakozmetikaApi.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KutyakozmetikaApi
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
            services.AddDbContext<kutyakozmetikaContext>(
                 options =>
                 // Kiolvassa az appsettins.json fájlból a kapcsolati értéket
                 options.UseMySql(Configuration.GetConnectionString("KutyakozmetikaDB"),
                 ServerVersion.Parse("10.4.6-mariadb")));
#if DEBUG
            services.AddCors(options => options.AddDefaultPolicy(c =>
            {
                c.AllowAnyMethod()
                 .AllowAnyOrigin()
                 .AllowAnyHeader();
            }));
#else
            services.AddCors(options => options.AddDefaultPolicy(c =>
            {
                c.AllowAnyMethod()
                 .AllowAnyOrigin()
                 .AllowAnyHeader();
            }));

#endif

            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseCors();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
