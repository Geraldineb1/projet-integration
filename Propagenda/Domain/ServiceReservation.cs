using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class ServiceReservation : BaseDomainEntity
    { 
        public DateTime RequestDate { get; set; }

        public DateTime DateService { get; set; }
        public bool IsAccepted { get; set; }
        public bool IsCompleted { get; set; }
        public ApplicationUser User { get; set; }
        public IList<Service> Services { get; set; }

    }
}
