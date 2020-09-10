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
    public class MakeService : BaseService
    {
        public MakeService(AMDAutoUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public async Task<MakeNames> GetMakeById(int makeId)
        {
            return await UnitOfWork.Makes.Query.FirstOrDefaultAsync(m => m.Id == makeId);
        }

        public async Task<List<MakeNames>> GetAll()
        {
            return await UnitOfWork.Makes.Query.OrderBy(m => m.Name).ToListAsync();
        }

        public async Task<string> GetMakeName(int makeId)
        {
            return await UnitOfWork.Makes
                .Query.
                Where(m => m.Id == makeId).Select(m => m.Name).FirstOrDefaultAsync();
        }

        public int GetMaxId()
        {
            return UnitOfWork.Makes.Query.Select(m => m.Id).Max();
        }
        public bool AddMake(MakeNames make)
        {
            UnitOfWork.Makes.Add(make);
            return UnitOfWork.SaveChanges();
        }
    }
}
