using Application.Models.Identity;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Persistence.Identity
{
    public interface IUserService
    {
        Task<List<Client>> GetClients();
        Task<ApplicationUser> GetUser(string id);
    }
}
