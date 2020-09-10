using AMDAuto.Entities.DTOs;
using AMDAuto.Services.Appointment;
using AMDAuto.Services.Car;
using AMDAuto.Services.Category;
using AMDAuto.Services.Comment;
using AMDAuto.Services.Dashboard;
using AMDAuto.Services.Gallery;
using AMDAuto.Services.Make;
using AMDAuto.Services.Part;
using AMDAuto.Services.Review;
using AMDAuto.Services.User;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace AMDAuto.Code.ExtensionMethods
{
    public static class ConfigurationExtensionMethods
    {
        public static IServiceCollection AddBusinessLogic(this IServiceCollection services)
        { 
            services.AddScoped<UserAccountService>();
            services.AddScoped<CarService>();
            services.AddScoped<MakeService>();
            services.AddScoped<ModelService>();
            services.AddScoped<CategoryService>();
            services.AddScoped<OperationService>();
            services.AddScoped<AppointmentService>();
            services.AddScoped<GalleryService>();
            services.AddScoped<ReviewService>();
            services.AddScoped<EmployeeService>();
            services.AddScoped<PartService>();
            services.AddScoped<DashboardService>();
            services.AddScoped<CommentService>();


            return services;
        }

        public static IServiceCollection AddCurrentUser(this IServiceCollection services)
        {
            services.AddScoped(serviceProvider =>
            {
                var contextAccessor = serviceProvider.GetService<IHttpContextAccessor>();
                var context = contextAccessor.HttpContext;
                var mail = context.User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Email)?.Value ?? string.Empty;
                var userService = serviceProvider.GetService<UserAccountService>();

                var user = userService.Get(mail);
                //TODO: map using Automapper from User to CurrentUser
                if (user != null)
                    return new CurrentUser(isAuthenticated: true)
                    {
                        Id = user.Id,
                        Email = user.Email,
                        Name = user.Name,
                        RoleId = user.RoleId
                    };
                else
                    return new CurrentUser(isAuthenticated: false);
            });

            return services;
        }
    }
}
