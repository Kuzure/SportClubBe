using MediatR;
using Microsoft.AspNetCore.Mvc;
using SportClub.Api.CQRS.Command;
using System.Net;

namespace SportClub.Api.Controllers
{
    [ApiController]
    [Route("api/user")]
    public class UserController : BaseController
    {
        public UserController(IMediator mediator) : base(mediator)
        {
        }
        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.Accepted)]
        public async Task<ActionResult> Create([FromBody] RegisterUserCommand command) =>
            await ExecuteCommand(async () => await _mediator.Send(command));
    }
}
