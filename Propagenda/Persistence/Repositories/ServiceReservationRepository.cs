using Application.Persistence.Contracts;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Repositories
{
    public class ServiceReservationRepository : GenericRepository<ServiceReservation>, IServiceReservationRepository
    {
        private readonly PropagendaDbContext _dbContext;
        public ServiceReservationRepository(PropagendaDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task ChangeApprovalStatus(ServiceReservation serviceReservation, bool isApproved)
        {
            serviceReservation.IsAccepted = isApproved;
            _dbContext.Entry(serviceReservation).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }

        public async Task ChangeCompletionStatus(ServiceReservation serviceReservation, bool isComplete)
        {
            serviceReservation.IsCompleted = isComplete;
            _dbContext.Entry(serviceReservation).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }

        public async Task<IReadOnlyList<ServiceReservation>> GetAllByUser(string id)
        {
            var serviceReservations = await _dbContext.ServiceReservations
                .Include(q => q.SSR)
                    .ThenInclude(q => q.Service)
                        .ThenInclude(q => q.ServiceType)
                .Include(q => q.SSR)
                    .ThenInclude(q => q.Service)
                        .ThenInclude(q => q.Provider)
                .Where(p => p.ApplicationUserId == id)
                .ToListAsync();
            return serviceReservations;
        }
    }
}
