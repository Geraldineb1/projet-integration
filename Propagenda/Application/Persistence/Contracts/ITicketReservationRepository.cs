using Domain;

namespace Application.Persistence.Contracts
{
    public interface ITicketReservationRepository : IGenericRepository<TicketReservation>
    {
        Task<IReadOnlyList<TicketReservation>> GetAllWithEvent();
    }
}
