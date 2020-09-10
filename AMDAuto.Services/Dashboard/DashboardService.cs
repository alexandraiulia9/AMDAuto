using AMDAuto.DataAccess.UnitOfWork;
using AMDAuto.Entities.Views;
using AMDAuto.Services.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AMDAuto.Services.Dashboard
{
    public class DashboardService : BaseService
    {
        public DashboardService(AMDAutoUnitOfWork unitOfWork) : base(unitOfWork)
        {

        }

        public List<VwMostOperations> GetMostOperations()
        {
            return UnitOfWork.MostOperations.View.ToList();
        }
        public List<VwMostClients> GetMostClients()
        {
            return UnitOfWork.MostClients.View.ToList();
        }

        public List<VwMostCarParts> GetMostCarParts()
        {
            return UnitOfWork.MostCarParts.View.ToList();
        }
    }
}
