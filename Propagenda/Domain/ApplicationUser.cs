using Domain;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Table("AspNetUsers")]
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public IList<TicketReservation>? TicketReservations { get; set; }
        public IList<Event>? Events { get; set; }
        public IList<ServiceReservation>? ServicesReservations { get; set; }
        public IList<Provider>? Providers { get; set; }
    }
}
