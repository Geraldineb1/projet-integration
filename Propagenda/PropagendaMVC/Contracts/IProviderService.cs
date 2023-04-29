using PropagendaMVC.Models;
using PropagendaMVC.Services.Base;

namespace PropagendaMVC.Contracts
{
    public interface IProviderService
    {
        Task<List<ProviderWithServicesVM>> GetProviders();
        Task<ProviderWithServicesVM> GetProviderDetails(int id);
        Task<Response<int>> CreateProvider(CreateProviderVM provider);
        Task<Response<int>> UpdateProvider(int id, UpdateProviderVM provider);
        Task<List<ProviderVM>> GetProvidersToApprove();
        Task<List<ProviderVM>> GetProvidersByUser();
        Task<Response<int>> UpdateApproval(int id, ProviderToApproveVM provider);

    }
}
