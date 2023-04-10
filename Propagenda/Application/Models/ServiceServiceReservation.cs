using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models
{
    public class ServiceServiceReservation
    {
        public int Id { get; set; }
        public int ServicesId { get; set; }
        public int ReservationsId { get; set; }
    }
}
