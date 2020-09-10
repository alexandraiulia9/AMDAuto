using AMDAuto.Entities;
using AMDAuto.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AMDAuto.Code.Mappers
{
    public class PartMapper : Profile
    {
        public PartMapper()
        {
            CreateMap<CarPartsUsage, PartVm>()
                .ForMember(src => src.Name, p => p.MapFrom(dest => dest.Part.Name))
                .ForMember(src => src.Price, p => p.MapFrom(dest => dest.Part.Price));

            CreateMap<PartVm, CarPartsUsage>();
        }

    }
}
