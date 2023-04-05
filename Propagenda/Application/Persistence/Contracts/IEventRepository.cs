using Domain;

namespace Application.Persistence.Contracts
{
    public interface IEventRepository : IGenericRepository<Event>
    {
        Task ChangeNbSoldTickets(Event singleEvent, int nbSoldTickets);
    }
}
