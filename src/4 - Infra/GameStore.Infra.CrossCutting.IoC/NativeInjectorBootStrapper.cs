using AutoMapper;
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
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddTransient<IGameServices, GameServices>();
            services.AddTransient<ICompanyServices, CompanyServices>();
            services.AddTransient<IGenreServices, GenreServices>();
            services.AddTransient<IPlataformServices, PlataformServices>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddSingleton(Mapper.Configuration);
            services.AddScoped<IMapper>(sp => new Mapper(sp.GetRequiredService<AutoMapper.IConfigurationProvider>(), sp.GetService));
        }
    }
}