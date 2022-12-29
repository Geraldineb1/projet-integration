using Application.DTOs;
using Application.DTOs.Event;
using Application.DTOs.Provider;
using Application.DTOs.Service;
using AutoMapper;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Service, ServiceDto>().ReverseMap();
            CreateMap<Service, ServiceListDto>().ReverseMap();
            CreateMap<Provider, ProviderDto>().ReverseMap();
            CreateMap<Event, EventDto>().ReverseMap();
            CreateMap<ServiceReservation, ServiceReservationDto>().ReverseMap();
            CreateMap<ServiceReservationService, ServiceReservationServiceDto>().ReverseMap();
            CreateMap<ServiceType, ServiceTypeDto>().ReverseMap();
            CreateMap<Ticket, TicketDto>().ReverseMap();
            CreateMap<TicketReservation, TicketReservationDto>().ReverseMap();
        }
    }
}
