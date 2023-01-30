using Domain;

namespace Application.Persistence.Contracts
{
    public interface IProviderRepository : IGenericRepository<Provider>
    {
        Task ChangeActivationStatus(Provider provider, bool isActive);
    }
}
