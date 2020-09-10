using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AMDAuto.Code.Base;
using AMDAuto.Entities;
using AMDAuto.Entities.DTOs;
using AMDAuto.Models;
using AMDAuto.Services.Appointment;
using AMDAuto.Services.Car;
using AMDAuto.Services.Category;
using AMDAuto.Services.Part;
using AMDAuto.Services.User;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AMDAuto.Controllers
{
    public class AppointmentController : BaseController
    {
        private readonly CarService carService;
        private readonly CategoryService categoryService;
        private readonly AppointmentService appointmentService;

        private readonly OperationService operationService;
        private readonly PartService partService;
        private readonly EmployeeService employeeService;
        private readonly CurrentUser currentUser;
        private readonly UserAccountService userService;


        public AppointmentController(CurrentUser currentUser, EmployeeService employeeService, CarService carService, CategoryService categoryService, AppointmentService appointmentService, OperationService operationService, PartService partService, UserAccountService userService, IMapper mapper) : base(mapper)
        {
            this.currentUser = currentUser;
            this.carService = carService;
            this.categoryService = categoryService;
            this.appointmentService = appointmentService;
            this.operationService = operationService;
            this.partService = partService;
            this.employeeService = employeeService;
            this.userService = userService;

        }

        [HttpGet]
        public async Task<IActionResult> MakeAppointment(Guid id = default(Guid))
        {
            ViewData["Message"] = "Vino cu mașina ta la noi!";
            var model = new AppointmentVm();
            //{
            //    ScheduledOn = DateTime.Today
            //};
            var user = userService.GetUserById(id);

            if (currentUser.RoleId == Guid.Parse("0AFC5C07-6201-45E0-85D3-5E8DF6A4EBC1") /*&& userId != Guid.Empty*/)
            {
                ViewData["Message"] = "Programare nouă pentru " + user.Name;
                model.Cars = await GetCarsOfUser(id);
                model.UserId = id;
            }

            else
            {
                model.Cars = await GetUserCars();
            }
            model.Categories = await GetCategories();
            return View(model);
        }


        [HttpPost]
        public async Task<IActionResult> MakeAppointment(AppointmentVm model)
        {
            if (!ModelState.IsValid)
            {
                model.Cars = await GetUserCars();
                model.Categories = await GetCategories();
                return View(model);
            }

            var entity = mapper.Map<Appointments>(model);
            var result = appointmentService.AddAppointment(entity);

            if (!result)
            {
                return InternalServerErrorView();
            }

            if (model.UserId == null)
            {
                return RedirectToAction("FutureAppointments", "Appointment");
            }
            else
            {
                return RedirectToAction("GetAppointmentsOfUser", "Appointment", new { id = model.UserId });
            }
        }

        [HttpGet]

        public async Task<IActionResult> MakeAppointmentForCar(Guid id)
        {
            var entity = carService.GetCarById(id);
            ViewData["Message"] = "Programare pentru " + entity.LicenseNumber;
            //var model = mapper.Map<AppointmentVm>(entity);
            var model = new AppointmentVm();
            model.CarId = id;
            //model.ScheduledOn = DateTime.Today;
            model.Cars = await GetUserCars();
            model.Categories = await GetCategories();
            return View(model);
        }

        [HttpPost]

        public async Task<IActionResult> MakeAppointmentForCar(AppointmentVm model)
        {
            if (!ModelState.IsValid)
            {
                model.CarId = model.CarId;
                model.Cars = await GetUserCars();
                model.Categories = await GetCategories();
            }
            var entity = mapper.Map<Appointments>(model);
            var result = appointmentService.AddAppointment(entity);
            if (!result)
            {
                return InternalServerErrorView();
            }
            return RedirectToAction("FutureAppointments", "Appointment");
        }


        [Authorize]
        [HttpPost]
        public IActionResult DeleteAppointment(Guid id)
        {
            var entity = appointmentService.GetAppointmentById(id);
            var result = appointmentService.DeleteAppointment(id);

            if (!result)
            {
                return Ok("Error");
            }

            return Ok();
        }

        public IActionResult FutureAppointments()
        {
            var entities = appointmentService.GetAllAppointmentsOfCurrentUser();
            var appointments = entities.Select(a => mapper.Map<AppointmentItemVm>(a)).ToList();
            var model = new UserAppointmentsVm();
            model.UserAppointments = appointments;
            return View(model);
        }


        [HttpGet]
        public async Task<IActionResult> EditAppointment(Guid id = default(Guid))
        {
            var entity = appointmentService.GetAppointmentById(id); //am tras programarea din baza cu toate proprietatile
            //vreau sa mapez entitatea la model
            var model = mapper.Map<AppointmentVm>(entity);
            var appointment = appointmentService.GetAppointmentById(id);
            var user = userService.GetUserById(appointment.UserId);
            if (currentUser.RoleId == Guid.Parse("0AFC5C07-6201-45E0-85D3-5E8DF6A4EBC1") /*&& userId != Guid.Empty*/)
            {
                ViewData["Message"] = "Editează programare pentru " + user.Name;
                model.Cars = await GetCarsOfUser(user.Id);
                model.UserId = user.Id;
               
            }
            else
            {
                model.Cars = await GetUserCars();
            }

            model.Categories = await GetCategories();
            model.Operations = await GetOperations(entity.CategoryId);

            return View(model);

        }

        [HttpPost]
        public async Task<IActionResult> EditAppointment(AppointmentVm model)
        {
            if (!ModelState.IsValid)
            {
                model.Cars = await GetCarsOfUser(model.UserId);
                model.Categories = await GetCategories();
                model.Operations = await GetOperations(model.CategoryId);
                return View(model);
            }
            var entity = mapper.Map<Appointments>(model);
            var result = appointmentService.UpdateAppointment(entity);
            if (!result)
            {
                return InternalServerErrorView();
            }
            if (currentUser.RoleId == Guid.Parse("C3344D80-7E05-4532-A43C-755EF2A21E65"))
            {
                return RedirectToAction("FutureAppointments", "Appointment");
            }
            else
            {
                return RedirectToAction("GetAppointmentsOfUser", "Appointment", new { id = model.UserId });
            }
        }

        public async Task<IActionResult> History()
        {
            var entitiesApp = await appointmentService.GetPastAppointments();
            var pastAppointments = entitiesApp.Select(a => mapper.Map<PastAppointmentItemVm>(a)).ToList();

            foreach (var app in pastAppointments)
            {
                var entitiesParts = await partService.GetPartsByAppointmentId(app.Id);
                var parts = entitiesParts.Select(p => mapper.Map<PartVm>(p)).ToList();
                app.Parts = parts;
                app.PartsPrice = parts.Sum(p => p.Quantity * p.Price);
            }

            var model = new UserPastAppointmentsVm();

            model.PastAppointmentsList = pastAppointments;

            return View(model);
        }

        public async Task<IActionResult> GetAppointmentsOfUser(Guid id)
        {
            var entities = await appointmentService.GetAppointmentsOfUser(id);
            var appointments = entities.Select(a => mapper.Map<AppointmentItemVm>(a)).ToList();
            var statuses = await GetStatuses();
            foreach (var app in appointments)
            {
                app.Statuses = await GetStatuses();
            }
            foreach (var appointment in appointments)
            {
                foreach (var item in appointment.Statuses)
                {
                    if (item.Value == appointment.StatusName)
                    {
                        item.Selected = true;
                        break;
                    }
                }

                appointment.IsEditable = appointmentService.CheckAppointmentEditability(appointment.Id);
            }
            var model = new UserAppointmentsVm();
            model.UserId = id;
            model.UserAppointments = appointments;
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> AppointmentDetails(Guid id)
        {
            var entity = appointmentService.GetAppointment(id);
            var model = mapper.Map<AppointmentDetailsVm>(entity);
            var currentEmployeeId = employeeService.GetEmployeeIdOfCurrentUser();
            if (currentEmployeeId != null && currentEmployeeId == entity.EmployeeId || currentUser.RoleId == Guid.Parse("DC043412-4FF5-4C80-BC4F-7F6C37F851C0"))
            {
                var existingParts = await partService.GetPartsByAppointmentId(id);

                model.PartsUsed = existingParts.Select(p => mapper.Map<CarPartsUsageVM>(p)).ToList();
                model.PartsToSelect = await GetPartsForDropdown(model.OperationId);
                model.Statuses = await GetStatuses();

                return View(model);
            }
            else
            {
                return ForbidView();
            }

        }

        [HttpPost]
        public IActionResult SetStatusByAppointmentId(Guid appointmentId, string statusName)
        {
            var result = appointmentService.UpdateStatus(appointmentId, statusName);

            return Ok();
        }

        [HttpPost]
        public IActionResult TakeAppointment(Guid id)
        {
            var entity = appointmentService.GetAppointmentById(id);
            var currentEmployeeId = employeeService.GetEmployeeIdOfCurrentUser();
            if (entity.EmployeeId == null)
            {
                entity.EmployeeId = currentEmployeeId;
                appointmentService.UpdateAppointment(entity);
            }
            return Ok();

        }

        private async Task<List<SelectListItem>> GetAllCars()
        {
            var cars = await carService.GetAllCars();
            return cars.Select(m => mapper.Map<SelectListItem>(m)).ToList();
        }

        private async Task<List<SelectListItem>> GetCarsOfUser(Guid? userId)
        {
            var cars = await carService.GetCarsByUserId(userId);
            return cars.Select(m => mapper.Map<SelectListItem>(m)).ToList();
        }

        private async Task<List<SelectListItem>> GetUserCars()
        {
            var cars = await carService.GetCarsOfCurrentUser();
            return cars.Select(m => mapper.Map<SelectListItem>(m)).ToList();
        }

        private async Task<List<SelectListItem>> GetCategories()
        {
            var categories = await categoryService.GetAll();
            return categories.Select(m => mapper.Map<SelectListItem>(m)).ToList();
        }


        private async Task<List<SelectListItem>> GetOperations(int? categoryId)
        {
            var operations = await operationService.GetAll(categoryId);
            return operations.Select(m => mapper.Map<SelectListItem>(m)).ToList();
        }

        private async Task<List<SelectListItem>> GetPartsForDropdown(Guid operationId)
        {
            var parts = await partService.GetPartsByOperationId(operationId);
            return parts.Select(p => mapper.Map<SelectListItem>(p)).ToList();
        }

        private async Task<List<SelectListItem>> GetStatuses()
        {
            var statuses = new List<SelectListItem>
            {
                new SelectListItem{ Text = "Started", Value = "Started"},
                new SelectListItem { Text = "In progress", Value = "In progress"},
                new SelectListItem{ Text = "Closed", Value = "Closed"}

            };
            return statuses;
        }

    }
}
