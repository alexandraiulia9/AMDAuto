using AMDAuto.Entities;
using AMDAuto.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AMDAuto.Code.Mappers
{
    public class CarMapper : Profile
    {
        public CarMapper()
        {
            CreateMap<CarVm, Cars>();
            CreateMap<Cars, CarVm>();
            CreateMap<Cars, CarItemVm>()
                .ForMember(src => src.MakeNameId, c => c.MapFrom(dest => dest.MakeName.Name))
                .ForMember(src => src.ModelNameId, c => c.MapFrom(dest => dest.Model.Name));
            CreateMap<Cars, SelectListItem>()
                .ForMember(src => src.Text, c => c.MapFrom(dest => dest.LicenseNumber))
                .ForMember(src => src.Value, c => c.MapFrom(dest => dest.Id.ToString()));
        }
    }
}
