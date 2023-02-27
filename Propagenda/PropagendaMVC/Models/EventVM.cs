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
        public string Descrition { get; set; } // il y a une faute de frappe en DB: c'est Descrition au lieu de description


        [Required]
        public DateTime EventDate { get; set; }


        [Required]
        public string VenueName { get; set; }


        [Required]
        public string Venueddress { get; set; }


        [Required]
        public int TicketsAmount { get; set; }

        // je suppose qu'on ne doit pas reprendre l'user ID ici?
    }
}
