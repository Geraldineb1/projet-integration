using Application.DTOs.Provider;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Providers.Requests.Commands
{
    public class UpdateProviderCommand : IRequest<Unit>
    {
        public int Id { get; set; }
        public UpdateProviderDto ProviderDto { get; set; }
        public ChangeProviderActivationDto ChangeProviderActivationDto { get; set; }
        public ChangeProviderApprovalDto ChangeProviderApprovalDto { get; set; }
    }
}
