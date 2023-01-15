using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.ServiceReservation
{
    public class CreateServiceReservationDto
    {
        public DateTime RequestDate { get; set; }
        public bool IsAccepted { get; set; }
        public bool IsCompleted { get; set; }

        public int UserId { get; set; }
    }
}
