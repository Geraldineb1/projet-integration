using Application.Persistence.Contracts;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Repositories
{
    public class TicketReservationRepository : GenericRepository<TicketReservation>, ITicketReservationRepository
    {
        private readonly PropagendaDbContext _dbContext;
        public TicketReservationRepository(PropagendaDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IReadOnlyList<TicketReservation>> GetAllWithEvent()
        {
            var events = await _dbContext.TicketReservations
                .Include(q => q.Event)
                .ToListAsync();
            return events;
        }
    }
}
