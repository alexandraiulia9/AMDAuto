using AMDAuto.Entities;
using AMDAuto.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AMDAuto.Code.Mappers
{
    public class CommentMapper : Profile
    {
        public CommentMapper()
        {
            CreateMap<Comments, CommentVm>()
                 .ForMember(dest => dest.UserName, c => c.MapFrom(src => src.User.Name));
            CreateMap<CommentVm, Comments>();
        }
    }
}
