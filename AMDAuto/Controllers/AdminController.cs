using AMDAuto.Code.Base;
using AMDAuto.Entities;
using AMDAuto.Models;
using AMDAuto.Services.Category;
using AMDAuto.Services.Make;
using AMDAuto.Services.Part;
using AMDAuto.Services.User;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AMDAuto.Controllers
{
    public class AdminController : BaseController
    {
        private readonly MakeService makeService;
        private readonly EmployeeService employeeService;
        private readonly UserAccountService userAccountService;
        private readonly ModelService modelService;
        private readonly CategoryService categoryService;
        private readonly OperationService operationService;
        private readonly PartService partService;
        public AdminController(MakeService makeService, EmployeeService employeeService, UserAccountService userAccountService, ModelService modelService, CategoryService categoryService, OperationService operationService, PartService partService, IMapper mapper) : base(mapper)
        {
            this.makeService = makeService;
            this.employeeService = employeeService;
            this.userAccountService = userAccountService;
            this.modelService = modelService;
            this.categoryService = categoryService;
            this.operationService = operationService;
            this.partService = partService;
        }

        [HttpGet]

        public IActionResult EmployeeListView()
        {
            var entities = employeeService.GetAllEmployees();
            var employees = entities.Select(e => mapper.Map<EmployeeItemVm>(e)).ToList();
            var nrOfEmployees = employeeService.GetEmployeesNumber();
            var model = new EmployeeListVm();
            model.EmployeeList = employees;
            model.IsLastPage = nrOfEmployees < entities.Count;
            return View();
        }

        [HttpGet]
        public IActionResult GetEmployees(int page = 2)
        {
            if (page <= 0)
            {
                page = 2;
            }

            var entities = employeeService.GetEmployees(page: page, resultNumber: ResultsPerPage);
            var numberOfEmployees = employeeService.GetEmployeesNumber();
            var employees = entities.Select(e => mapper.Map<EmployeeItemVm>(e)).ToList();
            var model = new EmployeeListVm
            {
                EmployeeList = employees,
                IsLastPage = numberOfEmployees <= ResultsPerPage * (page - 1) + entities.Count
            };

            return Json(model);
        }


        [HttpGet]
        public async Task<IActionResult> AddCarModel()
        {
            var entities = await makeService.GetAll();
            var makes = entities.Select(m => mapper.Map<SelectListItem>(m)).ToList();
            var model = new ModelVm();
            model.Makes = makes;
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> AddCarModel(ModelVm model)
        {
            if (!ModelState.IsValid)
            {
                model.Makes = await GetMakes();
                return View(model);
            }

            var entity = mapper.Map<ModelNames>(model);
            int id = modelService.GetMaxId();
            entity.Id = id + 1;

            var result = modelService.AddModel(entity);
            if (!result)
            {
                return InternalServerErrorView();
            }


            return RedirectToAction("AddCarModel", "Admin");

        }

        [HttpPost]
        public IActionResult AddMake(string makeName)
        {
            if (makeName != null)
            {
                var make = new MakeNames();
                make.Id = makeService.GetMaxId() + 1;
                make.Name = makeName;
                var res = makeService.AddMake(make);
                if (!res)
                {
                    return InternalServerErrorView();
                }
            }
            return RedirectToAction("AddCarModel", "Admin");
        }

        [HttpGet]
        public async Task<IActionResult> AddCarOperation()
        {
            var model = new OperationVm();
            var categories = await GetCategories();
            model.Categories = categories;
            return View(model);
        }

        [HttpPost]
        public IActionResult AddCategory(string catName)
        {
            if (catName != null)
            {
                var category = new Categories();
                category.Id = categoryService.GetMaxId() + 1;
                category.Name = catName;
                var res = categoryService.AddCategory(category);
                if (!res)
                {
                    return InternalServerErrorView();
                }
            }
            return RedirectToAction("AddCarOperation", "Admin");
        }

        [HttpPost]
        public async Task<IActionResult> AddCarOperation(OperationVm model)
        {
            if (!ModelState.IsValid)
            {
                model.Categories = await GetCategories();
                return View(model);
            }

            var entity = mapper.Map<Operations>(model);
            entity.Id = Guid.NewGuid();
            var result = operationService.AddOperation(entity);
            if (!result)
            {
                return InternalServerErrorView();
            }


            return RedirectToAction("AddCarOperation", "Admin");


        }

        [HttpGet]
        public async Task<IActionResult> AddCarParts()
        {
            var model = new CarPartVm();
            var categories = await GetCategories();
            model.Categories = categories;
            return View(model);

        }

        [HttpPost]
        public async Task<IActionResult> AddCarParts(CarPartVm model)
        {
            if (!ModelState.IsValid)
            {
                model.Categories = await GetCategories();
                return View(model);
            }

            var entity = mapper.Map<CarParts>(model);
            var entityId = partService.FindPart(entity);
            if (entityId != Guid.Empty)
            {
                entity.Id = entityId;
                var resultUpdate = partService.UpdateCarPart(entity);
                if (!resultUpdate)
                {
                    return InternalServerErrorView();
                }
                else { return RedirectToAction("AddCarParts", "Admin"); }
            }
            else
            {
                var result = partService.AddCarPartsToBD(entity);
                if (!result)
                {
                    return InternalServerErrorView();
                }
                else { return RedirectToAction("AddCarParts", "Admin"); }
            }

        }

        [HttpPost]
        public IActionResult SetRoleByUserId(Guid userId, string roleName)
        {
            var result = userAccountService.UpdateRole(userId, roleName);
            if (!result)
            {
                return InternalServerErrorView();
            }
            return Ok();
        }

        private async Task<List<SelectListItem>> GetMakes()
        {
            var makes = await makeService.GetAll();
            return makes.Select(m => mapper.Map<SelectListItem>(m)).ToList();
        }

        private async Task<List<SelectListItem>> GetCategories()
        {
            var categories = await categoryService.GetAll();
            return categories.Select(c => mapper.Map<SelectListItem>(c)).ToList();
        }

        private async Task<List<SelectListItem>> GetOperations()
        {
            var operations = await operationService.GetAll();
            return operations.Select(o => mapper.Map<SelectListItem>(o)).ToList();
        }
    }
}
