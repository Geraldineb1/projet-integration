using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Event : BaseDomainEntity
    {
        public string Title { get; set; }
        public string Descrition { get; set; }
        public DateTime EventDate { get; set; }
        public string VenueName { get; set; }
        public string VenueAddress { get; set; }
        public int TicketsAmount { get; set; }
        public int NbSoldTickets { get; set; }
        public int TicketPrice { get; set; }

        //TODO link Ticket + user + service rsv

        public IList<Ticket> Tickets { get; set; }



    }
}
