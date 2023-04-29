using Domain;

namespace Application.Persistence.Contracts
{
    public interface IProviderRepository : IGenericRepository<Provider>
    {
        Task ChangeActivationStatus(Provider provider, bool isActive);
        Task ChangeApprovalStatus(Provider provider, bool isApproved);

        Task<Provider> GetProviderWithServices(int id);
        new Task<List<Provider>> GetAll();
        Task<IReadOnlyList<Provider>> GetAllToApprove();
        Task<IReadOnlyList<Provider>> GetAllByUser(string id);


    }
}
