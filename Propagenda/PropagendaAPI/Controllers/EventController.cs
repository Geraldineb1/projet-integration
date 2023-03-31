using Application.DTOs.Event;
using Application.Features.Event.Requests.Queries;
using Application.Features.Events.Requests.Commands;
using Application.Features.Events.Requests.Queries;
using Application.Responses;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PropagendaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventController : ControllerBase
    {
        private readonly IMediator _mediator;

        public EventController(IMediator mediator)
        {
            _mediator = mediator;
        }


        // GET: api/<EventController>
        [HttpGet]
        public async Task<ActionResult<List<EventDto>>> Get()
        {
            var eventList = await _mediator.Send(new GetEventListRequest());

            return Ok(eventList);
        }

        // GET api/<EventController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EventDto>> Get(int id)
        {
            var singleEvent = await _mediator.Send(new GetEventDetailRequest { Id = id });
            return Ok(singleEvent);
        }

        // POST api/<EventController>
        [HttpPost]
        public async Task<ActionResult<BaseCommandResponse>> Post([FromBody] CreateEventDto Event)
        {
            var command = new CreateEventCommand { EventDto = Event };
            var response = await _mediator.Send(command);
            return Ok(response);
        }

        // PUT api/<EventController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] EventDto Event)
        {
            var command = new UpdateEventCommand { Id = id, EventDto = Event };
            await _mediator.Send(command);
            return NoContent();
        }

    }
}
