using AutoMapper;
using SportClub.Api.CQRS.Group.Command;
using SportClubBe.Entity;

namespace SportClub.Api.Profiles
{
    public class GroupProfile : Profile
    {
        public GroupProfile()
        {
            CreateMap<Group, AddGroupCommand>().ReverseMap();
        }
        
    }
}
