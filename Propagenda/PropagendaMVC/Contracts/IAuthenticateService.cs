using PropagendaMVC.Models;

namespace PropagendaMVC.Contracts
{
    public interface IAuthenticateService
    {
        Task<bool> Authenticate(string email, string pasword);
        Task<bool> Register(RegisterVM registration);
        Task Logout();

    }
}
