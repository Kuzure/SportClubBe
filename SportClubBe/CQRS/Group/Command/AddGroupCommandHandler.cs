using AutoMapper;
using MediatR;
using SportClub.Api.Interface;

namespace SportClub.Api.CQRS.Group.Command
{
    public class AddGroupCommandHandler : IRequestHandler<AddGroupCommand, SportClubBe.Entity.Group>
    {
        private readonly IRepository<SportClubBe.Entity.Group> _repository;
        private readonly IMapper _mapper;

        public AddGroupCommandHandler(IRepository<SportClubBe.Entity.Group> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<SportClubBe.Entity.Group> Handle(AddGroupCommand request, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<SportClubBe.Entity.Group>(request);
            await _repository.Save(entity);
            return default!;
        }
    }
}
