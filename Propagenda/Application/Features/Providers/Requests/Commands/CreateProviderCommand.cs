using Application.DTOs.Provider;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Providers.Requests.Commands
{
    public class CreateProviderCommand : IRequest<int>
    {
        public ProviderDto ProviderDto { get; set; }
    }
}
