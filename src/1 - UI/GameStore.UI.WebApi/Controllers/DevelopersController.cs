using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using GameStore.Application.Interfaces;
using GameStore.Application.Services;
using GameStore.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace GameStore.UI.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class DevelopersController: Controller
    {
        private IDeveloperServices _services;
        public DevelopersController(IDeveloperServices services)
        {
            _services = services;
        }
        [HttpGet]
        public async Task<IEnumerable<DeveloperViewModel>> Get() {
            return await _services.GetAllDevelopers();
        }
        [HttpGet("{id}")]
        public async Task<DeveloperViewModel> Get(Guid id) {
            return await _services.GetDeveloperById(id);
        }
    }
}