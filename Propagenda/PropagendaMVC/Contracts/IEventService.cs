using PropagendaMVC.Models;
using PropagendaMVC.Services.Base;

namespace PropagendaMVC.Contracts
{
    public class IEventService
    {
        Task<List<ServiceTypeVM>> GetEvent();
        Task<ServiceTypeVM> GetEventDetails(int id);
        Task<Response<int>> CreateEvent(CreateEventVM event);
        Task<Response<int>> UpdateEvent(int id, EventVM event);
        Task<Response<int>> DeleteEvent(int id);
    }
}
