using Application.DTOs.Common;
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
    }
}
