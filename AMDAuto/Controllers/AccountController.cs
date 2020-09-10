using AMDAuto.Code.Base;
using AMDAuto.Entities;
using AMDAuto.Models;
using AMDAuto.Services.Make;
using AMDAuto.Services.User;
using AutoMapper;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace AMDAuto.Controllers
{
    public class AccountController : BaseController
    {
        private readonly UserAccountService userAccountService;

        public AccountController(UserAccountService userAccountService, IMapper mapper) : base(mapper)
        {
            this.userAccountService = userAccountService;
          
        }

        [HttpGet]
        public async Task<IActionResult> Register()
        {
            var model = new RegisterVm();
            return View(model);
        }

        [HttpPost]
        public IActionResult Register(RegisterVm model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var entity = mapper.Map<Users>(model);

            var result = userAccountService.Register(entity);
            if (!result)
            {
                // din BaseController, actiunea InternalServerErrorView
                return InternalServerErrorView();
            }

            // RedirectToAction(actionName, controllerName)
            return RedirectToAction("LogIn", "Account");

        }

        /* --------------------------------------------------------L O G I N-------------------------------------------------------------------*/

        [HttpGet]
        public IActionResult LogIn()
        {
            var model = new LoginVm();
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> LogIn(LoginVm model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            //returneaza un user cu email-ul si parola din model, daca acesta exista
            var user = userAccountService.Login(model.Email, model.Password);
            if(user == null)
            {
                model.CredentialsInvalid = true;
                return View(model);
            }

            await LogIn(user);

            return RedirectToAction("Index", "Home");
        }

        public async Task LogIn(Users user)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, user.Name),
                new Claim(ClaimTypes.Email, user.Email),
            };

            var identity = new ClaimsIdentity(claims, "Cookies");
            var principal = new ClaimsPrincipal(identity);

            await HttpContext.SignInAsync(scheme: "AMDAutoCookies", principal: principal);
        }

        private async Task LogOut()
        {
            await HttpContext.SignOutAsync(scheme: "AMDAutoCookies");
        }

        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await LogOut();
            return RedirectToAction("Index", "Home");
        }

      
    }
}
