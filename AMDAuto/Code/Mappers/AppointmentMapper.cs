using AMDAuto.Entities;
using AMDAuto.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace AMDAuto.Code.Mappers
{
    public class AppointmentMapper : Profile
    {
        public AppointmentMapper()
        {
            CreateMap<Cars, AppointmentVm>()
                .ForMember(src => src.CarId, c => c.MapFrom(dest => dest.Model.Name));
            CreateMap<AppointmentVm, Appointments>();
            CreateMap<Appointments, AppointmentVm>();
            CreateMap<Appointments, AppointmentItemVm>()
                .ForMember(src => src.CarModel, c => c.MapFrom(dest => dest.Car.Model.Name))
                .ForMember(src => src.CarMake, c => c.MapFrom(dest => dest.Car.MakeName.Name))
                .ForMember(src => src.OperationName, c => c.MapFrom(dest => dest.Operation.Name))
                .ForMember(src => src.ScheduledOnDisplay, c => c.MapFrom(dest => dest.ScheduledOn != null ? dest.ScheduledOn.Value.ToString("dd.MM.yyyy") : "Not Specified"))
                .ForMember(src => src.StatusName, c => c.MapFrom(dest => dest.Status))
                .ForMember(src => src.EmployeeName, c => c.MapFrom(dest => dest.Employee.User.Name));

            CreateMap<Appointments, PastAppointmentItemVm>()
                .ForMember(src => src.CarModel, c => c.MapFrom(dest => dest.Car.Model.Name))
                .ForMember(src => src.CarMake, c => c.MapFrom(dest => dest.Car.MakeName.Name))
                .ForMember(src => src.OperationName, c => c.MapFrom(dest => dest.Operation.Name))
                .ForMember(src => src.ScheduledOnDisplay, c => c.MapFrom(dest => dest.ScheduledOn != null ? dest.ScheduledOn.Value.ToString("dd.MM.yyyy") : "Not Specified"))
                .ForMember(src => src.OperationPrice, c => c.MapFrom(dest => dest.Operation.Price))
                .ForMember(src => src.EmployeeName, c => c.MapFrom(dest => dest.Employee.User.Name));
            CreateMap<Appointments, AppointmentDetailsVm>()
                .ForMember(src => src.OperationName, c => c.MapFrom(dest => dest.Operation.Name));
        }
    }
}
