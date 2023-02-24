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
        public string UserId { get; set; }

    }

    public class UpdateProviderVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Bio { get; set; }
        public string Link { get; set; }
        public bool IsActive { get; set; }
        public string UserId { get; set; }
    }
    public class UpdateProviderViewVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Bio { get; set; }
        public string Link { get; set; }
        public bool IsActive { get; set; }
        public string UserId { get; set; }
    }




}
