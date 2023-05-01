using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.ServiceReservation
{
    public class CreateServiceReservationDto
    {
        public DateTime DateService { get; set; }
        public string Comment { get; set; }
        
        public int ServiceId { get; set; }

        
    }
}
