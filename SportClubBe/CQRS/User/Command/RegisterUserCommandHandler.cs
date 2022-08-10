using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Identity;
using SportClub.Api.CQRS.Command;
using SportClub.Api.Interface;
using SportClubBe.Entity;

namespace SportClub.Api.CQRS.User.Command
{
    public class RegisterUserCommandHandler : IRequestHandler<RegisterUserCommand, SportClubBe.Entity.User>
    {
        private readonly IRepository<SportClubBe.Entity.User> _repository;
        private readonly IMapper _mapper;
        private readonly IPasswordHasher<SportClubBe.Entity.User> _passwordHasger;
        private readonly IRepository<Role> _roleRepository;

        public RegisterUserCommandHandler(IRepository<SportClubBe.Entity.User> repository, IMapper mapper, IPasswordHasher<SportClubBe.Entity.User> passwordHasher, IRepository<Role> roleRepository)
        {
            _passwordHasger = passwordHasher;
            _repository = repository;
            _mapper = mapper;
            _roleRepository = roleRepository;
        }
        public async Task<SportClubBe.Entity.User> Handle(RegisterUserCommand request, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<SportClubBe.Entity.User>(request);
            entity.Password = _passwordHasger.HashPassword(entity, request.Password);
            var role = await _roleRepository.GetByPredicate(x => x.Name == "Competitor");
            entity.RoleId = role.Id;
            await _repository.Save(entity);
            return default!;
        }
    }
}
