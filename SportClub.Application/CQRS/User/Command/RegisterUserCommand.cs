using MediatR;
using SportClub.Domain.Enum;

namespace SportClub.Application.CQRS.Command
{
    public class RegisterUserCommand : IRequest<SportClub.Domain.Entity.User>
    {
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public DateTime DateOfBirth { get; set; }
        public string PhoneNumber { get; set; } = null!;
        public Gender Gender { get; set; }
        public Degree? Degree { get; set; }
        public bool Is_Paid { get; set; }
    }
}
