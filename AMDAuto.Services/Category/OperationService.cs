using AMDAuto.DataAccess.UnitOfWork;
using AMDAuto.Entities;
using AMDAuto.Services.Base;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMDAuto.Services.Category
{
    public class OperationService : BaseService
    {
        public OperationService(AMDAutoUnitOfWork unitOfWork) : base(unitOfWork)
        {

        }

        public async Task<List<Operations>> GetAll(int? categoryId)
        {
            return await UnitOfWork.Operations.Query.Where(c => c.CategoryId == categoryId).ToListAsync();     
        }

        public async Task<List<Operations>> GetAll()
        {
            return await UnitOfWork.Operations.Query.ToListAsync();
        }

        public Operations GetOperationById(Guid id)
        {
            return UnitOfWork.Operations.Query
                .FirstOrDefault(o => o.Id == id);
        }
        public async Task<List<Operations>> GetAllOperations()
        {
            return await UnitOfWork.Operations.Query.ToListAsync();
        }

        public bool AddOperation(Operations operation)
        {
            var entity = UnitOfWork.Operations.Query.FirstOrDefault(o => o.CategoryId == operation.CategoryId && o.Name == operation.Name);
            
            if(entity == null)
            {
                UnitOfWork.Operations.Add(operation);
                return UnitOfWork.SaveChanges();
            }

            else
            {
                return false;
            }
        }
    }
}
