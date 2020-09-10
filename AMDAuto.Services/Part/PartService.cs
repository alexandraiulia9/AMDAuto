using AMDAuto.DataAccess.UnitOfWork;
using AMDAuto.Entities;
using AMDAuto.Services.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMDAuto.Services.Part
{
    public class PartService : BaseService
    {
        public PartService(AMDAutoUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public async Task<List<CarParts>> GetAllParts()
        {
            return await UnitOfWork.CarParts.Query.ToListAsync();
        }

        public async Task<List<CarParts>> GetPartsByOperationId(Guid operationId)
        {
            return await UnitOfWork.CarParts.Query.Where(c => c.OperationId == operationId).ToListAsync();
        }

       public async Task<List<CarPartsUsage>> GetPartsByAppointmentId(Guid appointmentId)
        {
            return await UnitOfWork.CarPartsUsage.Query.
                Where(c => c.AppointmentId == appointmentId)
                .Include(c => c.Part)
                .ToListAsync();
        }

        public bool AddCarPart(Guid carPartId, Guid appointmentId)
        {
            var entity = UnitOfWork.CarPartsUsage.Query.FirstOrDefault(c => c.PartId == carPartId && c.AppointmentId == appointmentId);

            if (entity != null)
            {
                entity.Quantity = entity.Quantity + 1;

            }
            else
            {
                var newEntity = new CarPartsUsage();
                newEntity.PartId = carPartId;
                newEntity.AppointmentId = appointmentId;
                newEntity.Quantity = 1;
                UnitOfWork.CarPartsUsage.Add(newEntity);
            }

            var carPartEntity = UnitOfWork.CarParts.Query.FirstOrDefault(c => c.Id == carPartId);
            carPartEntity.Quantity = carPartEntity.Quantity - 1;

            return UnitOfWork.SaveChanges();
        }

        public bool AddCarPartsToBD(CarParts carPart)
        {
            carPart.Id = Guid.NewGuid();
            var entity = UnitOfWork.CarParts.Query.FirstOrDefault(c => c.Id == carPart.Id);
            if(entity == null)
            {
                UnitOfWork.CarParts.Add(carPart);
                return UnitOfWork.SaveChanges();
            }
            else
            {
                return false;
            }

        }

        public Guid FindPart(CarParts part)
        {
            var entity = UnitOfWork.CarParts.Query.FirstOrDefault(p => p.Id == part.Id || p.OperationId == part.OperationId && p.Name == part.Name);
            if (entity != null)
            {
                return entity.Id;
            }
            else return Guid.Empty;
        }

        public bool UpdateCarPart(CarParts part)
        {
            var existingPart = UnitOfWork.CarParts.Query.FirstOrDefault(p => p.Id == part.Id);
            if (existingPart != null)
            {
                existingPart.Price = part.Price;
                existingPart.Quantity = part.Quantity;
                
            }
            return UnitOfWork.SaveChanges();
        }

        public bool DeletePartFromAppointment(Guid carPartId, Guid appId)
        {

            var carPartUsage = UnitOfWork.CarPartsUsage.Query.FirstOrDefault(c => c.AppointmentId == appId && c.PartId == carPartId);
            var carPart = UnitOfWork.CarParts.Query.FirstOrDefault(c => c.Id == carPartId);
            if (carPartUsage != null)
            {
                if(carPartUsage.Quantity - 1 == 0)
                {
                    UnitOfWork.CarPartsUsage.Remove(carPartUsage);
                    carPart.Quantity = carPart.Quantity + 1;
                }
                else
                {
                    carPartUsage.Quantity = carPartUsage.Quantity - 1;
                    carPart.Quantity = carPart.Quantity + 1;
                }
                
            }
            return UnitOfWork.SaveChanges();


        }
    }
}
