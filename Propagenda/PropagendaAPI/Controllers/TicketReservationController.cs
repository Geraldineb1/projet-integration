using Application.DTOs.TicketReservation;
using Application.Features.TicketReservations.Requests.Commands;
using Application.Features.TicketReservations.Requests.Queries;
using Application.Responses;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PropagendaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketReservationController : ControllerBase
    {
        private readonly IMediator _mediator;

        public TicketReservationController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // GET: api/<TicketReservationController>
        [HttpGet]
        public async Task<ActionResult<List<TicketReservationDto>>> Get()
        {
            var ticketReservation= await _mediator.Send(new GetTicketReservationListRequest());

            return Ok(ticketReservation);
        }

        // GET api/<TicketReservationController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TicketReservationDto>> Get(int id)
        {
            var ticketReservation = await _mediator.Send(new GetTicketReservationDetailRequest { Id = id });
            return Ok(ticketReservation);
        }

        // POST api/<TicketReservationController>
        [HttpPost]
        public async Task<ActionResult<BaseCommandResponse>> Post([FromBody] CreateTicketReservationDto TicketReservation)
        {
            var command = new CreateTicketReservationCommand { TicketReservationDto = TicketReservation };
            var response = await _mediator.Send(command);
            return Ok(response);
        }

    }
}
