using Application.DTOs.ServiceReservation;
using Application.Features.ServiceReservations.Requests.Commands;
using Application.Features.ServiceReservations.Requests.Queries;
using Application.Responses;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PropagendaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceReservationController : ControllerBase
    {
        private readonly IMediator _mediator;
        public ServiceReservationController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // GET: api/<ServiceReservationController>
        [HttpGet]
        public async Task<ActionResult<List<ServiceReservationDto>>> Get()
        {
            var servicesRsvps = await _mediator.Send(new GetServiceReservationListRequest());

            return Ok(servicesRsvps);
        }

        // GET api/<ServiceReservationController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceReservationDto>> Get(int id)
        {
            var servicesRsvp = await _mediator.Send(new GetServiceReservationDetailRequest { Id = id });
            return Ok(servicesRsvp);
        }

        // GET: api/<ServiceReservationController/services-by-user>
        [HttpGet("~/servicereservations-by-user")]
        public async Task<ActionResult<List<ServiceReservationDto>>> AllServicesByUser()
        {
            var services = await _mediator.Send(new GetServiceReservationsByUserRequest());

            return Ok(services);
        }

        // POST api/<ServiceReservationController>
        [HttpPost]
        public async Task<ActionResult<BaseCommandResponse>> Post([FromBody] CreateServiceReservationDto serviceRsvp)
        {
            var command = new CreateServiceReservationCommand { ServiceReservationDto = serviceRsvp };
            var response = await _mediator.Send(command);
            return Ok(response);
        }

        // PUT api/<ServiceReservationController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put([FromBody] ServiceReservationDto service)
        {
            var command = new UpdateServiceReservationCommand { ServiceReservationDto = service };
            await _mediator.Send(command);
            return NoContent();
        }

        // PUT api/<ServiceReservationController>/changeapproval/5
        [HttpPut("changeapproval/{id}")]
        public async Task<ActionResult> ChangeApproval(int id, [FromBody] ChangeServiceReservationApprovalDto approvalStatus)
        {
            var command = new UpdateServiceReservationCommand { Id = id, ChangeServiceReservationApprovalDto = approvalStatus };
            await _mediator.Send(command);
            return NoContent();
        }

        // PUT api/<ServiceReservationController>/changecompletion/5
        [HttpPut("changecompletion/{id}")]
        public async Task<ActionResult> ChangeComletion(int id, [FromBody] ChangeServiceReservationCompletionDto completionStatus)
        {
            var command = new UpdateServiceReservationCommand { Id = id, ChangeServiceReservationCompletionDto = completionStatus };
            await _mediator.Send(command);
            return NoContent();
        }

        // DELETE api/<ServiceReservationController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
