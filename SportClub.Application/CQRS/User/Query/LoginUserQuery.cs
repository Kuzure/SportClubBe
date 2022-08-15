using MediatR;
using SportClub.Application.Extension;

namespace SportClub.Application.CQRS.Query
{
    public class LoginUserQuery : IRequest<Response<string>>
    {
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
    }
}
