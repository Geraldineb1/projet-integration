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
        public DateTime RequestDate { get; set; }


        [Required]
        public DateTime DateService { get; set; } 


        [Required]
        public bool isAccepted { get; set; }


        [Required]
        public bool isCompleted { get; set; }

    }

    public class ServiceReservationToApproveVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsApproved { get; set; }
    }
}
