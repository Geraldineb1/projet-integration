﻿using Application.DTOs.Common;
using Application.DTOs.Service;
using Application.DTOs.ServiceServiceReservation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Application.DTOs.ServiceReservation
{
    public class ServiceReservationDto : BaseDto
    {
        public DateTime RequestDate { get; set; }
        public DateTime DateService { get; set; }
        public string Comment { get; set; }
        public bool IsAccepted { get; set; }
        public bool IsCompleted { get; set; }
        public string ApplicationUserId { get; set; }
        public List<ServiceServicereservationDto> SSR { get; set; }
    }
}
