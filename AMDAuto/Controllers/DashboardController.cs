using AMDAuto.Code.Base;
using AMDAuto.Models.Dashboard;
using AMDAuto.Services.Dashboard;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AMDAuto.Controllers
{
    public class DashboardController : BaseController
    {
        private readonly DashboardService dashboardService;
        public DashboardController(DashboardService dashboardService, IMapper mapper) : base(mapper)
        {
            this.dashboardService = dashboardService;
        }

        public IActionResult GetStatistics()
        {
            var mostCarParts = dashboardService.GetMostCarParts();
            var mostOperations = dashboardService.GetMostOperations();
            var mostClients = dashboardService.GetMostClients();
            var model = new DashboardStatisticsVM();
            model.Clients = mostClients;
            model.Operations = mostOperations;
            model.CarParts = mostCarParts;


            return Json(model);
        }

        public IActionResult ShowReports()
        {
            
            return View();
        }
    }
}
