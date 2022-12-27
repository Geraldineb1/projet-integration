using Application.DTOs.Common;
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
        public int ServiceTypeId { get; set; }
        public ProviderDto Provider { get; set; }

    }
}
