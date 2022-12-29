using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Persistence.Contracts
{
    public interface IServiceRepository : IGenericRepository<Service>
    {
        Task<Service> GetServiceWithDetails(int id);
        Task<List<Service>> GetServicesWithDetails();
    }
}
