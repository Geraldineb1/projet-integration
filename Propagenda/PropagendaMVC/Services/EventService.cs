﻿using AutoMapper;
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
                var token = _localStorage.GetStorageValue<String>("token");
                if (token != string.Empty)
                {
                    //Get Claims from token and Build auth user object
                    var tokenContent = _tokenHandler.ReadJwtToken(token);
                    var claims = ParseClaims(tokenContent);
                    var userId = claims[3].Value;
                    singleEvent.UserId = userId;
                }

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

        public async Task<Response<int>> UpdateEvent(int id, EventVM singleEvent)
        {
            try
            {
                EventDto eventDto = _mapper.Map<EventDto>(singleEvent);
                AddBearerToken();
                //await _client.EventPUTAsync(id.ToString(), eventDto);
                return new Response<int>() { Success = true };
            }
            catch (ApiException ex)
            {
                return ConvertApiExceptions<int>(ex);
            }
        }

        private IList<Claim> ParseClaims(JwtSecurityToken tokenContent)
        {
            var claims = tokenContent.Claims.ToList();
            claims.Add(new Claim(ClaimTypes.Name, tokenContent.Subject));
            return claims;
        }
    }
}