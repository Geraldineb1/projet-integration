using PropagendaMVC.Services.Base;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace PropagendaMVC.Models
{
        public class TicketReservationVM : CreateTicketReservationVM
        {
            public int Id { get; set; }
        }

        public class CreateTicketReservationVM
        {
            [Required]
            public int TotalNbTickets { get; set; }


            [Required]
            public int EventId { get; set; }


        }

        public class TicketReservationListVM
        {
            public int TotalNbTickets { get; set; }
            public EventDto Event { get; set; }
        }
}
