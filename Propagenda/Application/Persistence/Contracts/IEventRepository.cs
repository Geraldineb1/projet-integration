using Domain;

namespace Application.Persistence.Contracts
{
    public interface IEventRepository : IGenericRepository<Event>
    {
        Task ChangeNbSoldTickets(Event singleEvent, int nbSoldTickets);

        Task<List<Event>> GetAllEventsByUser(string id);
        Task<List<Event>> GetAllEventsToApprove();
        Task ChangeActivationStatus(Event singleEvent, bool isActive);
        Task ChangeApprovalStatus(Event singleEvent, bool isApproved);
    }
}
