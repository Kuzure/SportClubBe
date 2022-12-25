using System.Net;
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
        await ExecuteCommand(async () => await Mediator.Send(command));
    
    [HttpGet("pageable")]
    [ProducesResponseType(typeof(PaginationResponse<IEnumerable<ExerciseListModel>>), (int)HttpStatusCode.OK)]
    public async Task<ActionResult> GetExerciseList([FromQuery] GetExerciseListQuery query) =>
        await ExecuteQuery(async () => await Mediator.Send(query));
    [HttpPut("addToGroup")]
    [AllowAnonymous]
    [ProducesResponseType(typeof(Response<string>), (int)HttpStatusCode.OK)]
    public async Task<ActionResult> AddExerciseToGroup([FromBody] AddExerciseToGroupQuery query) =>
        await ExecuteQuery(async () => await Mediator.Send(query));
    [HttpGet("")]
    [ProducesResponseType(typeof(Response<ExerciseListModel>), (int)HttpStatusCode.OK)]
    public async Task<ActionResult> GetCoachById([FromQuery] GetExerciseByIdQuery query) =>
        await ExecuteQuery(async () => await Mediator.Send(query));
    [HttpPut("")]
    [ProducesResponseType((int)HttpStatusCode.Accepted)]
    public async Task<ActionResult> Update([FromBody] UpdateExerciseCommand command) =>
        await ExecuteCommand(async () => await Mediator.Send(command));
    [HttpDelete("")]
    [ProducesResponseType((int)HttpStatusCode.Accepted)]
    public async Task<ActionResult> Delete([FromQuery] DeleteExerciseCommand command) =>
        await ExecuteQuery(async () => await Mediator.Send(command));
    [HttpPut("disconnectedExerciseFromGroup")]
    [ProducesResponseType(typeof(Response<string>), (int)HttpStatusCode.OK)]
    public async Task<ActionResult> DisconnectExercise([FromQuery] DisconnectExerciseQuery query) =>
        await ExecuteQuery(async () => await Mediator.Send(query));
    [HttpGet("all")]
    [ProducesResponseType(typeof(Response<IEnumerable<ExerciseListModel>>), (int)HttpStatusCode.OK)]
    public async Task<ActionResult> GetExerciseList([FromQuery] GetExerciseQuery query) =>
        await ExecuteQuery(async () => await Mediator.Send(query));
    
    [HttpPut("AddExerciseToGroup")]
    [ProducesResponseType((int)HttpStatusCode.Accepted)]
    public async Task<ActionResult> AddExerciseToGroupCommand([FromBody] AddExerciseToGroupCommand command) =>
        await ExecuteCommand(async () => await Mediator.Send(command));
}