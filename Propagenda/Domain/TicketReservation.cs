using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class TicketReservation  : BaseDomainEntity
    {
        public int TotalNbTickets { get; set; }

        // TODO FK
    }
}
