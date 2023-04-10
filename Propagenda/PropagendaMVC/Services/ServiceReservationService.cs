using AutoMapper;
using PropagendaMVC.Contracts;
using PropagendaMVC.Models;
using PropagendaMVC.Services.Base;

namespace PropagendaMVC.Services
{
    public class ServiceReservationService : BaseHttpService, IServiceReservationService
    {
        private readonly ILocalStorageService _localStorageService;
        private readonly IMapper _mapper;
        private readonly IClient _httpclient;

        public ServiceReservationService(IMapper mapper, IClient httpclient, ILocalStorageService localStorageService) : base(httpclient, localStorageService)
        {
            this._localStorageService = localStorageService;
            this._mapper = mapper;
            this._httpclient = httpclient;
        }

        public async Task<Response<int>> CreateServiceReservation(CreateServiceReservationVM serviceReservation)
        {
            try
            {
                var response = new Response<int>();
                CreateServiceReservationDto createServiceReservation = _mapper.Map<CreateServiceReservationDto>(serviceReservation);
                AddBearerToken();
                BaseCommandResponse apiResponse = await _client.ServiceReservationPOSTAsync(createServiceReservation);
                if (apiResponse.Success)
                {
                    response.Data = apiResponse.Id;
                    response.Success = true;
                }
                else
                {
                    foreach (var error in apiResponse.Errors)
                    {
                        response.ValidationErrors += error + Environment.NewLine;
                    }
                }
                return response;
            }
            catch (ApiException ex)
            {
                return ConvertApiExceptions<int>(ex);
            }
        }

        public async Task<Response<int>> DeleteServiceReservation(int id)
        {
            try
            {
                AddBearerToken();
                await _client.ServiceReservationDELETEAsync(id);
                return new Response<int>() { Success = true };
            }
            catch (ApiException ex)
            {
                return ConvertApiExceptions<int>(ex);
            }
        }

        public async Task<UpdateServiceReservationVM> GetServiceReservationDetails(int id)
        {
            AddBearerToken();
            var serviceReservation = await _client.ServiceReservationGETAsync(id);
            return _mapper.Map<UpdateServiceReservationVM>(serviceReservation);
        }

        public async Task<List<ServiceReservationVM>> GetServiceReservations()
        {
            AddBearerToken();
            var serviceReservations = await _client.ServiceReservationAllAsync();
            return _mapper.Map<List<ServiceReservationVM>>(serviceReservations);
        }

        public async Task<List<ServiceReservationVM>> GetServiceReservationsToApprove()
        {
            AddBearerToken();
            var serviceReservations = await _client.ToApproveAsync();
            return _mapper.Map<List<ServiceReservationVM>>(serviceReservations);
        }

        public async Task<Response<int>> UpdateServiceReservation(int id, ServiceReservationVM serviceReservation)
        {
            try
            {
                ServiceReservationDto serviceReservationDto = _mapper.Map<ServiceReservationDto>(serviceReservation);
                AddBearerToken();
                await _client.ServiceReservationPUTAsync(id.ToString(), serviceReservationDto);
                return new Response<int>() { Success = true };
            }
            catch (ApiException ex)
            {
                return ConvertApiExceptions<int>(ex);
            }
        }

        public async Task<Response<int>> UpdateApproval(int id, ServiceReservationToApproveVM serviceReservation)
        {
            try
            {

                ChangeServiceReservationApprovalDto serviceReservationDto = _mapper.Map<ChangeServiceReservationApprovalDto>(serviceReservation);
                AddBearerToken();
                await _client.Changeapproval3Async(id, serviceReservationDto);
                return new Response<int>() { Success = true };
            }
            catch (ApiException ex)
            {
                return ConvertApiExceptions<int>(ex);
            }
        }

    }

}
