using Application.Persistence.Contracts;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Repositories
{
    public class ServiceRepository : GenericRepository<Service>, IServiceRepository
    {
        private readonly PropagendaDbContext _dbContext;
        public ServiceRepository(PropagendaDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task ChangeActivationStatus(Service service, bool isActive)
        {
            service.isActive = isActive;
            _dbContext.Entry(service).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }
        public async Task ChangeApprovalStatus(Service service, bool isApproved)
        {
            service.isApproved = isApproved;
            _dbContext.Entry(service).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }

        public async Task<List<Service>> GetServicesWithDetails()
        {
            var services = await _dbContext.Services
                .Include(q => q.ServiceType)
                .ToListAsync();
            return services;
        }

        public async Task<Service> GetServiceWithDetails(int id)
        {
            var service = await _dbContext.Services
                .Include(q => q.ServiceType)
                .FirstOrDefaultAsync(q => q.Id == id);
            return service;
        }
    }
}
