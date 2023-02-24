using PropagendaMVC.Models;
using PropagendaMVC.Services.Base;

namespace PropagendaMVC.Contracts
{
    public interface IProviderService
    {
        Task<List<ProviderVM>> GetProviders();
        Task<UpdateProviderVM> GetProviderDetails(int id);
        Task<Response<int>> CreateProvider(CreateProviderVM provider);

        Task<Response<int>> UpdateProvider(int id, UpdateProviderVM provider);
    }
}
