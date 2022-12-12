using System.ComponentModel;
using AutoMapper;
using SportClub.Application.CQRS.Coach.Command;
using SportClub.Domain.Entity;
using SportClub.Infrastructure.Models;

namespace SportClub.Application.Profiles;

public class CoachProfile : Profile
{
    public CoachProfile()
    {
        CreateMap<Coach, AddCoachCommand>()
            .ForMember(dest => dest.FirstName, opt => opt.MapFrom(src => src.Identity.FirstName))
            .ForMember(dest => dest.LastName, opt => opt.MapFrom(src => src.Identity.LastName))
            .ForMember(dest => dest.DateOfBirth, opt => opt.MapFrom(src => src.Identity.DateOfBirth))
            .ForMember(dest => dest.Degree, opt => opt.MapFrom(src => src.Identity.Degree))
            .ForMember(dest => dest.PhoneNumber, opt => opt.MapFrom(src => src.Identity.PhoneNumber))
            .ForMember(dest => dest.Gender, opt => opt.MapFrom(src => src.Identity.Gender)).ReverseMap();
        CreateMap<Coach, CoachListModel>()
            .ForMember(dest => dest.FirstName, opt => opt.MapFrom(src => src.Identity.FirstName))
            .ForMember(dest => dest.LastName, opt => opt.MapFrom(src => src.Identity.LastName))
            .ForMember(dest => dest.DateOfBirth, opt => opt.MapFrom(src => src.Identity.DateOfBirth))
            .ForMember(dest => dest.PhoneNumber, opt => opt.MapFrom(src => src.Identity.PhoneNumber))
            .ForMember(dest => dest.Gender, opt => opt.MapFrom(src => src.Identity.Gender.GetEnumDescription()))
            .ForMember(dest => dest.CoachGroups, opt => opt.MapFrom(src => src.CoachGroups)).ReverseMap();
        CreateMap<CoachGroup, CoachGroupListModel>()
            .ForMember(dest => dest.GroupName, opt => opt.MapFrom(src => src.Group.Name))
            .ForMember(dest => dest.GroupId, opt => opt.MapFrom(src => src.GroupId)).ReverseMap();
    }
}