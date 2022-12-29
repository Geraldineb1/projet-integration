﻿using Application.DTOs.Service;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Services.Requests.Commands
{
    public class CreateServiceCommand : IRequest<int>
    {
        public ServiceDto serviceDto { get; set; }
    }
}