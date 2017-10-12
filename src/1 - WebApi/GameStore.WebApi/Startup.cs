using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using GameStore.Infra.Data.Context;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using GameStore.Infra.CrossCutting.IoC;
using GameStore.Application.Interfaces;
using GameStore.Application.Services;
using GameStore.Infra.Data.Repositories;
using GameStore.Domain.Interfaces.Repositories;

namespace GameStore.WebApi
{
    public class Startup
    {

        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                .AddEnvironmentVariables();
            Configuration = builder.Build();
        }

        public IConfigurationRoot Configuration { get; }
        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddAutoMapper();
            var sad = Configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<GameStoreContext>(options => 
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            RegisterServices(services);
        }
        
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseStaticFiles();
            app.UseMvc();
        }
        public static void RegisterServices(IServiceCollection services){
            NativeInjectorBootStrapper.RegisterServices(services);
        }
    }
}
