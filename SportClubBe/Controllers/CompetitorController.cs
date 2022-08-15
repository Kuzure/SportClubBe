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
        [HttpGet("list")]
        [ProducesResponseType(typeof(Response<IEnumerable<CompetitorListModel>>), (int)HttpStatusCode.OK)]
        public async Task<ActionResult> GetRoomList([FromQuery] GetCompetitorListQuery query) =>
            await ExecuteQuery(async () => await _mediator.Send(query));
        [HttpPut("Paid")]
        [ProducesResponseType((int)HttpStatusCode.Accepted)]
        public async Task<ActionResult> Create([FromBody] UpdateCompetitorPaidCommand command) =>
            await ExecuteCommand(async () => await _mediator.Send(command));
    }
}
