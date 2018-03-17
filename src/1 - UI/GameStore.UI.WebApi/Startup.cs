using AutoMapper;
using GameStore.Infra.CrossCutting.IoC;
using GameStore.Infra.Data.Context;
using GameStore.UI.WebApi.Filters;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.Swagger;

namespace GameStore.UI.WebApi {
    public class Startup {
        public Startup (IHostingEnvironment env) {
            var builder = new ConfigurationBuilder ()
                .SetBasePath (env.ContentRootPath)
                .AddJsonFile ("appsettings.json", optional : false, reloadOnChange : true)
                .AddJsonFile ($"appsettings.{env.EnvironmentName}.json", optional : true)
                .AddEnvironmentVariables ();
            Configuration = builder.Build ();
        }

        public IConfigurationRoot Configuration { get; }
        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices (IServiceCollection services) {
            services.AddCors (options => options.AddPolicy ("AllowAllOrigins",
                builder => {
                    builder.AllowAnyOrigin ();
                }));
            services.AddMvc (options => {
                options.Filters.Add (new ApiExceptionFilter ());
            }).AddJsonOptions (
                options => options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);
            services.AddAutoMapper ();
            services.AddDbContext<GameStoreContext> (options =>
                options.UseSqlServer (Configuration.GetConnectionString ("DefaultConnection")));

            services.AddSwaggerGen (c => {
                c.SwaggerDoc ("v1", new Info { Title = "Game Store", Version = "v1" });
            });

            RegisterServices (services);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure (IApplicationBuilder app, IHostingEnvironment env) {
            app.UseDeveloperExceptionPage ();
            app.UseStaticFiles ();
            app.UseCors ("AllowAllOrigins");
            // Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger ();
            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.), specifying the Swagger JSON endpoint.
            app.UseSwaggerUI (c => {
                c.SwaggerEndpoint ("/swagger/v1/swagger.json", "Game Store");
            });
            app.UseMvc ();
        }
        public static void RegisterServices (IServiceCollection services) {
            NativeInjectorBootStrapper.RegisterServices (services);
        }
    }
}