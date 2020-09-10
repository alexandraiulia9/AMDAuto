using AMDAuto.Code.Base;
using AMDAuto.Services.Part;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AMDAuto.Controllers
{
    public class CarPartController : BaseController
    {
        private readonly PartService partService;

        public CarPartController(PartService partService, IMapper mapper) : base(mapper)
        {
            this.partService = partService;
        }

        [HttpPost]
        
        public IActionResult AddCarPart(Guid carPartId, Guid appointmentId)
        {
            var result = partService.AddCarPart(carPartId, appointmentId);

            if (!result)
            {
                return InternalServerErrorView();
            }

            return Ok();
        }

        public IActionResult DeleteCarPartFromAppointment(Guid carPartId, Guid appointmentId)
        {
            var result = partService.DeletePartFromAppointment(carPartId, appointmentId);

            if (!result)
            {
                return InternalServerErrorView();
            }

            return Ok();

        }
    }
}
