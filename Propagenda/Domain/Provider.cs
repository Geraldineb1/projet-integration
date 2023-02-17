using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Provider : BaseDomainEntity
    {
        public string Name { get; set; }
        public string Bio { get; set; }
        public string Link { get; set; }
        //public string AccountNb { get; set; }
        public bool IsActive { get; set; }
        public ApplicationUser User { get; set; }
        
        public IList<Service> Services { get; set; }

    }
}
