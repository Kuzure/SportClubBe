using AutoMapper;
using SportClub.Application.Dto;
using SportClub.Domain.Entity;

namespace SportClub.Application.Profiles
{
    public class CompetitorProfile : Profile
    {
        public CompetitorProfile()
        {
            CreateMap<Competitor, CompetitorListModel>()
                .ForMember(dest => dest.FirstName, opt => opt.MapFrom(src => src.Identity.FirstName))
                .ForMember(dest => dest.LastName, opt => opt.MapFrom(src => src.Identity.LastName))
                .ForMember(dest => dest.DateOfBirth, opt => opt.MapFrom(src => src.Identity.DateOfBirth))
                .ForMember(dest => dest.Degree, opt => opt.MapFrom(src => src.Identity.Degree))
                .ForMember(dest => dest.PhoneNumber, opt => opt.MapFrom(src => src.Identity.PhoneNumber))
                .ForMember(dest => dest.Gender, opt => opt.MapFrom(src => src.Identity.Gender))
                .ForMember(dest => dest.GroupName, opt => opt.MapFrom(src => src.Group.Name));
        }
    }
}
