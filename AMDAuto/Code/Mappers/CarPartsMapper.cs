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
    public class CarPartsMapper : Profile
    {
        public CarPartsMapper()
        {
            CreateMap<CarParts, SelectListItem>()
                .ForMember(src => src.Text, c => c.MapFrom(dest => dest.Name))
                .ForMember(src => src.Value, c => c.MapFrom(dest => dest.Id.ToString()));
            CreateMap<CarPartsUsage, CarPartsUsageVM>()
                .ForMember(src => src.Name, c => c.MapFrom(dest => dest.Part.Name));
            CreateMap<CarPartVm, CarParts>();

        }

    }
}
