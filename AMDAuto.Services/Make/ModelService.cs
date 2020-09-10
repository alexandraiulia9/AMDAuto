using AMDAuto.DataAccess.UnitOfWork;
using AMDAuto.Entities;
using AMDAuto.Services.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMDAuto.Services.Make
{
    public class ModelService : BaseService
    {
        public ModelService(AMDAutoUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public async Task<List<ModelNames>> GetAll(int makeId)
        {
            return await UnitOfWork.Models.Query.Where(m => m.MakeId == makeId).ToListAsync();

        }

        public int GetMaxId()
        {
            return UnitOfWork.Models.Query.Select(m => m.Id).Max();

        }

        public bool AddModel(ModelNames entity)
        {
            var model = UnitOfWork.Models.Query.FirstOrDefault(m => m.MakeId == entity.MakeId && m.Name == entity.Name);
            if (model == null)
            {
                UnitOfWork.Models.Add(entity);
                return UnitOfWork.SaveChanges();
            }
            else
            {
                return false;
            }

        }
    }
}
