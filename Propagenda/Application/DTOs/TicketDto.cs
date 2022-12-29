using Application.DTOs.Common;
using Application.DTOs.Event;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs
{
    public class TicketDto : BaseDto
    {
        public EventDto Event { get; set; }
        public int EventId { get; set; }
        public int TicketReservationId { get; set; }
    }
}
