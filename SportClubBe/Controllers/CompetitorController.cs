using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SportClub.Application.CQRS.Competitor.Command;
using SportClub.Application.CQRS.Competitor.Query;
using SportClub.Infrastructure;
using SportClub.Infrastructure.Models;
using System.Net;

namespace SportClub.Api.Controllers
{
    [ApiController]
    [Authorize]
    [Route("api/[controller]")]
    public class CompetitorController : BaseController
    {
        public CompetitorController(IMediator mediator): base(mediator)
        {

        }
        [HttpGet("pageable")]
        [ProducesResponseType(typeof(PaginationResponse<IEnumerable<CompetitorListModel>>), (int)HttpStatusCode.OK)]
        public async Task<ActionResult> GetCompetitorList([FromQuery] GetCompetitorListQuery query) =>
            await ExecuteQuery(async () => await _mediator.Send(query));
        [HttpPut("Paid")]
        [ProducesResponseType((int)HttpStatusCode.Accepted)]
        public async Task<ActionResult> Create([FromBody] UpdateCompetitorPaidCommand command) =>
            await ExecuteCommand(async () => await _mediator.Send(command));

        [HttpPost("Add")]
        [ProducesResponseType((int)HttpStatusCode.Accepted)]
        public async Task<ActionResult> Add([FromBody] AddCompetitorCommand command) =>
            await ExecuteCommand(async () => await _mediator.Send(command));
    }
}
