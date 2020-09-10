using AMDAuto.DataAccess.UnitOfWork;
using AMDAuto.Entities;
using AMDAuto.Services.Base;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMDAuto.Services.User
{
    public class UserAccountService : BaseService
    {
        public UserAccountService(AMDAutoUnitOfWork unitOfWork)
            :base(unitOfWork)
        {
        }

        public Users GetUserById(Guid? id)
        {
            return UnitOfWork.Users.Query.FirstOrDefault(u => u.Id == id);
        }

        public Users Get(string email)
        {
            return UnitOfWork.Users.Query
                .FirstOrDefault(u => u.Email == email);
        }

        public Users Login(string email, string password)
        {
            return UnitOfWork.Users.Query
                .FirstOrDefault(u => u.Email == email && u.Password == password);
        }

        //TODO: add users in PublicUser role
        public bool Register(Users user)
        {
            user.IsDeleted = false;
            user.CreatedOn = DateTime.Now;
            user.Id = Guid.NewGuid();
            user.RoleId = Guid.Parse("C3344D80-7E05-4532-A43C-755EF2A21E65");
            UnitOfWork.Users.Add(user);
            

            return UnitOfWork.SaveChanges();
        }

        public bool EmailExists(string email)
        {
            return UnitOfWork.Users.Query
                .Any(u => u.Email == email);
        }

        public bool UpdateRole(Guid userId, string roleName)
        {
            var entity = UnitOfWork.Users.Query.FirstOrDefault(u => u.Id == userId);
            if(entity.Appointments.Count != 0)
            {
                var appointments = UnitOfWork.Appointments.Query.Where(a => a.UserId == userId);
                UnitOfWork.Appointments.RemoveRange(appointments);
            }
            entity.RoleId = Guid.Parse(roleName);
            AddUserToEmployees(userId);

            return UnitOfWork.SaveChanges();
        }

        public bool AddUserToEmployees(Guid userId)
        {
            var employee = new Employees();
            employee.Id = Guid.NewGuid();
            employee.UserId = userId;
            UnitOfWork.Employees.Add(employee);

            return UnitOfWork.SaveChanges();

        }
        //public async Task<List<Users>> GetUsersWithFutureAppointments()
        //{
        //    //var usersWithAppointments = UnitOfWork.Users.Query
        //    //     .Include(u => u.Appointments)
        //    //     .Where(u => u.Appointments != null).ToListAsync();
        //    var userIds = UnitOfWork.Appointments
        //                        .Query
        //                        .Where(a => a.ScheduledOn <= DateTime.Now)
        //                        .Include(a => a.User)
        //                        .Select(a => a.UserId)
        //                        .ToListAsync();
        //    var users = UnitOfWork.Users.Query
        //                            .Where(u => userIds.Contains(u.Id))
        //                            .ToListAync();

        //   ]

        //}
    }
}
