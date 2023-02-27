using AutoMapper;
using PropagendaMVC.Contracts;
using PropagendaMVC.Models;
using PropagendaMVC.Services.Base;

namespace PropagendaMVC.Services
{
    public class EventService : BaseHttpService, IEventService
    {
        //private readonly ILocalStorageService _localStorageService;
        private readonly IMapper _mapper;
        private readonly IClient _httpclient;

        public EventService(IMapper mapper, IClient httpclient, ILocalStorageService localStorageService) : base(httpclient, localStorageService)
        {
            //this._localStorageService = localStorageService;
            this._mapper = mapper;
            this._httpclient = httpclient;
        }

        public async Task<Response<int>> CreateEvent(CreateEventVM Event)
        {
            try
            {
                var response = new Response<int>();
                CreateEventDto createEvent = _mapper.Map<CreateEventDto>(Event);
                AddBearerToken();
                var apiResponse = await _client.EventPOSTAsync(createEvent);
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

        public async Task<Response<int>> DeleteEvent(int id)
        {
            try
            {
                AddBearerToken();
                await _client.EventDELETEAsync(id);
                return new Response<int>() { Success = true };
            }
            catch (ApiException ex)
            {
                return ConvertApiExceptions<int>(ex);
            }
        }

        public async Task<EventVM> GetEventDetails(int id)
        {
            AddBearerToken();
            var serviceType = await _client.EventGETAsync(id);
            return _mapper.Map<EventVM>(serviceType);
        }

        public async Task<List<EventVM>> GetEvents()
        {
            AddBearerToken();
            var serviceTypes = await _client.ServiceTypeAllAsync();
            return _mapper.Map<List<EventVM>>(serviceTypes);
        }

        public async Task<Response<int>> UpdateEvent(int id, EventVM Event)
        {
            try
            {
                ServiceTypeDto serviceTypeDto = _mapper.Map<EventDto>(Event);
                AddBearerToken();
                await _client.EventPUTAsync(id.ToString(), EventDto);
                return new Response<int>() { Success = true };
            }
            catch (ApiException ex)
            {
                return ConvertApiExceptions<int>(ex);
            }
        }
    }
}
