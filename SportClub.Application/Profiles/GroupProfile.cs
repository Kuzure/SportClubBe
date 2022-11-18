using AutoMapper;
using SportClub.Application.CQRS.Group.Command;
using SportClub.Application.CQRS.Group.Query;
using SportClub.Domain.Entity;
using SportClub.Infrastructure.Models;

namespace SportClub.Application.Profiles
{
    public class GroupProfile : Profile
    {
        public GroupProfile()
        {
            CreateMap<Group, AddGroupCommand>().ReverseMap();
            CreateMap<Group, GroupListModel >().ReverseMap();
            CreateMap<Group, GroupDetailsModel >().ReverseMap();
        }
        
    }
}
