using AutoMapper;
using GameStore.Application.DTOS.Games;
using GameStore.Application.ViewModels;
using GameStore.Domain.Entities;

namespace GameStore.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile: Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            ShouldMapField = fieldInfo => true;
            ShouldMapProperty = propertyInfo => true;
            CreateMap<GameViewModel, Game>();
            CreateMap<AddOrUpdateGameDTO,Game>();
            CreateMap<DeveloperViewModel,Company>();
        }
    }
}