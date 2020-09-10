using AMDAuto.DataAccess.UnitOfWork;
using AMDAuto.Entities;
using AMDAuto.Entities.DTOs;
using AMDAuto.Services.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMDAuto.Services.Appointment
{
    public class AppointmentService : BaseService
    {
        private readonly CurrentUser currentUser;
        public AppointmentService(CurrentUser currentUser, AMDAutoUnitOfWork unitOfWork) : base(unitOfWork)
        {
            this.currentUser = currentUser;
        }

        public bool AddAppointment(Appointments appointment)
        {
            appointment.Id = Guid.NewGuid();
            appointment.UserId = appointment.UserId == null ? currentUser.Id : appointment.UserId;
            appointment.ApprovalStatus =/* currentUser.RoleId == Guid.Parse("0AFC5C07-6201-45E0-85D3-5E8DF6A4EBC1") ? "Accepted" :*/ "Pending";
            UnitOfWork.Appointments.Add(appointment);
            return UnitOfWork.SaveChanges();
        }

        public Appointments GetAppointmentById(Guid id)
        {
            return UnitOfWork.Appointments.Query.FirstOrDefault(a => a.Id == id);
        }

        public async Task<List<Appointments>> GetAppointmentsOfCurrentuser()
        {
            return await UnitOfWork.Appointments.Query
                .Where(c => c.UserId == currentUser.Id)
                .Include(a => a.Operation)
                .Include(a => a.User)
                .ToListAsync();
        }

        public async Task<List<Appointments>> GetAppointmentsOfUser(Guid id)
        {
            return await UnitOfWork.Appointments.Query.Where(a => a.UserId == id)
                .Include(a => a.Car.Model)
                .Include(a => a.Car.MakeName)
                .Include(a => a.Operation)
                .Include(a => a.Employee)
                .ThenInclude(a => a.User)
                .Include(a => a.User)
                .ToListAsync();
        }

        public List<Appointments> GetAppointmentsOfCurrentEmployee()
        {
            var employee = UnitOfWork.Employees.Query.FirstOrDefault(e => e.UserId == currentUser.Id);
            return UnitOfWork.Appointments.Query.Where(a => a.EmployeeId == employee.Id && a.ApprovalStatus == "Accepted").Include(a => a.Operation)
                .Include(a => a.User).ToList();
        }

        public List<Appointments> GetPendingAppointmentsOfCurrentEmployee()
        {
            var employee = UnitOfWork.Employees.Query.FirstOrDefault(e => e.UserId == currentUser.Id);
            return UnitOfWork.Appointments.Query.Where(a => a.EmployeeId == employee.Id && a.ApprovalStatus == "Pending").Include(a => a.Operation)
                .Include(a => a.User).ToList();
        }

        public List<Appointments> GetAllPendingAppointments()
        {
            return UnitOfWork.Appointments.Query.Where(a => /*a.ApprovalStatus == "Pending" || a.ApprovalStatus == "Accepted" &&*/ a.EmployeeId == null)
                .Include(a => a.Car.Model)
                .Include(a => a.Car.MakeName)
                .Include(a => a.Operation)
                .Include(a => a.Employee)
                .ThenInclude(a => a.User)
                .Include(a => a.User)
                .ToList();
        }

        public List<Appointments> GetAllAppointmentsOfCurrentUser()
        {
            return UnitOfWork.Appointments.Query
                .Include(a => a.Car.Model)
                .Include(a => a.Car.MakeName)
                .Include(a => a.Operation)
                .Where(a => a.UserId == currentUser.Id && (a.Status.Equals("In progress") || a.Status.Equals("Started") || a.Status == null))
                .ToList();

        }
        public bool DeleteAppointment(Guid id)
        {
            var appointment = UnitOfWork.Appointments.Query.FirstOrDefault(a => a.Id == id);

            if (appointment != null)
            {
                UnitOfWork.Appointments.Remove(appointment);
            }

            return UnitOfWork.SaveChanges();
        }

        public Appointments GetAppointment(Guid id)
        {
            return UnitOfWork.Appointments.Query.Where(a => a.Id == id)
                .Include(a => a.Operation)
                .FirstOrDefault();

        }

        public bool UpdateAppointment(Appointments appointment)
        {
            var existingAppointment = UnitOfWork.Appointments.Query.FirstOrDefault(a => a.Id == appointment.Id);
            existingAppointment.CarId = appointment.CarId;
            existingAppointment.CategoryId = appointment.CategoryId;
            existingAppointment.OperationId = appointment.OperationId;
            //existingAppointment.ScheduledOn = appointment.ScheduledOn;
            if (appointment.EmployeeId != null)
            {
                existingAppointment.EmployeeId = appointment.EmployeeId;
            }
            else
            {
                existingAppointment.EmployeeId = null;
            }
            return UnitOfWork.SaveChanges();
        }

        public bool UpdateAppointmentDate(DateTimeOffset? date, Guid appointmentId)
        {
            var existingAppointment = UnitOfWork.Appointments.Query.FirstOrDefault(a => a.Id == appointmentId);
            existingAppointment.ScheduledOn = date;
            existingAppointment.ApprovalStatus = "Accepted";

            return UnitOfWork.SaveChanges();
        }

        public bool UpdateStatus(Guid appointmentId, string statusName)
        {
            var entity = UnitOfWork.Appointments.Query.FirstOrDefault(a => a.Id == appointmentId);
            entity.Status = statusName;

            return UnitOfWork.SaveChanges();
        }


        public async Task<List<Appointments>> GetPastAppointments()
        {
            return await UnitOfWork.Appointments.Query
                .Include(a => a.Car.Model)
                .Include(a => a.Car.MakeName)
                .Include(a => a.Operation)
                .Include(a => a.CarPartsUsage)
                .Include(a => a.Employee)
                .ThenInclude(a => a.User)
                .Include(a => a.User)
                .Where(a => a.UserId == currentUser.Id && a.Status.Equals("Closed"))
                .ToListAsync();
        }

        public bool CheckAppointmentEditability(Guid appointmentId)
        {
            var entity = UnitOfWork.Appointments.Query.FirstOrDefault(a => a.Id == appointmentId);
            var employee = UnitOfWork.Employees.Query.FirstOrDefault(e => e.UserId == currentUser.Id);
            if(entity != null && employee != null && entity.EmployeeId != Guid.Empty)
            {
                if(entity.EmployeeId == employee.Id)
                {
                    return true;
                }
            }
            return false;
            
        }

        public async Task<List<Appointments>> GetFutureAppointmentsOfEmployee(Guid employeeId)
        {
            var appointments = UnitOfWork.Appointments.Query
                .Where(a => a.EmployeeId == employeeId && !a.Status.Equals("Closed") && a.Status != null)
                .Include(a => a.Car.Model)
                .Include(a => a.Car.MakeName)
                .Include(a => a.Operation)
                .Include(a => a.Employee)
                .ThenInclude(a => a.User)
                .ToListAsync();
            return await appointments;
        }

        public async Task<List<Appointments>> GetPastAppointmentsOfEmployee(Guid employeeId)
        {
            return await UnitOfWork.Appointments.Query
                .Where(a => a.EmployeeId == employeeId && a.Status.Equals("Closed"))
                .Include(a => a.Car.Model)
                .Include(a => a.Car.MakeName)
                .Include(a => a.Operation)
                .Include(a => a.CarPartsUsage)
                .Include(a => a.Employee)
                .ThenInclude(a => a.User)
                .Include(a => a.User)
                .ToListAsync();
        }

    }
}
