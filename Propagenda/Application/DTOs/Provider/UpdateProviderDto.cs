﻿using Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.Provider
{
    public class UpdateProviderDto : BaseDto
    {
        public string Name { get; set; }
        public string Bio { get; set; }
        public string Link { get; set; }
        //public string AccountNb { get; set; }
        public string UserId { get; set; }
    }
}
