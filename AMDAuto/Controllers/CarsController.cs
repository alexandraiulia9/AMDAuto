using AMDAuto.Code.Base;
using AMDAuto.Entities;
using AMDAuto.Entities.DTOs;
using AMDAuto.Models;
using AMDAuto.Services.Car;
using AMDAuto.Services.Make;
using AMDAuto.Services.User;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AMDAuto.Controllers
{
    public class CarsController : BaseController
    {
        private readonly CarService carService;
        private readonly CurrentUser currentUser;
        private readonly MakeService makeService;
        private readonly ModelService modelService;
        private readonly UserAccountService userService;
        public CarsController(MakeService makeService, ModelService modelService, CurrentUser currentUser, CarService carService, UserAccountService userService, IMapper mapper) : base(mapper)
        {
            this.makeService = makeService;
            this.modelService = modelService;
            this.currentUser = currentUser;
            this.carService = carService;
            this.userService = userService;
        }

        public IActionResult Cars()
        {
            var entities = carService.Get();
            var cars = entities.Select(c => mapper.Map<CarItemVm>(c)).ToList();
            var model = new UserCarsVm();
            model.UserCars = cars;
            return View(model);
        }

  
       [HttpGet]
        public async Task<IActionResult> AddCar(Guid userId = default(Guid))
        {
            
            var model = new CarVm();
            var user = userService.GetUserById(userId);
            if (currentUser.RoleId == Guid.Parse("0AFC5C07-6201-45E0-85D3-5E8DF6A4EBC1") && userId != Guid.Empty)
            {
                ViewData["Message"] = "Adăugați mașină nouă pentru utilizatorul " + user.Name;
                model.UserId = userId;
            }
            else
            {
                ViewData["Message"] = "Înregistrați-vă mașina!";
            }
            
            model.Makes = await GetMakes();
            return View(model);
           
        }

        [HttpPost]
        public async Task<IActionResult> AddCar(CarVm model)
        {
            if (!ModelState.IsValid)
            {
                model.Makes = await GetMakes();
                return View(model);
            }

            var entity = mapper.Map<Cars>(model);
            var result = carService.RegisterCar(entity, model.UserId);
            if (!result)
            {
                return InternalServerErrorView();
            }

            if(currentUser.RoleId == Guid.Parse("0AFC5C07-6201-45E0-85D3-5E8DF6A4EBC1"))
            {
                return RedirectToAction("GetCarsOfUser", "Cars", new { id = (Guid)model.UserId });
            }
            else
            {
                return RedirectToAction("Cars", "Cars");
            }
            
        }

        [Authorize]
        [HttpPost]
        public IActionResult DeleteCar(Guid id)
        {
            var result = carService.DeleteCar(id);

            if (!result)
            {
                return Ok("Error");
        
            }
            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> EditCar(Guid carId = default(Guid))
        {
            var entity = carService.GetCarById(carId);
            var model = mapper.Map<CarVm>(entity);
           
            if (currentUser.RoleId == Guid.Parse("0AFC5C07-6201-45E0-85D3-5E8DF6A4EBC1") /*&& userId != Guid.Empty*/)
            {
                model.UserId = entity.UserId;
               
            }
            
            model.Makes = await GetMakes();
            model.Models = await GetModels(entity.MakeNameId);
            return View(model);
        }
        
        [HttpPost]
        public async Task<IActionResult> EditCar(CarVm model)
        {
            if (!ModelState.IsValid)
            {
                model.Makes = await GetMakes();
                model.Models = await GetModels(model.MakeNameId);
                return View(model);
            }
            var entity = mapper.Map<Cars>(model);
            var result = carService.UpdateCar(entity, model.UserId);
            if (!result)
            {
                return InternalServerErrorView();
            }
            if (currentUser.RoleId == Guid.Parse("0AFC5C07-6201-45E0-85D3-5E8DF6A4EBC1"))
            {
                return RedirectToAction("GetCarsOfUser", "Cars", new { id = (Guid)model.UserId });
            }
            else
            {
                return RedirectToAction("Cars", "Cars");
            }
            
        }

        [HttpGet]
        public async Task<IActionResult> GetCarsOfUser(Guid id)
        {
            var entities = await carService.GetCarsByUserId(id);
            var cars = entities.Select(c => mapper.Map<CarItemVm>(c)).ToList();
            var model = new UserCarsVm();
            model.UserId = id;
            model.UserCars = cars;
            return View(model);

        }
        private async Task<List<SelectListItem>> GetMakes()
        {
            var makes = await makeService.GetAll();
            return makes.Select(m => mapper.Map<SelectListItem>(m)).ToList();
        }

        
        private async Task<List<SelectListItem>> GetModels(int makeId)
        {
            var makes = await modelService.GetAll(makeId);
            return makes.Select(m => mapper.Map<SelectListItem>(m)).ToList();
        }

    }
}
