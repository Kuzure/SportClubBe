using MediatR;
using SportClub.Application.Interface;
using SportClub.Domain.Enum;
using SportClub.Persistance;

namespace SportClub.Application.CQRS.Coach.Command;

public class UpdateCoachCommandHandler: IRequestHandler<UpdateCoachCommand, SportClub.Domain.Entity.Coach>
{
    private readonly SportClubDbContext _dbContext;
    private readonly ICoachRepository _coachRepository;
    public UpdateCoachCommandHandler(ICoachRepository coachRepository,SportClubDbContext dbContext)
    {
        _coachRepository = coachRepository;
        _dbContext = dbContext;
    }

    public async Task<SportClub.Domain.Entity.Coach> Handle(UpdateCoachCommand request, CancellationToken cancellationToken)
    {

        var coach = await _coachRepository.GetById(request.Id);
        if (coach == null) return default!;
        coach.CoachClass = request.CoachClass;
        coach.Identity.FirstName = request.FirstName;
        coach.Identity.LastName = request.LastName;
        if (request.Gender != null) coach.Identity.Gender = (Gender)Enum.Parse(typeof(Gender), request.Gender, true);
        coach.Identity.DateOfBirth = request.DateOfBirth;
        coach.Identity.PhoneNumber = request.PhoneNumber;
        await _coachRepository.Update(coach);
        await _dbContext.SaveChangesAsync(cancellationToken);
        return default!;
    }
}
