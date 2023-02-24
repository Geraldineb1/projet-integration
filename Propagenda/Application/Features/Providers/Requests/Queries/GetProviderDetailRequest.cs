using Application.DTOs;
using Application.DTOs.Provider;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Providers.Requests.Queries
{
    public class GetProviderDetailRequest : IRequest<UpdateProviderDto>
    {
        public int Id { get; set; }
    }
}
