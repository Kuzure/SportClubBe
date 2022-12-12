using System.Net;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SportClub.Application.CQRS.Coach.Command;
using SportClub.Application.CQRS.Coach.Query;
using SportClub.Infrastructure;
using SportClub.Infrastructure.Models;

namespace SportClub.Api.Controllers;

[ApiController]
[Authorize]
[Route("api/coach")]
public class CoachController : BaseController
{
    public CoachController(IMediator mediator): base(mediator)
    {

    }
    [HttpPost("")]
    [ProducesResponseType((int)HttpStatusCode.Accepted)]
    public async Task<ActionResult> Add([FromBody] AddCoachCommand command) =>
        await ExecuteCommand(async () => await _mediator.Send(command));
    [HttpGet("pageable")]
    [ProducesResponseType(typeof(PaginationResponse<IEnumerable<CoachListModel>>), (int)HttpStatusCode.OK)]
    public async Task<ActionResult> GetCompetitorList([FromQuery] GetCoachListQuery query) =>
        await ExecuteQuery(async () => await _mediator.Send(query));
    [HttpPut("addToGroup")]
    [AllowAnonymous]
    [ProducesResponseType(typeof(Response<string>), (int)HttpStatusCode.OK)]
    public async Task<ActionResult> AddCompetitorToGroup([FromBody] AddCoachToGroupQuery query) =>
        await ExecuteQuery(async () => await _mediator.Send(query));
    [HttpGet("")]
    [ProducesResponseType(typeof(Response<CoachListModel>), (int)HttpStatusCode.OK)]
    public async Task<ActionResult> GetCoachById([FromQuery] GetCoachByIdQuery query) =>
        await ExecuteQuery(async () => await _mediator.Send(query));
    [HttpPut("")]
    [ProducesResponseType((int)HttpStatusCode.Accepted)]
    public async Task<ActionResult> Update([FromBody] UpdateCoachCommand command) =>
        await ExecuteCommand(async () => await _mediator.Send(command));
}