using Application.Persistence.Contracts;
using Domain;

namespace Persistence.Repositories
{
    public class TicketReservationRepository : GenericRepository<TicketReservation>, ITicketReservationRepository
    {
        private readonly PropagendaDbContext _dbContext;
        public TicketReservationRepository(PropagendaDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
