using PropagendaMVC.Services.Base;

namespace PropagendaMVC.Models
{
    public class HomeVM
    {
        public List<EventVM> Events { get; set; }
        public List<ProviderWithServicesVM> Providers { get; set; }
        public List<ServiceListVM> Services { get; set; }
    }
}
