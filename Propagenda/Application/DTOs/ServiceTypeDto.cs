using Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs
{
    public class ServiceTypeDto : BaseDto
    {
        public string Label { get; set; }
        public string Image { get; set; }
    }
}
