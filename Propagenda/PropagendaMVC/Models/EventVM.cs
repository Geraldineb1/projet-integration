using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace PropagendaMVC.Models
{
    public class EventVM : CreateEventVM
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public bool IsApproved { get; set; }
        public bool IsPromoted { get; set; }
    }

    public class CreateEventVM
    {
        [Required]
        public string Title { get; set; }


        [Required]
        public string Description { get; set; }


        [Required]
        public DateTimeOffset EventDate { get; set; }


        [Required]
        public string VenueName { get; set; }


        [Required]
        public string VenueAddress { get; set; }


        [Required]
        public int TicketsAmount { get; set; }
        [Required]
        public int TicketPrice { get; set; }
        public bool IsActive { get; set; }

    }

    public class EventToApproveVM
    {
        public int Id { get; set; }
        public bool IsApproved { get; set; }
    }
}
