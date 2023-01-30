using Application.DTOs.Ticket;
using Application.Features.Tickets.Requests.Commands;
using Application.Features.Tickets.Requests.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PropagendaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketController : ControllerBase
    {
        private readonly IMediator _mediator;

        public TicketController(IMediator mediator)
        {
            _mediator = mediator;
        }


        // GET: api/<TicketController>
        [HttpGet]
        public async Task<ActionResult<List<TicketDto>>> Get()
        {
            var ticket = await _mediator.Send(new GetTicketListRequest());

            return Ok(ticket);
        }

        // GET api/<TicketController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TicketDto>> Get(int id)
        {
            var ticket = await _mediator.Send(new GetTicketDetailRequest { Id = id });
            return Ok(ticket);
        }

        // POST api/<TicketController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] CreateTicketDto Ticket)
        {
            var command = new CreateTicketCommand { TicketDto = Ticket };
            var response = await _mediator.Send(command);
            return Ok(response);
        }

    }
}
