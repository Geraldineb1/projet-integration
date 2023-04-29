using Application.DTOs.Common;
using Application.DTOs.ServiceType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.Service
{
    public class ServiceWithoutProviderDto : BaseDto
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public int Price { get; set; }
        public string LocationArea { get; set; }
        public string LocationAddress { get; set; }
        public bool isActive { get; set; }
        public bool isApproved { get; set; }
        public bool isPromoted { get; set; }
        public ServiceTypeDto ServiceType { get; set; }
        public int ServiceTypeId { get; set; }
    }
}
