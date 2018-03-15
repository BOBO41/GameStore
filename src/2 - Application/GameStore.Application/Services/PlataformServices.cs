using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using GameStore.Application.DTOS.Plataforms;
using GameStore.Application.Interfaces;
using GameStore.Application.ViewModels;
using GameStore.Domain.Entities;
using GameStore.Domain.Interfaces.Repositories;

namespace GameStore.Application.Services
{
    public class PlataformServices: IPlataformServices
    {
        private IUnitOfWork _unit;
        private IMapper _mapper;
        public PlataformServices(IUnitOfWork unit, IMapper mapper)
        {
            _unit = unit;
            _mapper = mapper;
        }

        public async Task<IEnumerable<PlataformViewModel>> GetAllPlataforms()
        {
            return _mapper.Map<IEnumerable<PlataformViewModel>>(await _unit.Plataforms.GetAllAsync());
        }

        public async Task<PlataformViewModel> GetPlataformById(Guid id)
        {
            return _mapper.Map<PlataformViewModel>(await _unit.Games.GetByIdAsync(id));
        }
        public void InsertPlataform(AddOrUpdatePlataformDTO plataform)
        {
            _unit.Plataforms.Add(_mapper.Map<Plataform>(plataform));
        }
        public void UpdatePlataform(AddOrUpdatePlataformDTO plataform)
        {
            _unit.Plataforms.Update(_mapper.Map<Plataform>(plataform));
        }
        public void DeletePlataform(Guid id)
        {
            _unit.Plataforms.Remove(id);
        }
    }
}