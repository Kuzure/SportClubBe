using AutoMapper;
using MediatR;
using SportClub.Application.Interface;

namespace SportClub.Application.CQRS.Group.Command
{
    public class AddGroupCommandHandler : IRequestHandler<AddGroupCommand, SportClub.Domain.Entity.Group>
    {
        private readonly IRepository<SportClub.Domain.Entity.Group> _repository;
        private readonly IMapper _mapper;

        public AddGroupCommandHandler(IRepository<SportClub.Domain.Entity.Group> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<SportClub.Domain.Entity.Group> Handle(AddGroupCommand request, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<SportClub.Domain.Entity.Group>(request);
            await _repository.Save(entity);
            return default!;
        }
    }
}
