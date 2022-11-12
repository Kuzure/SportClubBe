using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SportClub.Application.CQRS.Group.Command;
using System.Net;
using SportClub.Application.CQRS.Competitor.Query;
using SportClub.Application.CQRS.Group.Query;
using SportClub.Infrastructure;
using SportClub.Infrastructure.Models;

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
        [HttpGet("pageable")]
        [ProducesResponseType(typeof(PaginationResponse<IEnumerable<GroupListModel>>), (int)HttpStatusCode.OK)]
        public async Task<ActionResult> GetGroupList([FromQuery] GetGroupListQuery query) =>
            await ExecuteQuery(async () => await _mediator.Send(query));
    }
}
