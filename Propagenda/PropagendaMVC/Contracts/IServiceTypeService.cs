using PropagendaMVC.Models;
using PropagendaMVC.Services.Base;

namespace PropagendaMVC.Contracts
{
    public interface IServiceTypeService
    {
        Task<List<ServiceTypeVM>> GetServiceTypes();
        Task<ServiceTypeVM> GetServiceTypeDetails(int id);
        Task<Response<int>> CreateServiceType(CreateServiceTypeVM leaveType);
        Task<Response<int>> UpdateServiceType(int id, ServiceTypeVM leaveType);
        Task<Response<int>> DeleteServiceType(int id);
    }
}
