using PropagendaMVC.Models;
using PropagendaMVC.Services.Base;

namespace PropagendaMVC.Contracts
{
    public interface IServiceReservationService
    {
        Task<List<ServiceReservationVM>> GetServiceReservations();
        Task<UpdateServiceReservationVM> GetServiceReservationDetails(int id);
        Task<List<ServiceReservationByUserVM>> GetServiceReservationsByUser();
        Task<Response<int>> CreateServiceReservation(CreateServiceReservationVM serviceReservation);
        Task<Response<int>> UpdateServiceReservation(int id, ServiceReservationVM serviceReservation);
        Task<Response<int>> DeleteServiceReservation(int id);
        Task<List<ServiceReservationVM>> GetServiceReservationsToApprove();
        Task<Response<int>> UpdateApproval(int id, ServiceReservationToApproveVM serviceReservation);
    }
}
