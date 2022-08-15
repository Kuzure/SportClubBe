using AutoMapper;
using SportClub.Application.CQRS.Group.Command;
using SportClub.Domain.Entity;

namespace SportClub.Application.Profiles
{
    public class GroupProfile : Profile
    {
        public GroupProfile()
        {
            CreateMap<Group, AddGroupCommand>().ReverseMap();
        }
        
    }
}
