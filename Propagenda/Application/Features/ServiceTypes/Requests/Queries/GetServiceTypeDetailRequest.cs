﻿using Application.DTOs;
using Application.DTOs.ServiceType;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.ServiceTypes.Requests.Queries
{
    public class GetServiceTypeDetailRequest : IRequest<ServiceTypeDto>
    {
        public int Id { get; set; }
    }
}
