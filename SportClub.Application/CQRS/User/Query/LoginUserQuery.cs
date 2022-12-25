using MediatR;
using SportClub.Infrastructure;

namespace SportClub.Application.CQRS.User.Query
{
    public class LoginUserQuery : IRequest<Response<string>>
    {
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
    }
}
