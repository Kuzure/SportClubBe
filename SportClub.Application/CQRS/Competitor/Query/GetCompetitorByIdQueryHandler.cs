using AutoMapper;
using MediatR;
using SportClub.Application.Interface;
using SportClub.Infrastructure.Models;
using System.ComponentModel;

namespace SportClub.Application.CQRS.Competitor.Query;

public class GetCompetitorByIdQueryHandler : IRequestHandler<GetCompetitorByIdQuery, CompetitorDetail>
{
    private readonly ICompetitorRepository _competitorRepository;
    private readonly IMapper _mapper;

    public GetCompetitorByIdQueryHandler(ICompetitorRepository competitorRepository, IMapper mapper)
    {
        _competitorRepository = competitorRepository;
        _mapper = mapper;
    }
    public async Task<CompetitorDetail> Handle(GetCompetitorByIdQuery request, CancellationToken cancellationToken)
    {
        var entity = await _competitorRepository.GetById(request.Id);
        var identityData = new IdentityData()
        {
            FirstName = entity.Identity.FirstName,
            LastName = entity.Identity.LastName,
            DateOfBirth = entity.Identity.DateOfBirth,
            PhoneNumber = entity.Identity.PhoneNumber,
            Degree = EnumExtensionMethodsHelpers. GetEnumDescription(entity.Identity.Degree),
            Gender = EnumExtensionMethodsHelpers.GetEnumDescription(entity.Identity.Gender),
        };
        var competitor = new CompetitorData()
        {
            Id = entity.Id,
            IsPaid = entity.IsPaid,
            MedicalExaminationExpiryDate = entity.MedicalExaminationExpiryDate
        };
        var group = new GroupData()
        {
            GroupId = entity.GroupId,
            GroupName = entity.Group.Name
        };
        CompetitorDetail result = new CompetitorDetail()
        {
            IdentityData = identityData,
            CompetitorData = competitor,
            GroupData = group
        };
        return result;
    }
    public static class EnumExtensionMethods
    {
    }
}