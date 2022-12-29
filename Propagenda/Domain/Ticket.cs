using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Ticket : BaseDomainEntity
    {
        public Event Event { get; set; }
        public int EventId { get; set; }
        public int TicketReservationId { get; set; }
    }
}
