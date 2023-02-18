using Application.Persistence.Contracts;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Repositories
{
    public class ProviderRepository : GenericRepository<Provider>, IProviderRepository
    {
        private readonly PropagendaDbContext _dbContext;
        public ProviderRepository(PropagendaDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task ChangeActivationStatus(Provider provider, bool isActive)
        {
            provider.IsActive = isActive;
            _dbContext.Entry(provider).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }

        public async Task ChangeApprovalStatus(Provider provider, bool isApproved)
        {
            provider.IsApproved = isApproved;
            _dbContext.Entry(provider).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }
    }
}
