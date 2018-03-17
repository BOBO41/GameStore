using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using GameStore.Application.DTOS.Plataforms;
using GameStore.Application.ViewModels;

namespace GameStore.Application.Interfaces
{
    public interface IPlataformServices
    {
         Task<IEnumerable<PlataformViewModel>> GetAllPlataforms();
        Task<PlataformViewModel> GetPlataformById(Guid plataform);
        void InsertPlataform(AddOrUpdatePlataformDTO plataform);
        void UpdatePlataform(AddOrUpdatePlataformDTO plataform);
        void DeletePlataform(Guid id);
    }
}