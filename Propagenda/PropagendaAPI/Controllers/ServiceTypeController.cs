using Application.DTOs.ServiceType;
using Application.Features.ServiceTypes.Requests.Commands;
using Application.Features.ServiceTypes.Requests.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PropagendaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceTypeController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ServiceTypeController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // GET: api/<ServiceTypeController>
        [HttpGet]
        public async Task<ActionResult<List<ServiceTypeDto>>> Get()
        {
            var serviceTypes = await _mediator.Send(new GetServiceTypeListRequest());

            return Ok(serviceTypes);
        }

        // GET api/<ServiceTypeController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceTypeDto>> Get(int id)
        {
            var serviceType = await _mediator.Send(new GetServiceTypeDetailRequest { Id = id });
            return Ok(serviceType);
        }

        // POST api/<ServiceTypeController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] CreateServiceTypeDto serviceType)
        {
            var command = new CreateServiceTypeCommand { ServiceTypeDto = serviceType };
            var response = await _mediator.Send(command);
            return Ok(response);
        }

        // PUT api/<ServiceTypeController>
        [HttpPut]
        public async Task<ActionResult> Put([FromBody] ServiceTypeDto serviceType)
        {
            var command = new UpdateServiceTypeCommand { ServiceTypeDto = serviceType };
            await _mediator.Send(command);
            return NoContent();
        }

        // DELETE api/<ServiceTypeController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            await _mediator.Send(new DeleteServiceTypeCommand { Id = id });
            return NoContent();
        }
    }
}
