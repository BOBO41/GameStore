using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using GameStore.Repositories;
using GameStore.Models;

namespace GameStore
{
    public class Startup {
        public void ConfigureServices (IServiceCollection services) {
            services.AddTransient<ICategoryRepository, MockCategoryRepositories>();
            services.AddTransient<IGameRepository, MockGameRepository>();
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