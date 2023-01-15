using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Persistence.Contracts
{
    public interface IServiceReservationRepository : IGenericRepository<ServiceReservation>
    {
        Task ChangeApprovalStatus(ServiceReservation serviceReservation, bool isApproved);
        Task ChangeCompletionStatus(ServiceReservation serviceReservation, bool isComplete);
    }
}
