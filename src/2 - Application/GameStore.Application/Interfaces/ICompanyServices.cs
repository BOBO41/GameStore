using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using GameStore.Application.DTOS.Companies;
using GameStore.Application.ViewModels;

namespace GameStore.Application.Interfaces
{
    public interface ICompanyServices
    {
        Task<IEnumerable<CompanyViewModel>> GetAllCompanies();
        Task<CompanyViewModel> GetCompanyById(Guid id);
        void InsertCompany(AddOrUpdateCompanyDTO company);
        void UpdateCompany(AddOrUpdateCompanyDTO company);
        void DeleteCompany(Guid id);
    }
}