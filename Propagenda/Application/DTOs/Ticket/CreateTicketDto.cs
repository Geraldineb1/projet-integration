using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.Ticket
{
    public class CreateTicketDto
    {
        
        public int EventId { get; set; }
        public int TicketReservationId { get; set; }
    }
}
