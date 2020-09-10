using AMDAuto.Entities;
using AMDAuto.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AMDAuto.Code.Mappers
{
    public class EmployeeMapper : Profile
    {
        public EmployeeMapper()
        {
            CreateMap<Employees, EmployeeItemVm>()
                .ForMember(src => src.Name, c => c.MapFrom(dest => dest.User.Name));

        }
       
    }
}
