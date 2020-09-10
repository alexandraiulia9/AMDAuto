using AMDAuto.Code.Base;
using AMDAuto.Models;
using AMDAuto.Services.Appointment;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AMDAuto.Controllers
{
    public class ScheduleController : BaseController
    {
        private readonly AppointmentService appointmentService;
        public ScheduleController(AppointmentService appointmentService, IMapper mapper) : base(mapper)
        {
            this.appointmentService = appointmentService;
        }

        [HttpGet]
        public IActionResult EmployeeSchedule()
        {
            var appointments = appointmentService.GetAppointmentsOfCurrentEmployee();
            var pendingAppointments = appointmentService.GetPendingAppointmentsOfCurrentEmployee();

            var model = new EmployeeScheduleVM();
            foreach (var appointment in appointments)
            {
                var dateEvent = new DateEvents
                {
                    Title = $"{appointment.User.Name} - {appointment.Operation.Name}",
                    Start = appointment.ScheduledOn,
                    End = appointment.ScheduledOn.Value.AddMinutes((double)appointment.Operation.Duration),
                    Id = appointment.Id
                };

                model.Appointments.Add(dateEvent);
            }

            foreach(var appointment in pendingAppointments)
            {
                var dateEvent = new DateEvents
                {
                    Title = $"{appointment.User.Name} - {appointment.Operation.Name}",
                    Duration = appointment.Operation.Duration,
                    Id = appointment.Id
                };

                model.PendingAppointments.Add(dateEvent);
            }
            return View(model);
        }

        [HttpPost]
        public IActionResult SetAppointmentDate(string date, Guid appointmentId)
        {
            var parsedDate = DateTimeOffset.Parse(date);

            appointmentService.UpdateAppointmentDate(parsedDate, appointmentId);

            return Ok();
        }
    }
}
