using Application.DTOs.Common;
using Application.DTOs.Provider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.Service
{
    public class ServiceListDto : BaseDto
    {
        public string Title { get; set; }
        public string Image { get; set; }
        public string LocationArea { get; set; }
        public bool isActive { get; set; }
        public ServiceTypeDto ServiceType { get; set; }
        public ProviderDto Provider { get; set; }

    }
}
