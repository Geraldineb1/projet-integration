using PropagendaMVC.Models;
using PropagendaMVC.Services.Base;

namespace PropagendaMVC.Contracts
{
    public interface ITicketReservationService
    {
        Task<List<TicketReservationVM>> GetTicketReservations();
        Task<TicketReservationVM> GetTicketReservationDetails(int id);
        Task<Response<int>> CreateTicketReservation(CreateTicketReservationVM ticketReservation);
    }
}
