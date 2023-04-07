using PropagendaMVC.Services.Base;
using System.ComponentModel.DataAnnotations;

namespace PropagendaMVC.Models
{
    public class ProviderVM : CreateProviderVM
    {
        public int Id { get; set; }
    }

    public class CreateProviderVM
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Bio { get; set; }
        [Required]
        public string Link { get; set; }
        [Required]
        public bool IsActive { get; set; }
        [Required]
        public bool IsApproved { get; set; }

    }

    public class UpdateProviderVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Bio { get; set; }
        public string Link { get; set; }
        public bool IsActive { get; set; }
        public string ApplicationUserId { get; set; }
    }

    public class ProviderWithServicesVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Bio { get; set; }
        public string Link { get; set; }
        public bool IsActive { get; set; }
        public bool IsApproved { get; set; }
        public string ApplicationUserId { get; set; }
        public List<ServiceWithoutProviderDto> Services { get; set; }
    }

    public class ProviderToApproveVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsApproved { get; set; }
    }





}
