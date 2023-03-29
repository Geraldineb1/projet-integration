using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace PropagendaMVC.Models
{
    public class EventVM : CreateEventVM
    {
        public int Id { get; set; }
    }

    public class CreateEventVM
    {
        [Required]
        public string Title { get; set; }


        [Required]
        public string Description { get; set; } // il y a une faute de frappe en DB: c'est Descrition au lieu de description


        [Required]
        public DateTimeOffset EventDate { get; set; }


        [Required]
        public string VenueName { get; set; }


        [Required]
        public string VenueAddress { get; set; }


        [Required]
        public int TicketsAmount { get; set; }
        public int TicketPrice { get; set; }

    }
}
