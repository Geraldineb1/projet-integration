using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.Service
{
    public class CreateServiceDto
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public int Price { get; set; }
        public string LocationArea { get; set; }
        public string LocationAddress { get; set; }
        public bool isActive { get; set; }
        public int ServiceTypeId { get; set; }
        public int ProviderId { get; set; }
    }
}
