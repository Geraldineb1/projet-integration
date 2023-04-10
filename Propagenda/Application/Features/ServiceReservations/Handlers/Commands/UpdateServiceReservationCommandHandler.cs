using Application.Features.ServiceReservations.Requests.Commands;
using Application.Persistence.Contracts;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.ServiceReservations.Handlers.Commands
{
    internal class UpdateServiceReservationCommandHandler : IRequestHandler<UpdateServiceReservationCommand, Unit>
    {
        private readonly IServiceReservationRepository _serviceReservationRepository;
        private readonly IMapper _mapper;
        private readonly DbContext _dbContext;

        public UpdateServiceReservationCommandHandler(IServiceReservationRepository serviceReservationRepository, IMapper mapper)
        {
            _serviceReservationRepository = serviceReservationRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateServiceReservationCommand request, CancellationToken cancellationToken)
        {

            var serviceReservation = await _serviceReservationRepository.Get(request.Id);

            if (request.ServiceReservationDto != null)
            {
                _mapper.Map(request.ServiceReservationDto, serviceReservation);

                await _serviceReservationRepository.Update(serviceReservation);
            }
            else if (request.ChangeServiceReservationApprovalDto != null)
            {
                await _serviceReservationRepository.ChangeApprovalStatus(serviceReservation, request.ChangeServiceReservationApprovalDto.IsAccepted);
            }
            else if (request.ChangeServiceReservationCompletionDto != null)
            {
                await _serviceReservationRepository.ChangeApprovalStatus(serviceReservation, request.ChangeServiceReservationCompletionDto.IsCompleted);
            }

            return Unit.Value;
        }
    }
}
