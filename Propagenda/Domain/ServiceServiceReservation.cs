using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class ServiceServiceReservation : BaseDomainEntity
    {
        public int ServicesId { get; set; }
        public Service Service { get; set; }
        public int ServiceReservationsId { get; set; }
        public ServiceReservation ServiceReservation { get; set; }
    }
}
