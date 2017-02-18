using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using GameStore.Context;
using Microsoft.EntityFrameworkCore;
using GameStore.Persistence;

namespace GameStore
{
    public class Startup {

        private IConfigurationRoot _configurationRoot;

        public Startup(IHostingEnvironment hostingEnvironment)
        {
            _configurationRoot = new ConfigurationBuilder()
                    .SetBasePath(hostingEnvironment.ContentRootPath)
                    .AddJsonFile("appsettings.json")
                    .Build();
        }
        public void ConfigureServices (IServiceCollection services) {
            services.AddDbContext<StoreContext>(options => options.UseSqlServer(_configurationRoot.GetConnectionString("DefaultConnection")));
            services.AddSingleton<IUnitOfWork, UnitOfWork>();
            services.AddMvc();
        }
        public void Configure(IApplicationBuilder app) {
            app.UseDeveloperExceptionPage();
            app.UseMvc();
            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseMvcWithDefaultRoute();
        }
    }
}