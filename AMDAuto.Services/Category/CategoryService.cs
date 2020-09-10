using AMDAuto.DataAccess.UnitOfWork;
using AMDAuto.Entities;
using AMDAuto.Services.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMDAuto.Services.Category
{
    public class CategoryService : BaseService
    {
        public CategoryService(AMDAutoUnitOfWork unitOfWork) : base(unitOfWork)
        {
           
        }

        public async Task<List<Categories>> GetAll()
        {
            return await UnitOfWork.Categories.Query.ToListAsync();
        }

        public int GetMaxId()
        {
            return UnitOfWork.Categories.Query.Select(c => c.Id).Max();
        }

        public bool AddCategory(Categories category)
        {
            var entity = UnitOfWork.Categories.Query.FirstOrDefault(c => c.Id == category.Id || c.Name.ToUpper() == category.Name.ToUpper());
            if(entity == null)
            {
                UnitOfWork.Categories.Add(category);
                UnitOfWork.SaveChanges();
            }
            return false;
        }
    }
}
