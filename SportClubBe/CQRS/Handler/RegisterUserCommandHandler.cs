using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Identity;
using SportClub.Api.CQRS.Command;
using SportClub.Api.Interface;
using SportClubBe.Entity;

namespace SportClub.Api.CQRS.Handler
{
    public class RegisterUserCommandHandler : IRequestHandler<RegisterUserCommand, User>
    {
        private readonly IRepository<User> _repository;
        private readonly IMapper _mapper;
        private readonly IPasswordHasher<User> _passwordHasger;
        private readonly IRepository<Role> _roleRepository;

        public RegisterUserCommandHandler(IRepository<User> repository, IMapper mapper,IPasswordHasher<User> passwordHasher, IRepository<Role> roleRepository)
        {
            _passwordHasger = passwordHasher;
            _repository = repository;
            _mapper = mapper;
            _roleRepository = roleRepository;
        }
        public async Task<User> Handle(RegisterUserCommand request, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<User>(request);
            entity.Password = _passwordHasger.HashPassword(entity,request.Password);
            var role = await _roleRepository.GetByPredicate(x => x.Name == "Competitor");
            entity.RoleId = role.Id;
            await _repository.Save(entity);
            return default!;
        }
    }
}
