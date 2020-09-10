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

namespace AMDAuto.Services.Car
{
    public class CarService : BaseService
    {
        private readonly CurrentUser currentUser;
        public CarService(CurrentUser currentUser, AMDAutoUnitOfWork unitOfWork) : base(unitOfWork)
        {
            this.currentUser = currentUser;
        }

        public async Task<List<Cars>> GetAllCars()
        {
            return await UnitOfWork.Cars.Query.ToListAsync();
        }
        public List<Cars> Get()
        {
            return UnitOfWork.Cars.Query.Where(c => c.UserId == currentUser.Id)
                .Include(c => c.MakeName)
                .Include(c => c.Model)
                .ToList();

        }

        public Cars GetCarById(Guid id)
        {
            return UnitOfWork.Cars.Query.Where(c => c.Id == id)
                .Include(c => c.MakeName)
                .Include(c => c.Model)
                .FirstOrDefault();
        }
        public async Task<List<Cars>> GetCarsByUserId(Guid? id)
        {
            return await UnitOfWork.Cars.Query.Where(c => c.UserId == id)
                .Include(c => c.MakeName)
                .Include(c => c.Model)
                .ToListAsync();
        }
        public async Task<List<Cars>> GetCarsOfCurrentUser()
        {
            return await UnitOfWork.Cars.Query.Where(c => c.UserId == currentUser.Id).ToListAsync();
        }

        public bool RegisterCar(Cars car, Guid? userId)
        {
            car.Id = Guid.NewGuid();
            car.UserId = userId == null ? currentUser.Id : userId;
            UnitOfWork.Cars.Add(car);

            return UnitOfWork.SaveChanges();

        }
        public bool DeleteCar(Guid id)
        {
            var car = UnitOfWork.Cars.Query.FirstOrDefault(c => c.Id == id);
            if (car != null)
            {
                var appointments = UnitOfWork.Appointments.Query.Where(a => a.CarId == car.Id);
                if (appointments != null)
                {
                    UnitOfWork.Appointments.RemoveRange(appointments);
                }
                UnitOfWork.Cars.Remove(car);
            }

            return UnitOfWork.SaveChanges();
        }

        public bool UpdateCar(Cars car, Guid? userId)
        {
            var existingCar = UnitOfWork.Cars.Query.FirstOrDefault(c => c.Id == car.Id);
            existingCar.UserId = userId == null ? currentUser.Id : userId;
            existingCar.LicenseNumber = car.LicenseNumber;
            existingCar.MakeNameId = car.MakeNameId;
            existingCar.ModelId = car.ModelId;
            existingCar.ReleaseYear = car.ReleaseYear;

            return UnitOfWork.SaveChanges();
        }
    }
}
