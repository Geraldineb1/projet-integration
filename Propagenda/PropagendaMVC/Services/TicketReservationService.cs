using AutoMapper;
using PropagendaMVC.Contracts;
using PropagendaMVC.Models;
using PropagendaMVC.Services.Base;

namespace PropagendaMVC.Services
{
    public class TicketReservationService : BaseHttpService, ITicketReservationService
    {
        private readonly ILocalStorageService _localStorageService;
        private readonly IMapper _mapper;
        private readonly IClient _httpclient;

        public TicketReservationService(IMapper mapper, IClient httpclient, ILocalStorageService localStorageService) : base(httpclient, localStorageService)
        {
            this._localStorageService = localStorageService;
            this._mapper = mapper;
            this._httpclient = httpclient;
        }

        public async Task<Response<int>> CreateTicketReservation(CreateTicketReservationVM ticketReservation)
        {
            try
            {
                var response = new Response<int>();
                CreateTicketReservationDto createTicketReservation = _mapper.Map<CreateTicketReservationDto>(ticketReservation);
                AddBearerToken();
                BaseCommandResponse apiResponse = await _client.TicketReservationPOSTAsync(createTicketReservation);
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

        public async Task<TicketReservationVM> GetTicketReservationDetails(int id)
        {
            AddBearerToken();
            var ticketReservation = await _client.TicketReservationGETAsync(id);
            return _mapper.Map<TicketReservationVM>(ticketReservation);
        }

        public async Task<List<TicketReservationVM>> GetTicketReservations()
        {
            AddBearerToken();
            var ticketReservations = await _client.TicketReservationAllAsync();
            return _mapper.Map<List<TicketReservationVM>>(ticketReservations);
        }

    }
}
