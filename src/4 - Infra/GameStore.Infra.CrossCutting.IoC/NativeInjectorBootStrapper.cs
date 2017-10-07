using GameStore.Application.Interfaces;
using GameStore.Application.Services;
using GameStore.Domain.Interfaces.Repositories;
using GameStore.Infra.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace GameStore.Infra.CrossCutting.IoC
{
    public class NativeInjectorBootStrapper
    {
        public static void RegisterServices(IServiceCollection services) {
            services.AddTransient<IGameServices,GameServices>();
            services.AddTransient<IUnitOfWork,UnitOfWork>();
        }
    }
}