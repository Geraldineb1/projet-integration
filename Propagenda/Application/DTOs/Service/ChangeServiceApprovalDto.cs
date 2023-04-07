using Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.Service
{
    public class ChangeServiceApprovalDto : BaseDto
    {
        public bool isApproved { get; set; }

    }
}
