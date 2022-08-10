using MediatR;
using SportClub.Api.Extension;

namespace SportClub.Api.CQRS.Query
{
    public class LoginUserQuery : IRequest<Response<string>>
    {
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
    }
}
