using Application.DTOs.Common;
using Application.DTOs.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.ServiceServiceReservation
{
    public class ServiceServicereservationDto : BaseDto
    {
        public ServiceDto Service { get; set; }
    }
}
