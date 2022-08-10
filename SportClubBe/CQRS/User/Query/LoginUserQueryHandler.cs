﻿using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using SportClub.Api.CQRS.Query;
using SportClub.Api.Extension;
using SportClub.Api.Interface;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace SportClub.Api.CQRS.User.Query
{
    public class LoginUserQueryHandler : IRequestHandler<LoginUserQuery, Response<string>>
    {
        private readonly IRepository<SportClubBe.Entity.User> _userRepository;
        private readonly IPasswordHasher<SportClubBe.Entity.User> _passwordHasher;
        private readonly IConfiguration _configuration;

        public LoginUserQueryHandler(IUserRepository userRepository, IPasswordHasher<SportClubBe.Entity.User> passwordHasher, IConfiguration configuration)
        {
            _userRepository = userRepository;
            _passwordHasher = passwordHasher;
            _configuration = configuration;
        }

        public async Task<Response<string>> Handle(LoginUserQuery request, CancellationToken cancellationToken)
        {
            var user = await _userRepository.GetByPredicate(x => x.Email == request.Email);
            if (user is null)
                throw new Exception("User credentials are wrong!");

            var passwordVerifyResult = _passwordHasher.VerifyHashedPassword(user, user.Password, request.Password);
            if (passwordVerifyResult == PasswordVerificationResult.Failed)
                throw new Exception("User credentials are wrong!");

            //everything is ok! generate the JWT Bearer
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.UTF8.GetBytes(_configuration.GetSection("JWTConfiguration:SecretKey").Get<string>());
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                    new Claim(ClaimTypes.Email, user.Email),
                    new Claim(ClaimTypes.Name, user.Identity.FirstName),
                    new Claim(ClaimTypes.GivenName, user.Identity.LastName),
                    new Claim(ClaimTypes.Role, user.Role.Name)

                }),
                Expires = DateTime.UtcNow.AddHours(1),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            return new Response<string>(tokenHandler.WriteToken(token));
        }
    }
}
