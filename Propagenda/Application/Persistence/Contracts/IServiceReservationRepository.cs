using Domain;

namespace Application.Persistence.Contracts
{
    public interface IServiceReservationRepository : IGenericRepository<ServiceReservation>
    {
        Task ChangeApprovalStatus(ServiceReservation serviceReservation, bool isApproved);
        Task ChangeCompletionStatus(ServiceReservation serviceReservation, bool isComplete);
    }
}
