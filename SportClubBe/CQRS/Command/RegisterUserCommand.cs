using MediatR;
using SportClubBe.Entity;
using SportClubBe.Enum;

namespace SportClub.Api.CQRS.Command
{
    public class RegisterUserCommand : IRequest<User>
    {
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public DateTime DateOfBirth { get; set; }
        public string PhoneNumber { get; set; } = null!;
        public Gender Gender { get; set; }
        public Degree? Degree { get; set; }
    }
}
