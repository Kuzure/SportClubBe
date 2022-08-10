using AutoMapper;
using MediatR;
using SportClub.Api.Interface;
using SportClubBe.Entity;

namespace SportClub.Api.CQRS
{
    public class AddGroupCommandHandler : IRequestHandler<AddGroupCommand, Group>
    {
        private readonly IRepository<Group> _repository;
        private readonly IMapper _mapper;

        public AddGroupCommandHandler(IRepository<Group> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<Group> Handle(AddGroupCommand request, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<Group>(request);
            await _repository.Save(entity);
            return default!;
        }
    }
}
