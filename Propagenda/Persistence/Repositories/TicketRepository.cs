using Application.Persistence.Contracts;
using Domain;

namespace Persistence.Repositories
{
    public class TicketRepository : GenericRepository<Ticket>, ITicketRepository
    {
        private readonly PropagendaDbContext _dbContext;
        public TicketRepository(PropagendaDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
