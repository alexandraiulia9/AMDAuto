using AMDAuto.Code.ExtensionMethods;
using AMDAuto.Entities;
using AMDAuto.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AMDAuto.Code.Mappers
{
    public class GalleryMapper : Profile
    {
        public GalleryMapper()
        {
            CreateMap<AddPhotoVM, Photos>()
                .ForMember(dest => dest.Content, s => s.MapFrom(src => src.Photo.GetBytes()));
            CreateMap<Photos, PhotoVM>();
        }
    }
}
