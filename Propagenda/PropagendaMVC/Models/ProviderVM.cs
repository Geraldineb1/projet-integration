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
        [Required]
        public string UserId { get; set; } 

    }
}
