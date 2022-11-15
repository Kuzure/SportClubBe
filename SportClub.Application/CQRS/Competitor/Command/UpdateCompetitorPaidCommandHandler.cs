using AutoMapper;
using MediatR;
using SportClub.Application.Interface;
using SportClub.Domain.Entity;
using System.Linq;
namespace SportClub.Application.CQRS.Competitor.Command
{
    public class UpdateCompetitorPaidCommandHandler : IRequestHandler<UpdateCompetitorPaidCommand, SportClub.Domain.Entity.Competitor>
    {
        private readonly IRepository<SportClub.Domain.Entity.Competitor> _repository;
        public UpdateCompetitorPaidCommandHandler(IRepository<SportClub.Domain.Entity.Competitor> repository)
        {
            _repository = repository;
        }

        public async Task<SportClub.Domain.Entity.Competitor> Handle(UpdateCompetitorPaidCommand request, CancellationToken cancellationToken)
        {

            var competitor = await _repository.GetById(request.Id);
            if (competitor == null) return default!;
            competitor.Is_Paid = request.Is_Paid;
            await _repository.Update(competitor);
            return default!;
        }
    }
}
