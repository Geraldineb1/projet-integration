using PropagendaMVC.Models;
using PropagendaMVC.Services.Base;

namespace PropagendaMVC.Contracts
{
    public interface IEventService
    {
        Task<List<EventVM>> GetEvents();
        Task<EventVM> GetEventDetails(int id);
        Task<List<EventVM>> GetEventsByUser();
        Task<List<EventVM>> GetEventsToApprove();
        Task<EventToApproveVM> GetEventToApprove(int id);
        Task<Response<int>> CreateEvent(CreateEventVM singleEvent);
        Task<Response<int>> UpdateEvent(int id, EventVM singleEvent);
        Task<Response<int>> ApproveEvent(int id, EventToApproveVM singleEvent);
        //Task<Response<int>> DeleteEvent(int id);

    }
}
