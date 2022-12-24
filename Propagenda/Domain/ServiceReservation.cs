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
        public bool IsAccepted { get; set; }
        public bool IsCompleted { get; set; }
        public ICollection<Service> Services { get; set; } = new List<Service>();
        public int UserId { get; set; }

    }
}
