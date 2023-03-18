using PropagendaMVC.Models;
using PropagendaMVC.Services.Base;

namespace PropagendaMVC.Contracts
{
    public interface IEventService
    {
        Task<List<EventVM>> GetEvents();
        Task<EventVM> GetEventDetails(int id);
        Task<Response<int>> CreateEvent(CreateEventVM singleEvent);
        Task<Response<int>> UpdateEvent(int id, EventVM singleEvent);
        //Task<Response<int>> DeleteEvent(int id);
    }
}
