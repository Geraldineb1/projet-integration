using Application.DTOs.Service;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Services.Requests.Commands
{
    public class UpdateServiceCommand : IRequest<Unit>
    {
        public int Id { get; set; }
        public UpdateServiceDto ServiceDto { get; set; }
        public ChangeServiceActivationDto ChangeServiceActivationDto { get; set; }


        
    }
}
