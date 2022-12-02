using MediatR;
using SportClub.Application.Interface;
using SportClub.Domain.Enum;
using SportClub.Persistance;

namespace SportClub.Application.CQRS.Competitor.Command;

public class UpdateCompetitorCommandHandler: IRequestHandler<UpdateCompetitorCommand, SportClub.Domain.Entity.Competitor>
{
    private readonly SportClubDbContext _dbContext;
    private readonly ICompetitorRepository _competitorRepository;
    public UpdateCompetitorCommandHandler(  ICompetitorRepository competitorRepository,SportClubDbContext dbContext)
    {
        _competitorRepository = competitorRepository;
        _dbContext = dbContext;
    }

    public async Task<SportClub.Domain.Entity.Competitor> Handle(UpdateCompetitorCommand request, CancellationToken cancellationToken)
    {

        var competitor = await _competitorRepository.GetById(request.Id);
        if (competitor == null) return default!;
        competitor.GroupId = request.GroupId;
        competitor.MedicalExaminationExpiryDate = request.MedicalExaminationExpiryDate;
        competitor.Is_Paid = request.Is_Paid;
        competitor.Identity.FirstName = request.FirstName;
        competitor.Identity.LastName = request.LastName;
        if (request.Degree != null)
            competitor.Identity.Degree = (Degree)Enum.Parse(typeof(Degree), request.Degree, true);
        competitor.Identity.Gender = (Gender)Enum.Parse(typeof(Gender), request.Gender, true);
        competitor.Identity.DateOfBirth = request.DateOfBirth;
        competitor.Identity.PhoneNumber = request.PhoneNumber;
        await _competitorRepository.Update(competitor);
        await _dbContext.SaveChangesAsync();
        return default!;
    }
}
