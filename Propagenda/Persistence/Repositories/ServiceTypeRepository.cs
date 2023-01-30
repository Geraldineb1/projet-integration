using Application.Persistence.Contracts;
using Domain;

namespace Persistence.Repositories
{
    public class ServiceTypeRepository : GenericRepository<ServiceType>, IServiceTypeRepository
    {
        private readonly PropagendaDbContext _dbContext;
        public ServiceTypeRepository(PropagendaDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
