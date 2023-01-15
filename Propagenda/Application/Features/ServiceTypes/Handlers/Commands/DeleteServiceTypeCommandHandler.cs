using Application.Features.ServiceTypes.Requests.Commands;
using Application.Persistence.Contracts;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.ServiceTypes.Handlers.Commands
{
    public class DeleteServiceTypeCommandHandler : IRequestHandler<DeleteServiceTypeCommand>
    {
        private readonly IServiceTypeRepository _serviceTypeRepository;
        private readonly IMapper _mapper;

        public DeleteServiceTypeCommandHandler(IServiceTypeRepository serviceTypeRepository, IMapper mapper)
        {
            _serviceTypeRepository = serviceTypeRepository;
            _mapper = mapper;
        }
        public async Task<Unit> Handle(DeleteServiceTypeCommand request, CancellationToken cancellationToken)
        {
            var serviceType = await _serviceTypeRepository.Get(request.Id);
            await _serviceTypeRepository.Delete(serviceType);
            return Unit.Value;
        }
    }
}
