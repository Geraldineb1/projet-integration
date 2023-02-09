﻿using AutoMapper;
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
        }
    }
}