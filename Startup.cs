using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace GameStore
{
    public class Startup {
        public void ConfigureServices (IServiceCollection services) {
            services.AddMvc();
        }
        public void Configure(IApplicationBuilder app) {
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseMvcWithDefaultRoute();
        }
    }
}