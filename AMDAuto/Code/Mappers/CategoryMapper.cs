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
    public class CategoryMapper : Profile
    {
        public CategoryMapper()
        {
            CreateMap<Categories, SelectListItem>()
                .ForMember(src => src.Text, c => c.MapFrom(dest => dest.Name))
                .ForMember(src => src.Value, c => c.MapFrom(dest => dest.Id.ToString()));
            CreateMap<Operations, SelectListItem>()
                .ForMember(src => src.Text, c => c.MapFrom(dest => dest.Name))
                .ForMember(src => src.Value, c => c.MapFrom(dest => dest.Id.ToString()));
            CreateMap<OperationVm, Operations>();
        }
    }
}
