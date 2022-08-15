using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SportClub.Application.CQRS.Group.Command;
using System.Net;

namespace SportClub.Api.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/group")]
    public class GroupConttroler : BaseController
    {
        public GroupConttroler(IMediator mediator) : base(mediator)
        {
        }

        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.Accepted)]
        public async Task<ActionResult> Create([FromBody] AddGroupCommand command) =>
            await ExecuteCommand(async () => await _mediator.Send(command));
    }
}
