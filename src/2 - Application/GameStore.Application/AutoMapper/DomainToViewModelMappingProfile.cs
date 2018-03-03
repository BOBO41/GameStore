using AutoMapper;
using GameStore.Application.ViewModels;
using GameStore.Domain.Entities;

namespace GameStore.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile: Profile
    {
        public DomainToViewModelMappingProfile()
        {
            ShouldMapField = fieldInfo => true;
            ShouldMapProperty = propertyInfo => true;
            CreateMap<Game,GameViewModel>();
        }   
    }
}