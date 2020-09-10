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
    public class MakeMapper : Profile
    {
        public MakeMapper()
        {
            CreateMap<MakeNames, SelectListItem>()
                .ForMember(src => src.Text, c => c.MapFrom(dest => dest.Name))
                .ForMember(src => src.Value, c => c.MapFrom(dest => dest.Id.ToString()));
            CreateMap<ModelNames, SelectListItem>()
                .ForMember(src => src.Text, c => c.MapFrom(dest => dest.Name))
                .ForMember(src => src.Value, c => c.MapFrom(dest => dest.Id.ToString()));
            CreateMap<ModelVm, ModelNames>();
            CreateMap<ModelNames,ModelVm>();
            CreateMap<MakeVm, MakeNames>();

        }
       
    }
}
