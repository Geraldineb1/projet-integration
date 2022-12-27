using Application.DTOs.Common;
using Application.DTOs.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs
{
    public class ProviderDto : BaseDto
    {
        public string Name { get; set; }
        public string Bio { get; set; }
        public string Link { get; set; }
        //public string AccountNb { get; set; }
        public bool IsActive { get; set; }
        public int UserId { get; set; }
        public ICollection<ServiceDto> Services { get; set; } = new List<ServiceDto>();
    }
}
