using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PaymentService.Service.Features.CustomerFeatures.Commands;
using PaymentService.Service.Features.CustomerFeatures.Queries;

namespace PaymentService.Controllers;

[Authorize]
[ApiController]
[Route("api/v{version:apiVersion}/Customer")]
[ApiVersion("2.0")]
public class CustomerController : ControllerBase
{
    private IMediator _mediator;
    protected IMediator Mediator => _mediator ??= HttpContext.RequestServices.GetService<IMediator>();

    [HttpPost]
    public async Task<IActionResult> Create(CreateCustomerCommand command)
    {
        return Ok(await Mediator.Send(command));
    }

    [HttpGet]
    [Route("")]
    public async Task<IActionResult> GetAll()
    {
        return Ok(await Mediator.Send(new GetAllCustomerQuery()));
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        return Ok(await Mediator.Send(new GetCustomerByIdQuery { Id = id }));
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        return Ok(await Mediator.Send(new DeleteCustomerByIdCommand { Id = id }));
    }


    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, UpdateCustomerCommand command)
    {
        if (id != command.Id)
        {
            return BadRequest();
        }
        return Ok(await Mediator.Send(command));
    }
}