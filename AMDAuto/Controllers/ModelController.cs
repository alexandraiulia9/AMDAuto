using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AMDAuto.Code.Base;
using AMDAuto.Services.Make;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AMDAuto.Controllers
{
    public class ModelController : BaseController     
    {
        private readonly ModelService modelService;
        public ModelController(ModelService modelService, IMapper mapper) : base(mapper)
        {
            this.modelService = modelService;

        }

        public async Task<IActionResult> GetModelByMakeId(int makeId)
        {
            var models = await modelService.GetAll(makeId);
            return Json(models);
        }
    }
}
