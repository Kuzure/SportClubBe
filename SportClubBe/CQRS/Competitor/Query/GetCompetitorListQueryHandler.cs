﻿using AutoMapper;
using MediatR;
using SportClub.Api.Dto;
using SportClub.Api.Extension;
using SportClub.Api.Interface;

namespace SportClub.Api.CQRS.Competitor.Query
{
    public class GetCompetitorListQueryHandler : IRequestHandler<GetCompetitorListQuery, Response<IEnumerable<CompetitorListModel>>>
    {
        private readonly ICompetitorRepository _competitorRepository;
        private readonly IMapper _mapper;

        public GetCompetitorListQueryHandler(ICompetitorRepository competitorRepository, IMapper mapper)
        {
            _competitorRepository = competitorRepository;
            _mapper = mapper;
        }

        public async Task<Response<IEnumerable<CompetitorListModel>>> Handle(GetCompetitorListQuery request, CancellationToken cancellationToken)
        {
            var entities = await _competitorRepository.GetAll();
            var result = _mapper.Map<IEnumerable<CompetitorListModel>>(entities);
            return new Response<IEnumerable<CompetitorListModel>>(result);

        }
    }
}
