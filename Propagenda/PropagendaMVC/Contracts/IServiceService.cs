using PropagendaMVC.Models;
using PropagendaMVC.Services.Base;

namespace PropagendaMVC.Contracts
{
    public interface IServiceService
    {
        Task<List<ServiceListVM>> GetServices();
        Task<ServiceVM> GetServiceDetails(int id);
        Task<Response<int>> CreateService(CreateServiceVM service);
        Task<Response<int>> UpdateService(int id, ServiceVM service);
        Task<Response<int>> DeleteService(int id);
        Task<List<ServiceVM>> GetServicesToApprove();
        Task<ServiceToApproveVM> GetServiceToApprove(int id);
        Task<List<ServiceListVM>> GetServicesByUser();
        Task<Response<int>> UpdateApproval(int id, ServiceToApproveVM provider);
    }
}
