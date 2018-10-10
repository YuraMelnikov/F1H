using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using F1H.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;

namespace F1H
{
    public class Startup
    {
        public Startup(IConfiguration configuration) => Configuration = configuration;
        public IConfiguration Configuration { get; }
        
        public void ConfigureServices(IServiceCollection services)
        {
            //Connection for MS SQL
            //var connection = @"Server=tsqlserver;Database=F1H;Trusted_Connection=True;ConnectRetryCount=0";
            //services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connection));
            //services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(Configuration["Data:F1H:ConnectionString"]));

            //Connection for PostgreSQL
            var connection = @"Host=localhost;Port=5432;Database=F1H;Username=F1HAdmin;Password=633336633336";
            services.AddDbContext<ApplicationDbContext>(options => options.UseNpgsql(connection));

            services.AddTransient<IF1HRepository, EFF1HRepository>();
            services.AddMvc();
        }
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseMvc(routes => {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}");
            });
        }
    }
}
