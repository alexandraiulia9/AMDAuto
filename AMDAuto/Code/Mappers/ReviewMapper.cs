using AMDAuto.Entities;
using AMDAuto.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AMDAuto.Code.Mappers
{
    public class ReviewMapper : Profile
    {
        public ReviewMapper()
        {
            CreateMap<ReviewVm, Reviews>();
            CreateMap<Reviews, AddReviewVM>()
                .ForMember(src => src.CreatedOn, c => c.MapFrom(dest => dest.CreatedOn.Value.ToString("dd.MM.yyyy")));
            CreateMap<AddReviewVM, Reviews>();
            CreateMap<Reviews, ReviewItemVm>()
                .ForMember(dest => dest.UserName, c => c.MapFrom(src => src.User.Name))
                .ForMember(src => src.CreatedOnDisplay, c => c.MapFrom(dest => dest.CreatedOn.Value.ToString("dd.MM.yyyy")));

        }
    }
}
