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

        

        /*public int EventId { get; set; }
        public Event Event { get; set; }*/

        public IList<Ticket> Tickets { get; set; }
    }
}
