﻿using System.Net;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SportClub.Application.CQRS.Exercise.Command;
using SportClub.Application.CQRS.Exercise.Query;
using SportClub.Infrastructure;
using SportClub.Infrastructure.Models;

namespace SportClub.Api.Controllers;

[ApiController]
[Authorize]
[Route("api/exercise")]
public class ExerciseController: BaseController
{
    public ExerciseController(IMediator mediator) : base(mediator) 
    {
    }
    [HttpPost("")]
    [ProducesResponseType((int)HttpStatusCode.Accepted)]
    public async Task<ActionResult> Add([FromBody] AddExerciseCommand command) =>
        await ExecuteCommand(async () => await _mediator.Send(command));
    
    [HttpGet("pageable")]
    [ProducesResponseType(typeof(PaginationResponse<IEnumerable<ExerciseListModel>>), (int)HttpStatusCode.OK)]
    public async Task<ActionResult> GetExerciseList([FromQuery] GetExerciseListQuery query) =>
        await ExecuteQuery(async () => await _mediator.Send(query));
    [HttpPut("addToGroup")]
    [AllowAnonymous]
    [ProducesResponseType(typeof(Response<string>), (int)HttpStatusCode.OK)]
    public async Task<ActionResult> AddExerciseToGroup([FromBody] AddExerciseToGroupQuery query) =>
        await ExecuteQuery(async () => await _mediator.Send(query));
    [HttpGet("")]
    [ProducesResponseType(typeof(Response<ExerciseListModel>), (int)HttpStatusCode.OK)]
    public async Task<ActionResult> GetCoachById([FromQuery] GetExerciseByIdQuery query) =>
        await ExecuteQuery(async () => await _mediator.Send(query));
    [HttpPut("")]
    [ProducesResponseType((int)HttpStatusCode.Accepted)]
    public async Task<ActionResult> Update([FromBody] UpdateExerciseCommand command) =>
        await ExecuteCommand(async () => await _mediator.Send(command));
}