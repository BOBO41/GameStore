using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using GameStore.Application.DTOS.Developers;
using GameStore.Application.Interfaces;
using GameStore.Application.ViewModels;
using GameStore.Domain.Entities;
using GameStore.Domain.Interfaces.Repositories;

namespace GameStore.Application.Services
{
    public class DeveloperServices : IDeveloperServices
    {
        private IUnitOfWork _unit;
        private IMapper _mapper;
        public DeveloperServices(IUnitOfWork unit, IMapper mapper)
        {
            _unit = unit;
            _mapper = mapper;
        }
        public async Task<IEnumerable<DeveloperViewModel>> GetAllDevelopers()
        {
            return _mapper.Map<IEnumerable<DeveloperViewModel>>(await _unit.Developers.GetAllAsync());
        }

        public async Task<DeveloperViewModel> GetDeveloperById(Guid developer)
        {
            return _mapper.Map<DeveloperViewModel>(await _unit.Developers.GetByIdAsync(developer));
        }

        public void InsertDeveloper(AddOrUpdateDeveloperDTO developer)
        {
            _unit.Developers.Add(_mapper.Map<Company>(developer));
        }

        public void UpdateDeveloper(AddOrUpdateDeveloperDTO developer)
        {
            _unit.Developers.Update(_mapper.Map<Company>(developer));
        }
        
        public void DeleteDeveloper(Guid id)
        {
            _unit.Developers.Remove(id);
        }
    }
}