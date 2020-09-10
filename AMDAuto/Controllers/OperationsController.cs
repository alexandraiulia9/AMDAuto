using AMDAuto.Code.Base;
using AMDAuto.Models;
using AMDAuto.Services.Category;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AMDAuto.Controllers
{
    public class OperationsController : BaseController
    {
        private readonly OperationService operationService;
        private readonly CategoryService categoryService;

        public OperationsController(CategoryService categoryService, OperationService operationService, IMapper mapper) : base(mapper)
        {
            this.operationService = operationService;
            this.categoryService = categoryService;
        }

        public async Task<IActionResult> GetOperationByCategoryId(int categoryId)
        {
            var operations = await operationService.GetAll(categoryId);
            return Json(operations);
        }

        public async Task<IActionResult> Services()
        {
            ViewData["Message"] = "Serviciile noastre";
            var model = new ServiceVm();
            model.Categories = await GetCategories();
            return View(model);
        }

        private async Task<List<SelectListItem>> GetCategories()
        {
            var categories = await categoryService.GetAll();
            return categories.Select(m => mapper.Map<SelectListItem>(m)).ToList();
        }
    }
}
