using AutoMapper;
using PropagendaMVC.Models;
using PropagendaMVC.Services.Base;

namespace PropagendaMVC
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CreateServiceTypeDto, CreateServiceTypeVM>().ReverseMap();
            CreateMap<ServiceTypeDto, ServiceTypeVM>().ReverseMap();

            CreateMap<RegisterVM, RegistrationRequest>().ReverseMap();

            CreateMap<CreateProviderDto, CreateProviderVM>().ReverseMap();
            CreateMap<ProviderDto, ProviderVM>().ReverseMap();
            CreateMap<UpdateProviderDto, UpdateProviderVM>().ReverseMap();
            CreateMap<ProviderDto, UpdateProviderVM>().ReverseMap();
            CreateMap<ProviderDto, ProviderWithServicesVM>().ReverseMap();

            CreateMap<CreateEventDto, CreateEventVM>().ReverseMap();
            CreateMap<EventDto, EventVM>().ReverseMap();

            CreateMap<TicketReservationDto, TicketReservationVM>().ReverseMap();
            CreateMap<TicketReservationDto, TicketReservationListVM>().ReverseMap();
            CreateMap<CreateTicketReservationDto, CreateTicketReservationVM>().ReverseMap();

            CreateMap<ServiceDto, ServiceVM>().ReverseMap();
            CreateMap<CreateServiceDto, CreateServiceVM>().ReverseMap();
            CreateMap<ServiceDto, ServiceListVM>().ReverseMap();
            CreateMap<UpdateServiceDto, ServiceVM>().ReverseMap();





        }
    }
}
