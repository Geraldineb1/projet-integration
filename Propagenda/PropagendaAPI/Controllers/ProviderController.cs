using Application.DTOs.Provider;
using Application.Features.Providers.Requests.Commands;
using Application.Features.Providers.Requests.Queries;
using Application.Responses;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Persistence;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PropagendaAPI.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ProviderController : ControllerBase
    {
        private readonly IMediator _mediator;
        public ProviderController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // GET: api/<ProviderController>
        [HttpGet]
        public async Task<ActionResult<List<ProviderDto>>> Get()
        {
            var providers = await _mediator.Send(new GetProviderListRequest());

            return Ok(providers);
        }

        // GET: api/<ProviderController/AllToApprove>
        [HttpGet("~/to-approve")]
        public async Task<ActionResult<List<ProviderDto>>> AllToApprove()
        {
            var providers = await _mediator.Send(new GetProvidersToApproveListRequest());

            return Ok(providers);
        }

        // GET: api/<ProviderController/AllToApprove>
        [HttpGet("~/provider-by-user")]
        public async Task<ActionResult<List<ProviderDto>>> AllProviderByUser()
        {
            var providers = await _mediator.Send(new GetProvidersByUserRequest());

            return Ok(providers);
        }

        // GET api/<ProviderController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ProviderDto>> Get(int id)
        {
            var provider = await _mediator.Send(new GetProviderDetailRequest { Id = id });
            return Ok(provider);
        }

        // POST api/<ProviderController>
        [HttpPost]
        public async Task<ActionResult<BaseCommandResponse>> Post([FromBody] CreateProviderDto provider)
        {
            var command = new CreateProviderCommand { ProviderDto = provider };
            var response = await _mediator.Send(command);
            return Ok(response);
        }

        // PUT api/<ProviderController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] UpdateProviderDto provider)
        {
            var command = new UpdateProviderCommand { Id = id, ProviderDto = provider };
            await _mediator.Send(command);
            return NoContent();
        }
        // PUT api/<ProviderController>/changeactivation/5
        [HttpPut("changeactivation/{id}")]
        public async Task<ActionResult> ChangeActivation(int id, [FromBody] ChangeProviderActivationDto activationStatus)
        {
            var command = new UpdateProviderCommand {Id = id, ChangeProviderActivationDto = activationStatus };
            await _mediator.Send(command);
            return NoContent();
        }

        // PUT api/<ProviderController>/changeactivation/5
        [HttpPut("changeapproval/{id}")]
        public async Task<ActionResult> ChangeApproval(int id, [FromBody] ChangeProviderApprovalDto activationStatus)
        {
            var command = new UpdateProviderCommand { Id = id, ChangeProviderApprovalDto = activationStatus };
            await _mediator.Send(command);
            return NoContent();
        }


        // DELETE api/<ProviderController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
