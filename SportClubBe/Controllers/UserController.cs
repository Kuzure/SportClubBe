using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SportClub.Api.CQRS.Command;
using SportClub.Api.CQRS.Query;
using SportClub.Api.Extension;
using System.Net;

namespace SportClub.Api.Controllers
{
    [ApiController]
    [Route("api/user")]
    [Authorize]
    public class UserController : BaseController
    {
        public UserController(IMediator mediator) : base(mediator)
        {
        }
        [HttpPost]
        [AllowAnonymous]
        [ProducesResponseType((int)HttpStatusCode.Accepted)]
        public async Task<ActionResult> Create([FromBody] RegisterUserCommand command) =>
            await ExecuteCommand(async () => await _mediator.Send(command));
        [HttpPost("login")]
        [AllowAnonymous]
        [ProducesResponseType(typeof(Response<string>), (int)HttpStatusCode.OK)]
        public async Task<ActionResult> LoginUser([FromBody] LoginUserQuery query) =>
            await ExecuteQuery(async () => await _mediator.Send(query));
    }
}
