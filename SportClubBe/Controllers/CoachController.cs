﻿using System.Net;
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
        await ExecuteCommand(async () => await Mediator.Send(command));
    [HttpGet("pageable")]
    [ProducesResponseType(typeof(PaginationResponse<IEnumerable<CoachListModel>>), (int)HttpStatusCode.OK)]
    public async Task<ActionResult> GetCompetitorList([FromQuery] GetCoachListQuery query) =>
        await ExecuteQuery(async () => await Mediator.Send(query));
    [HttpPut("addToGroup")]
    [AllowAnonymous]
    [ProducesResponseType(typeof(Response<string>), (int)HttpStatusCode.OK)]
    public async Task<ActionResult> AddCompetitorToGroup([FromBody] AddCoachToGroupQuery query) =>
        await ExecuteQuery(async () => await Mediator.Send(query));
    [HttpGet("")]
    [ProducesResponseType(typeof(Response<CoachListModel>), (int)HttpStatusCode.OK)]
    public async Task<ActionResult> GetCoachById([FromQuery] GetCoachByIdQuery query) =>
        await ExecuteQuery(async () => await Mediator.Send(query));
    [HttpPut("")]
    [ProducesResponseType((int)HttpStatusCode.Accepted)]
    public async Task<ActionResult> Update([FromBody] UpdateCoachCommand command) =>
        await ExecuteCommand(async () => await Mediator.Send(command));
    [HttpDelete("")]
    [ProducesResponseType((int)HttpStatusCode.Accepted)]
    public async Task<ActionResult> Delete([FromQuery] DeleteCoachCommand command) =>
        await ExecuteQuery(async () => await Mediator.Send(command));
    [HttpPut("disconnectedCoachFromGroup")]
    [ProducesResponseType(typeof(Response<string>), (int)HttpStatusCode.OK)]
    public async Task<ActionResult> DisconnectCoach([FromQuery] DisconnectCoachQuery query) =>
        await ExecuteQuery(async () => await Mediator.Send(query));
    [HttpGet("all")]
    [ProducesResponseType(typeof(Response<IEnumerable<CoachListModel>>), (int)HttpStatusCode.OK)]
    public async Task<ActionResult> GetCoachList([FromQuery] GetCoachesQuery query) =>
        await ExecuteQuery(async () => await Mediator.Send(query));
    [HttpPut("AddCoachesToGroup")]
    [ProducesResponseType((int)HttpStatusCode.Accepted)]
    public async Task<ActionResult> AddCoaches([FromBody] AddCoachesToGroupCommand command) =>
        await ExecuteCommand(async () => await Mediator.Send(command));
}