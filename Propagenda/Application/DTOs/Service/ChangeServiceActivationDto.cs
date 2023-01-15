using Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.Service
{
    public class ChangeServiceActivationDto : BaseDto
    {
        public bool isActive { get; set; }
    }
}
