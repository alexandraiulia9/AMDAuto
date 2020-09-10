using AMDAuto.Entities;
using AMDAuto.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AMDAuto.Code.Mappers
{
    public class UserMapper : Profile
    {
        public UserMapper()
        {
            CreateMap<Users,UserVm>();
        }
    }
}
