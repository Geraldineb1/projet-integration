using PropagendaMVC.Services.Base;
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
            public int ServiceTypeId { get; set; }

            [Required]
            public int ProviderId { get; set; }
            public bool isActive { get; set; }

            
            
    }
        public class ServiceListVM
        {
            public int Id { get; set; }
            public string Title { get; set; }

            public string Description { get; set; }

            [Display(Name = "Type Image")]
            public string Image { get; set; }

            public int Price { get; set; }

            public string LocationArea { get; set; }

            public string LocationAddress { get; set; }

            public ServiceTypeDto Servicetype { get; set; }

            public ProviderDto Provider { get; set; }
            public bool isActive { get; set; }
        }

        public class ServiceToApproveVM
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public bool IsApproved { get; set; }
        }

}
