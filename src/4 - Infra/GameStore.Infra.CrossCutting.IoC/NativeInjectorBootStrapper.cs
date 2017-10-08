using GameStore.Application.Interfaces;
using GameStore.Application.Services;
using GameStore.Domain.Interfaces.Repositories;
using GameStore.Infra.Data.Context;
using GameStore.Infra.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace GameStore.Infra.CrossCutting.IoC
{
    public class NativeInjectorBootStrapper
    {
        public IConfigurationRoot Configuration { get; }
        
        public void RegisterServices(IServiceCollection services) {
            
            services.AddTransient<IGameServices,GameServices>();
            services.AddTransient<IUnitOfWork,UnitOfWork>();

            services.AddDbContext<GameStoreContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
        }
    }
}