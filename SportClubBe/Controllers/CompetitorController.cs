using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SportClub.Application.CQRS.Competitor.Command;
using SportClub.Application.CQRS.Competitor.Query;
using SportClub.Infrastructure;
using SportClub.Infrastructure.Models;
using System.Net;
using SportClub.Application.CQRS.Group.Query;
using SportClub.Application.CQRS.Query;

namespace SportClub.Api.Controllers
{
    [ApiController]
    [Authorize]
    [Route("api/competitor")]
    public class CompetitorController : BaseController
    {
        public CompetitorController(IMediator mediator): base(mediator)
        {

        }
        [HttpPut("")]
        [ProducesResponseType((int)HttpStatusCode.Accepted)]
        public async Task<ActionResult> Create([FromBody] UpdateCompetitorCommand command) =>
            await ExecuteCommand(async () => await _mediator.Send(command));
        [HttpGet("")]
        [ProducesResponseType(typeof(Response<CompetitorListModel>), (int)HttpStatusCode.OK)]
        public async Task<ActionResult> GetCompetitorById([FromQuery] GetCompetitorByIdQuery query) =>
            await ExecuteQuery(async () => await _mediator.Send(query));
        [HttpGet("pageable")]
        [ProducesResponseType(typeof(PaginationResponse<IEnumerable<CompetitorListModel>>), (int)HttpStatusCode.OK)]
        public async Task<ActionResult> GetCompetitorList([FromQuery] GetCompetitorListQuery query) =>
            await ExecuteQuery(async () => await _mediator.Send(query));
        [HttpPut("paid")]
        [ProducesResponseType((int)HttpStatusCode.Accepted)]
        public async Task<ActionResult> Create([FromBody] UpdateCompetitorPaidCommand command) =>
            await ExecuteCommand(async () => await _mediator.Send(command));

        [HttpPost("add")]
        [ProducesResponseType((int)HttpStatusCode.Accepted)]
        public async Task<ActionResult> Add([FromBody] AddCompetitorCommand command) =>
            await ExecuteCommand(async () => await _mediator.Send(command));
        
        [HttpPost("addToGroup")]
        [ProducesResponseType(typeof(Response<string>), (int)HttpStatusCode.OK)]
        public async Task<ActionResult> AddCompetitorToGroup([FromBody] AddCompetitorToGroupQuery query) =>
            await ExecuteQuery(async () => await _mediator.Send(query));
        [HttpDelete("")]
        [ProducesResponseType((int)HttpStatusCode.Accepted)]
        public async Task<ActionResult> Delete([FromQuery] DeleteCompetitorCommand command) =>
            await ExecuteQuery(async () => await _mediator.Send(command));
        
        [HttpPut("disconnectedCompetitorFromGroup")]
        [ProducesResponseType(typeof(Response<string>), (int)HttpStatusCode.OK)]
        public async Task<ActionResult> DisconnectCompetitor([FromQuery] DisconnectCompetitorQuery query) =>
            await ExecuteQuery(async () => await _mediator.Send(query));
        [HttpGet("all")]
        [ProducesResponseType(typeof(Response<IEnumerable<CompetitorModel>>), (int)HttpStatusCode.OK)]
        public async Task<ActionResult> GetCompetitorList([FromQuery] GetCompetitorsQuery query) =>
            await ExecuteQuery(async () => await _mediator.Send(query));
        [HttpPut("AddCompetitorsToGroup")]
        [ProducesResponseType((int)HttpStatusCode.Accepted)]
        public async Task<ActionResult> AddCoaches([FromBody] AddCompetitorsToGroupCommand command) =>
            await ExecuteCommand(async () => await _mediator.Send(command));
    }
}
