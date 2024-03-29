﻿using Application.DTOs.Service;
using Application.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Services.Requests.Commands
{
    public class CreateServiceCommand : IRequest<BaseCommandResponse>
    {
        public CreateServiceDto ServiceDto { get; set; }
    }
}
