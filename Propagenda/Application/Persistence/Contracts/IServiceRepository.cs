using Domain;

namespace Application.Persistence.Contracts
{
    public interface IServiceRepository : IGenericRepository<Service>
    {
        Task<Service> GetServiceWithDetails(int id);
        Task<List<Service>> GetServicesWithDetails();
        Task ChangeActivationStatus(Service service, bool isActive);
    }
}
