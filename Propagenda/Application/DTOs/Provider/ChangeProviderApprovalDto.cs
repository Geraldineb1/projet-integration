﻿using Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.Provider
{
    public class ChangeProviderApprovalDto : BaseDto
    {
        public bool IsApproved { get; set; }

    }
}
