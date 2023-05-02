using AutoMapper;
using PropagendaMVC.Contracts;
using PropagendaMVC.Models;
using PropagendaMVC.Services.Base;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace PropagendaMVC.Services
{
    public class EventService : BaseHttpService, IEventService
    {
        //private readonly ILocalStorageService _localStorageService;
        private readonly IMapper _mapper;
        private readonly IClient _httpclient;
        private JwtSecurityTokenHandler _tokenHandler;

        public EventService(IMapper mapper, IClient httpclient, ILocalStorageService localStorageService) : base(httpclient, localStorageService)
        {
            //this._localStorageService = localStorageService;
            this._mapper = mapper;
            this._httpclient = httpclient;
            this._tokenHandler = new JwtSecurityTokenHandler();
        }

        public async Task<Response<int>> CreateEvent(CreateEventVM singleEvent)
        {
            try
            {
                var response = new Response<int>();
               

                CreateEventDto createEvent = _mapper.Map<CreateEventDto>(singleEvent);
                AddBearerToken();
                BaseCommandResponse apiResponse = await _client.EventPOSTAsync(createEvent);
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

        /*public async Task<Response<int>> DeleteEvent(int id)
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
        }*/

        public async Task<EventVM> GetEventDetails(int id)
        {
            AddBearerToken();
            var singleEvent = await _client.EventGETAsync(id);
            return _mapper.Map<EventVM>(singleEvent);
        }

        public async Task<List<EventVM>> GetEvents()
        {
            AddBearerToken();
            var events = await _client.EventAllAsync();
            return _mapper.Map<List<EventVM>>(events);
        }

        public async Task<List<EventVM>> GetEventsByUser()
        {
            AddBearerToken();
            var events = await _client.EventsByUserAsync();
            return _mapper.Map<List<EventVM>>(events);
        }

        public async Task<List<EventVM>> GetEventsToApprove()
        {
            AddBearerToken();
            var events = await _client.EventsToApproveAsync();
            return _mapper.Map<List<EventVM>>(events);
        }
        public async Task<EventToApproveVM> GetEventToApprove(int id)
        {
            AddBearerToken();
            var singleEvent = await _client.EventGETAsync(id);
            return _mapper.Map<EventToApproveVM>(singleEvent);
        }

        public async Task<Response<int>> ApproveEvent(int id, EventToApproveVM singleEvent)
        {
            try
            {
                ChangeEventApprovalDto eventDto = _mapper.Map<ChangeEventApprovalDto>(singleEvent);
                AddBearerToken();
                await _client.ApproveEventAsync(id, eventDto);
                return new Response<int>() { Success = true };
            }
            catch (ApiException ex)
            {
                return ConvertApiExceptions<int>(ex);
            }
        }

        public async Task<Response<int>> UpdateEvent(int id, EventVM singleEvent)
        {
            try
            {
                UpdateEventDto eventDto = _mapper.Map<UpdateEventDto>(singleEvent);
                AddBearerToken();
                await _client.EventPUTAsync(id, eventDto);
                return new Response<int>() { Success = true };
            }
            catch (ApiException ex)
            {
                return ConvertApiExceptions<int>(ex);
            }
        }

       
    }
}
