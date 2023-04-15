using Domain;

namespace Application.Persistence.Contracts
{
    public interface IServiceRepository : IGenericRepository<Service>
    {
        Task<Service> GetServiceWithDetails(int id);
        Task<List<Service>> GetServicesWithDetails();
        Task<List<Service>> GetAllServicesByUser(string id);
        Task<List<Service>> GetAllServicesToApprove();
        Task ChangeActivationStatus(Service service, bool isActive);
        Task ChangeApprovalStatus(Service service, bool isApproved);

    }
}
