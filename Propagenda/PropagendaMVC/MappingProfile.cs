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
            CreateMap<UpdateProviderDto, ProviderVM>().ReverseMap();
            CreateMap<ProviderDto, UpdateProviderVM>().ReverseMap();
            CreateMap<ProviderDto, ProviderWithServicesVM>().ReverseMap();
            CreateMap<ChangeProviderApprovalDto, ProviderToApproveVM>().ReverseMap();

            CreateMap<CreateEventDto, CreateEventVM>().ReverseMap();
            CreateMap<EventDto, EventVM>().ReverseMap();
            CreateMap<UpdateEventDto, EventVM>().ReverseMap();
            CreateMap<ChangeEventApprovalDto, EventToApproveVM>().ReverseMap();
            CreateMap<EventDto, EventToApproveVM>().ReverseMap();

            CreateMap<TicketReservationDto, TicketReservationVM>().ReverseMap();
            CreateMap<TicketReservationDto, TicketReservationListVM>().ReverseMap();
            CreateMap<CreateTicketReservationDto, CreateTicketReservationVM>().ReverseMap();

            CreateMap<ServiceDto, ServiceVM>().ReverseMap();
            CreateMap<CreateServiceDto, CreateServiceVM>().ReverseMap();
            CreateMap<ServiceDto, ServiceListVM>().ReverseMap();
            CreateMap<ServiceDto, ServiceToApproveVM>().ReverseMap();
            CreateMap<ChangeServiceApprovalDto, ServiceToApproveVM>().ReverseMap();
            CreateMap<UpdateServiceDto, ServiceVM>().ReverseMap();

            CreateMap<CreateServiceReservationDto, CreateServiceReservationVM>().ReverseMap();
            CreateMap<ServiceReservationDto, ServiceReservationVM>().ReverseMap();
            CreateMap<ServiceReservationDto, ServiceReservationByUserVM>().ReverseMap();






        }
    }
}
