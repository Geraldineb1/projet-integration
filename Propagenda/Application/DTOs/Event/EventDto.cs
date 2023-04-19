using Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.Event
{
    public class EventDto : BaseDto
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public DateTime EventDate { get; set; }
        public string VenueName { get; set; }
        public string VenueAddress { get; set; }
        public int TicketsAmount { get; set; }
        public int NbSoldTickets { get; set; }
        public int TicketPrice { get; set; }
        public bool IsActive { get; set; }
        public bool IsApproved { get; set; }

        
    }
}
