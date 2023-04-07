using Application.DTOs;
using Application.DTOs.Event;
using Application.DTOs.Provider;
using Application.DTOs.Service;
using Application.DTOs.ServiceReservation;
using Application.DTOs.ServiceType;
using Application.DTOs.Ticket;
using Application.DTOs.TicketReservation;
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
            CreateMap<Service, ChangeServiceActivationDto>().ReverseMap();
            CreateMap<Service, ChangeServiceApprovalDto>().ReverseMap();
            CreateMap<Service, CreateServiceDto>().ReverseMap();
            CreateMap<Service, UpdateServiceDto>().ReverseMap();
            CreateMap<Service, ServiceWithoutProviderDto>().ReverseMap();

            CreateMap<Provider, ProviderDto>().ReverseMap();
            CreateMap<Provider, CreateProviderDto>().ReverseMap();
            CreateMap<Provider, UpdateProviderDto>().ReverseMap();
            CreateMap<Provider, ChangeProviderActivationDto>().ReverseMap();
            CreateMap<Provider, ChangeProviderApprovalDto>().ReverseMap();


            CreateMap<Event, EventDto>().ReverseMap();
            CreateMap<Event, CreateEventDto>().ReverseMap();

            CreateMap<ServiceReservation, ServiceReservationDto>().ReverseMap();
            CreateMap<ServiceReservation, CreateServiceReservationDto>().ReverseMap();
            CreateMap<ServiceReservation, ChangeServiceReservationApprovalDto>().ReverseMap();
            CreateMap<ServiceReservation, ChangeServiceReservationCompletionDto>().ReverseMap();

            CreateMap<ServiceType, ServiceTypeDto>().ReverseMap();
            CreateMap<ServiceType, CreateServiceTypeDto>().ReverseMap();

            CreateMap<Ticket, TicketDto>().ReverseMap();
            CreateMap<Ticket, CreateTicketDto>().ReverseMap();

            CreateMap<TicketReservation, TicketReservationDto>().ReverseMap();
            CreateMap<TicketReservation, CreateTicketReservationDto>().ReverseMap();
        }
    }
}
