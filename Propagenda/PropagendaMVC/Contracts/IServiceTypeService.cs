using PropagendaMVC.Models;
using PropagendaMVC.Services.Base;

namespace PropagendaMVC.Contracts
{
    public interface IServiceTypeService
    {
        Task<List<ServiceTypeVM>> GetServiceTypes();
        Task<ServiceTypeVM> GetServiceTypeDetails(int id);
        Task<Response<int>> CreateServiceType(CreateServiceTypeVM serviceType);
        Task<Response<int>> UpdateServiceType(int id, ServiceTypeVM serviceType);
        Task<Response<int>> DeleteServiceType(int id);
    }
}
