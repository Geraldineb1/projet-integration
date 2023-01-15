using Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.ServiceReservation
{
    public class ChangeServiceReservationApprovalDto : BaseDto
    {
        public bool IsAccepted { get; set; }
    }
}
