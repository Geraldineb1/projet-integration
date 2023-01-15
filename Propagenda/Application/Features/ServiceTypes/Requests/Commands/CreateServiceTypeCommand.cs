﻿using Application.DTOs;
using Application.DTOs.ServiceType;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.ServiceTypes.Requests.Commands
{
    public class CreateServiceTypeCommand : IRequest<int>
    {
        public CreateServiceTypeDto ServiceTypeDto { get; set; } 
    }
}
