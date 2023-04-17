using Application.DTOs.Common;
using Application.DTOs.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.ServiceReservation
{
    public class ServiceReservationByUserDto : BaseDto
    {
        public DateTime RequestDate { get; set; }
        public DateTime DateService { get; set; }
        public bool IsAccepted { get; set; }
        public bool IsCompleted { get; set; }
        public ServiceDto Service { get; set; }
    }
}
