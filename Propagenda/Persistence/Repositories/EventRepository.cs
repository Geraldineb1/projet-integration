using Application.Persistence.Contracts;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Repositories
{
    public class EventRepository : GenericRepository<Event>, IEventRepository
    {
        private readonly PropagendaDbContext _dbContext;
        public EventRepository(PropagendaDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        
    }
}
