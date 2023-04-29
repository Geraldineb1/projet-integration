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

        public async Task ChangeNbSoldTickets(Event singleEvent, int nbSoldTickets)
        {
            singleEvent.NbSoldTickets += nbSoldTickets;
            _dbContext.Entry(singleEvent).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }

        public async Task<List<Event>> GetAllEventsByUser(string id)
        {
            var events = await _dbContext.Events
                .Include(q => q.ApplicationUser)
                .Where(p => p.ApplicationUserId == id)
                .ToListAsync();
            return events;
        }

        public new async Task<List<Event>> GetAll()
        {
            var events = await _dbContext.Events.OrderBy(e => e.EventDate)
                .ToListAsync();
            return events;
        }

        public async Task<List<Event>> GetAllEventsToApprove()
        {
            var events = await _dbContext.Events
                .Include(q => q.ApplicationUser)
                .Where(p => p.IsApproved == false && p.IsActive == true)
                .ToListAsync();
            return events;
        }

        public async Task ChangeActivationStatus(Event singleEvent, bool status)
        {
            singleEvent.IsActive = status;
            _dbContext.Entry(singleEvent).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }

        public async Task ChangeApprovalStatus(Event singleEvent, bool status)
        {
            if (status == false)
            {
                singleEvent.IsActive = false;
                singleEvent.IsApproved = false;
            }
            else if(status == true)
            {
                singleEvent.IsActive = true;
                singleEvent.IsApproved = true;
            }
            _dbContext.Entry(singleEvent).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }



    }
}
