using Application.DTOs.Service;
using Application.Features.ServiceReservations.Requests.Commands;
using Application.Features.Services.Requests.Commands;
using Application.Features.Services.Requests.Queries;
using Application.Responses;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PropagendaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceController : ControllerBase
    {
        private readonly IMediator _mediator;
        public ServiceController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // GET: api/<ServiceController>
        [HttpGet]
        public async Task<ActionResult<List<ServiceDto>>> Get()
        {
            var services = await _mediator.Send(new GetServiceListRequest());

            return Ok(services);
        }

        // GET api/<ServiceController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceDto>> Get(int id)
        {
            var service = await _mediator.Send(new GetServiceDetailRequest { Id = id });
            return Ok(service);
        }

        // POST api/<ServiceController>
        [HttpPost]
        public async Task<ActionResult<BaseCommandResponse>> Post([FromBody] CreateServiceDto service)
        {
            var command = new CreateServiceCommand { ServiceDto = service };
            var response = await _mediator.Send(command);
            return Ok(response);
        }

        // PUT api/<ServiceController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] UpdateServiceDto service)
        {
            var command = new UpdateServiceCommand {Id = id, ServiceDto = service };
            await _mediator.Send(command);
            return NoContent();
        }

        // PUT api/<ServiceController>/changeapproval/5
        [HttpPut("changeapproval/{id}")]
        public async Task<ActionResult> ChangeApproval(int id, [FromBody] ChangeServiceApprovalDto approvalStatus)
        {
            var command = new UpdateServiceCommand { Id = id, ChangeServiceApprovalDto = approvalStatus };
            await _mediator.Send(command);
            return NoContent();
        }

        // PUT api/<ServiceController>/changeactivation/5
        [HttpPut("changeactivation/{id}")]
        public async Task<ActionResult> ChangeActivation(int id, [FromBody] ChangeServiceActivationDto activationStatus)
        {
            var command = new UpdateServiceCommand { Id = id, ChangeServiceActivationDto = activationStatus };
            await _mediator.Send(command);
            return NoContent();
        }

        // DELETE api/<ServiceController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
