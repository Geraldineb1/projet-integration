using Application.Persistence.Contracts;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
