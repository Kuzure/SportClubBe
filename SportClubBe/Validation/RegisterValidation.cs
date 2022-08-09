using FluentValidation;
using SportClub.Api.CQRS.Command;
using SportClubBe.Entity;

namespace SportClub.Api.Validation
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
