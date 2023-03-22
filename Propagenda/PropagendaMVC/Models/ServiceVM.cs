using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace PropagendaMVC.Models
{
    public class ServiceVM : CreateServiceVM
    {
            public int Id { get; set; }
    }

    public class CreateServiceVM
    {
            [Required]
            public string Title { get; set; }

            [Required]
            public string Description { get; set; }

            [Required]
            [Display(Name = "Type Image")]
            public string Image { get; set; }

            [Required]
            public int Price { get; set; }

            [Required]
            public string LocationArea { get; set; }

            [Required]
            public string LocationAddress { get; set; }

            [Required]
            public bool isActive { get; set; }

            [Required]
            public bool isApproved { get; set; }
        }

    
}
