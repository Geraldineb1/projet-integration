using PropagendaMVC.Models;
using PropagendaMVC.Services.Base;

namespace PropagendaMVC.Contracts
{
    public interface IServiceReservationService
    {
        Task<List<ServiceReservationVM>> GetServiceReservations();
        Task<ServiceReservationVM> GetServiceReservationDetails(int id);
        Task<Response<int>> CreateServiceReservation(CreateServiceReservationVM serviceReservation);
        Task<Response<int>> UpdateServiceReservation(int id, ServiceReservationVM serviceReservation);
        Task<Response<int>> DeleteServiceReservation(int id);
        Task<List<ProviderVM>> GetServiceReservationsToApprove();
        Task<Response<int>> UpdateApproval(int id, ServiceReservationToApproveVM provider);
    }
}
