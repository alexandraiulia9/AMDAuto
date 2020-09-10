using AMDAuto.DataAccess.UnitOfWork;
using AMDAuto.Entities;
using AMDAuto.Entities.DTOs;
using AMDAuto.Services.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AMDAuto.Services.User
{
    public class EmployeeService : BaseService
    {
        private readonly CurrentUser currentUser;
        public EmployeeService(CurrentUser currentUser, AMDAutoUnitOfWork unitOfWork) : base(unitOfWork)
        {
            this.currentUser = currentUser;
        }

        public List<Users> GetUsers(int page, int resultsNumber)
        {
            return UnitOfWork.Users.Query
                .Where(u => u.RoleId == Guid.Parse("C3344D80-7E05-4532-A43C-755EF2A21E65"))
                .OrderBy(u => u.Name)
                .Skip((page - 1) * resultsNumber)
                .Take(resultsNumber).ToList();
        }

        public List<Employees> GetEmployees(int page, int resultNumber)
        {
            return UnitOfWork.Employees.Query
                .Include(e => e.User)
                .OrderBy(e => e.User.Name)
                .Skip((page - 1) * resultNumber)
                .Take(resultNumber).ToList();
        }

        public int GetUsersNumber()
        {
            return UnitOfWork.Users.Query.Where(u => u.RoleId == Guid.Parse("C3344D80-7E05-4532-A43C-755EF2A21E65")).Count();
        }
        public List<Users> GetAllUsers()
        {
            return UnitOfWork.Users.Query
                .Where(u => u.RoleId == Guid.Parse("C3344D80-7E05-4532-A43C-755EF2A21E65"))
                .OrderBy(u => u.Name)
                .ToList();
        }

        public List<Employees> GetAllEmployees()
        {
            return UnitOfWork.Employees.Query        
                .Include(e => e.User)
                .OrderBy(e => e.User.Name)
                .Take(5)
                .ToList();
        }

        public int GetEmployeesNumber()
        {
            return UnitOfWork.Employees.Query.Count();
        }

        public Guid GetEmployeeIdOfCurrentUser()
        {
            return UnitOfWork.Employees.Query.Where(e => e.UserId == currentUser.Id).Select(e => e.Id).FirstOrDefault();
        }
    }
}
