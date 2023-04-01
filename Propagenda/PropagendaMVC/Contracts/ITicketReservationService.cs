using PropagendaMVC.Models;
using PropagendaMVC.Services.Base;

namespace PropagendaMVC.Contracts
{
    public interface ITicketReservationService
    {
        Task<List<TicketReservationListVM>> GetTicketReservations();
        Task<TicketReservationVM> GetTicketReservationDetails(int id);
        Task<Response<int>> CreateTicketReservation(CreateTicketReservationVM ticketReservation);
    }
}
