using Domain;
using Application.Persistence.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories
{
    public class ServiceServiceReservationRepository : GenericRepository<ServiceServiceReservation>, IServiceServiceReservationRepository
    {
        private readonly PropagendaDbContext _dbContext;
        public ServiceServiceReservationRepository(PropagendaDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
