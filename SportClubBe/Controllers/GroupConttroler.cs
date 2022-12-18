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
    public class GroupController : BaseController
    {
        public GroupController(IMediator mediator) : base(mediator) 
        {
        }
        [HttpGet("id")]
        [ProducesResponseType(typeof(Response<GroupDetailsModel>), (int)HttpStatusCode.OK)]
        public async Task<ActionResult> GetGroupById([FromQuery] GetGroupByIdQuery query) =>
            await ExecuteQuery(async () => await _mediator.Send(query));
        [HttpGet]
        [ProducesResponseType(typeof(Response<IEnumerable<GroupListModel>>), (int)HttpStatusCode.OK)]
        public async Task<ActionResult> GetGroupList([FromQuery] GetGroupsQuery query) =>
            await ExecuteQuery(async () => await _mediator.Send(query));
        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.Accepted)]
        public async Task<ActionResult> Create([FromBody] AddGroupCommand command) =>
            await ExecuteCommand(async () => await _mediator.Send(command));
        [HttpGet("pageable")]
        [ProducesResponseType(typeof(PaginationResponse<IEnumerable<GroupListModel>>), (int)HttpStatusCode.OK)]
        public async Task<ActionResult> GetGroupListPageable([FromQuery] GetGroupListQuery query) =>
            await ExecuteQuery(async () => await _mediator.Send(query));
        [HttpPut("")]
        [ProducesResponseType((int)HttpStatusCode.Accepted)]
        public async Task<ActionResult> Create([FromBody] UpdateGroupCommand command) =>
            await ExecuteCommand(async () => await _mediator.Send(command));
        [HttpDelete("")]
        [ProducesResponseType((int)HttpStatusCode.Accepted)]
        public async Task<ActionResult> Delete([FromQuery] DeleteGroupCommand command) =>
            await ExecuteQuery(async () => await _mediator.Send(command));
    }
}
