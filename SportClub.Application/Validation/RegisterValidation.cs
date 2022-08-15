using FluentValidation;
using SportClub.Application.CQRS.Command;
using SportClub.Persistance;

namespace SportClub.Application.Validation
{
    public class RegisterValidation : AbstractValidator<RegisterUserCommand>
    {
        public RegisterValidation(SportClubDbContext dbContext)
        {
            RuleFor(x => x.Email).NotEmpty().EmailAddress().Custom((value, context) =>
            {
                if (dbContext.Users.Any(x => x.Email == value))
                    context.AddFailure("This email is already taken");
            });

            RuleFor(x => x.Password).NotEmpty().MinimumLength(5);
        }
    }
}
