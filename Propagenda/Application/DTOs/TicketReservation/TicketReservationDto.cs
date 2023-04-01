using Application.DTOs.Common;
using Application.DTOs.Event;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.TicketReservation
{
    public class TicketReservationDto : BaseDto
    {
        public int TotalNbTickets { get; set; }
        public EventDto Event { get; set; }
        //public int eventId { get; set; }
    }
}
