using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Identity;
using SportClub.Application.CQRS.Command;
using SportClub.Application.Interface;
using SportClub.Domain.Entity;

namespace SportClub.Application.CQRS.User.Command
{
    public class RegisterUserCommandHandler : IRequestHandler<RegisterUserCommand, SportClub.Domain.Entity.User>
    {
        private readonly IRepository<SportClub.Domain.Entity.User> _repository;
        private readonly IMapper _mapper;
        private readonly IPasswordHasher<SportClub.Domain.Entity.User> _passwordHasger;
        private readonly IRepository<Role> _roleRepository;

        public RegisterUserCommandHandler(IRepository<SportClub.Domain.Entity.User> repository, IMapper mapper, IPasswordHasher<SportClub.Domain.Entity.User> passwordHasher, IRepository<Role> roleRepository)
        {
            _passwordHasger = passwordHasher;
            _repository = repository;
            _mapper = mapper;
            _roleRepository = roleRepository;
        }
        public async Task<SportClub.Domain.Entity.User> Handle(RegisterUserCommand request, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<SportClub.Domain.Entity.User>(request);
            entity.Password = _passwordHasger.HashPassword(entity, request.Password);
            var role = await _roleRepository.GetByPredicate(x => x.Name == "Competitor");
            entity.RoleId = role.Id;
            await _repository.Save(entity);
            return default!;
        }
    }
}
