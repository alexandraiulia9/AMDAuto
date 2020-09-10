using AMDAuto.Code.Base;
using AMDAuto.Models;
using AMDAuto.Services.Appointment;
using AMDAuto.Services.Car;
using AMDAuto.Services.Part;
using AMDAuto.Services.User;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AMDAuto.Controllers
{
    public class EmployeeController : BaseController
    {
        private readonly EmployeeService employeeService;
        private readonly AppointmentService appointmentService;
        private readonly CarService carService;
        private readonly PartService partService;
        public EmployeeController(EmployeeService employeeService, AppointmentService appointmentService, CarService carService, PartService partService, IMapper mapper) : base(mapper)
        {
            this.employeeService = employeeService;
            this.appointmentService = appointmentService;
            this.carService = carService;
            this.partService = partService;
        }

        [HttpGet]
        public async Task<IActionResult> ViewAllAppointments()
        {
            var entities = appointmentService.GetAllPendingAppointments();
            var appointments = entities.Select(a => mapper.Map<AppointmentItemVm>(a)).ToList();
            var model = new PendingAppointmentsList();
            model.PendingAppointments = appointments;
            return View(model);
        }


        [HttpGet]
        public async Task<IActionResult> UserListView()
        {
            var entities = employeeService.GetAllUsers();
            var users = entities.Select(u => mapper.Map<UserVm>(u)).ToList();
            var numberOfUsers = employeeService.GetUsersNumber();

            var roles = await GetRoles();

            foreach(var user in users)
            {
                user.Roles = await GetRoles();
            }

            foreach(var user in users)
            {
                foreach(var item in user.Roles)
                {
                    if(item.Value == user.RoleName)
                    {
                        item.Selected = true;
                        break;
                    }
                }
            }
            var model = new UserListVm();
            model.UserList = users;
            //model.IsLastPage = numberOfUsers < entities.Count;

            return View(model);
        }

       

        //[HttpGet]
        //public IActionResult GetUsers(int page = 2)
        //{
        //    if (page <= 0)
        //        page = 2;

        //    var entities = employeeService.GetUsers(page: page, resultsNumber: ResultsPerPage);
        //    var numberOfUsers = employeeService.GetUsersNumber();
        //    var users = entities.Select(u => mapper.Map<UserVm>(u)).ToList();
        //    var model = new UserListVm
        //    {
        //        UserList = users,
        //        IsLastPage = numberOfUsers <= ResultsPerPage * (page - 1) + entities.Count
        //    };

        //    return Json(model);
        //}


        [HttpGet]
        public IActionResult EmployeeListView()
        {
            var entities = employeeService.GetAllEmployees();
            var employees = entities.Select(e => mapper.Map<EmployeeItemVm>(e)).ToList();
            var model = new EmployeeListVm();
            model.EmployeeList = employees;
            return View(model);
        }


        [HttpGet]
        public async Task<IActionResult> FutureAppointmentsOfEmployee(Guid id)
        {
            var entities = await appointmentService.GetFutureAppointmentsOfEmployee(id);
            var futureAppointments = entities.Select(a => mapper.Map<AppointmentItemVm>(a)).ToList();
            var statuses = await GetStatuses();
            foreach (var app in futureAppointments)
            {
                app.Statuses = await GetStatuses();
            }
            foreach (var appointment in futureAppointments)
            {
                foreach (var item in appointment.Statuses)
                {
                    if (item.Value == appointment.StatusName)
                    {
                        item.Selected = true;
                        break;
                    }
                }
            }

            var model = new EmployeeFutureAppointmentsVm();
            model.FutureAppointments = futureAppointments;
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> PastAppointmentsOfEmployee(Guid id)
        {
            var entities = await appointmentService.GetPastAppointmentsOfEmployee(id);
            var pastAppointments = entities.Select(a => mapper.Map<PastAppointmentItemVm>(a)).ToList();
            
            foreach (var app in pastAppointments)
            {
                var entitiesParts = await partService.GetPartsByAppointmentId(app.Id);
                var parts = entitiesParts.Select(p => mapper.Map<PartVm>(p)).ToList();
                app.Parts = parts;
                app.PartsPrice = parts.Sum(p => p.Quantity * p.Price);
            }
            var model = new EmployeePastAppointmentsVm();
            model.PastAppointments = pastAppointments;
            

            return View(model);
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

        private async Task<List<SelectListItem>> GetRoles()
        {
            var roles = new List<SelectListItem>
            {
                new SelectListItem{Text = "Angajat", Value = "0AFC5C07-6201-45E0-85D3-5E8DF6A4EBC1"},
                new SelectListItem{Text = "Client", Value = "C3344D80-7E05-4532-A43C-755EF2A21E65"}
            };
            return roles;
        }
    }
}
