
using AutoMapper;
using SportClub.Application.CQRS.User.Command;
using SportClub.Domain.Entity;

namespace SportClub.Application.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<RegisterUserCommand, User>().ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email))
                .AfterMap((src, dest) =>
            {
                dest.Identity = new Identity();
                dest.Identity.FirstName = src.FirstName;
                dest.Identity.LastName = src.LastName;
                dest.Identity.PhoneNumber = src.PhoneNumber;
                dest.Identity.DateOfBirth = src.DateOfBirth;
                dest.Identity.Degree = src.Degree;
                dest.Identity.Gender = src.Gender;
                dest.Identity.Competitor = new Competitor();
                dest.Identity.Competitor.IsPaid = false;
            });
            CreateMap<User, RegisterUserCommand>();
        }

    }
}
