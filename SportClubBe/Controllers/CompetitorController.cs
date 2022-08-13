using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SportClub.Api.CQRS.Competitor.Query;
using SportClub.Api.Dto;
using SportClub.Api.Extension;
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
    }
}
