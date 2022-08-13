using AutoMapper;
using SportClub.Api.CQRS.Command;
using SportClubBe.Entity;

namespace SportClub.Api.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<RegisterUserCommand, User>().AfterMap((src, dest) =>
            {
                dest.Identity = new Identity();
                dest.Identity.FirstName = src.FirstName;
                dest.Identity.LastName = src.LastName;
                dest.Identity.PhoneNumber = src.PhoneNumber;
                dest.Identity.DateOfBirth = src.DateOfBirth;
                dest.Identity.Degree = src.Degree;
                dest.Identity.Gender = src.Gender;
                dest.Identity.Competitor = new Competitor();
                dest.Identity.Competitor.Is_Paid = false;
            });
        }

    }
}
