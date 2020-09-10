using AMDAuto.Entities.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AMDAuto.Models.Dashboard
{
    public class DashboardStatisticsVM
    {
        public DashboardStatisticsVM()
        {
            Operations = new List<VwMostOperations>();
            CarParts = new List<VwMostCarParts>();
            Clients = new List<VwMostClients>();
        }
        public List<VwMostOperations> Operations { get; set; }
        public List<VwMostCarParts> CarParts { get; set; }
        public List<VwMostClients> Clients { get; set; }
    }
}
