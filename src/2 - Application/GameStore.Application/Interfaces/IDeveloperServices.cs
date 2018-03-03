using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using GameStore.Application.DTOS.Developers;
using GameStore.Application.ViewModels;

namespace GameStore.Application.Interfaces
{
    public interface IDeveloperServices
    {
        Task<IEnumerable<DeveloperViewModel>> GetAllDevelopers();
        Task<DeveloperViewModel> GetDeveloperById(Guid developer);
        void InsertDeveloper(AddOrUpdateDeveloperDTO developer);
        void UpdateDeveloper(AddOrUpdateDeveloperDTO developer);
        void DeleteDeveloper(DeveloperViewModel developer);
    }
}