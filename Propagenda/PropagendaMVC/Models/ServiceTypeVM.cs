using System.ComponentModel.DataAnnotations;

namespace PropagendaMVC.Models
{
    public class ServiceTypeVM : CreateServiceTypeVM
    {
        public int Id { get; set; }
    }

    public class CreateServiceTypeVM
    {
        [Required]
        public string Label { get; set; }

        [Required]
        [Display(Name = "Type Image")]
        public string Image { get; set; }
    }
}
