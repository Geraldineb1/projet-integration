using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Service : BaseDomainEntity
    {
        
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public int Price { get; set; }
        public string LocationArea { get; set; }
        public string LocationAddress { get; set; }
        public bool isActive { get; set; }
        public bool isApproved { get; set; }
        public ServiceType? ServiceType { get; set; }
        public int ServiceTypeId { get; set; }

        public Provider? Provider { get; set; }
        public int ProviderId { get; set; }

        public  IList<ServiceServiceReservation>? SSR { get; set; }





    }
}
