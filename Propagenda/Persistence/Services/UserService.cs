using Application.Models.Identity;
using Application.Persistence.Identity;
using Domain;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Services
{
    public class UserService: IUserService
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public UserService(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<Client> GetClient(string userId)
        {
            var client = await _userManager.FindByIdAsync(userId);
            return new Client
            {
                Email = client.Email,
                Id = client.Id,
                FirstName = client.FirstName,
                LastName = client.LastName,
                Address = client.Address
            };
        }

        public async Task<ApplicationUser> GetUser(string userId)
        {
            var user = await _userManager.FindByIdAsync(userId);
            return new ApplicationUser
            {
                Email = user.Email,
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Address = user.Address
            };
        }

        public async Task<List<Client>> GetClients()
        {
            var clients = await _userManager.GetUsersInRoleAsync("Client");
            return clients.Select(q => new Client
            {
                Id = q.Id,
                Email = q.Email,
                FirstName = q.FirstName,
                LastName = q.LastName,
                Address = q.Address
            }).ToList();
        }

        

    }
}
