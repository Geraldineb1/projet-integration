using PropagendaMVC.Services.Base;
using System.ComponentModel.DataAnnotations;

namespace PropagendaMVC.Models
{
    public class ServiceReservationVM : CreateServiceReservationVM
    {
        public int Id { get; set; }
    }

    public class CreateServiceReservationVM
    {
        [Required]
        public int ServiceId { get; set; }

        [Required]
        public DateTimeOffset DateService { get; set; }
        [Required]
        public string Comment { get; set; }

        public DateTimeOffset RequestDate { get; set; }

    }

    public class UpdateServiceReservationVM
    {

        public bool IsAccepted { get; set; }
    }

    public class ServiceReservationToApproveVM
    {
        public int Id { get; set; }
        public bool IsAccepted { get; set; }
    }

    public class ServiceReservationByUserVM
    {
        public int Id { get; set; }
        public string Comment { get; set; }

        public List<ServiceServicereservationDto> SSR { get; set; }
        public DateTimeOffset DateService { get; set; }

        public DateTimeOffset RequestDate { get; set; }
    }
}
