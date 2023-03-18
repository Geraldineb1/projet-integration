﻿using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class ServiceType : BaseDomainEntity
    {

        public string Label { get; set; }
        public string Image { get; set; }
        
        public IList<Service>? Services { get; set; }


    }
}
