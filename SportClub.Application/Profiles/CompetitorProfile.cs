using System.ComponentModel;
using AutoMapper;
using SportClub.Application.CQRS.Competitor.Command;
using SportClub.Domain.Entity;
using SportClub.Infrastructure.Models;

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
                .ForMember(dest => dest.Degree, opt => opt.MapFrom(src => src.Identity.Degree.ToString()))
                .ForMember(dest => dest.PhoneNumber, opt => opt.MapFrom(src => src.Identity.PhoneNumber))
                .ForMember(dest => dest.Gender, opt => opt.MapFrom(src => src.Identity.Gender.GetEnumDescription()))
                .ForMember(dest => dest.GroupId, opt => opt.MapFrom(src => src.Group. Id))
                .ForMember(dest => dest.GroupName, opt => opt.MapFrom(src => src.Group.Name)).ReverseMap();
            CreateMap<Competitor, AddCompetitorCommand>()
                .ForMember(dest => dest.FirstName, opt => opt.MapFrom(src => src.Identity.FirstName))
                .ForMember(dest => dest.LastName, opt => opt.MapFrom(src => src.Identity.LastName))
                .ForMember(dest => dest.DateOfBirth, opt => opt.MapFrom(src => src.Identity.DateOfBirth))
                .ForMember(dest => dest.Degree, opt => opt.MapFrom(src => src.Identity.Degree))
                .ForMember(dest => dest.PhoneNumber, opt => opt.MapFrom(src => src.Identity.PhoneNumber))
                .ForMember(dest => dest.Gender, opt => opt.MapFrom(src => src.Identity.Gender)).ReverseMap();
        }
    }
    public static class EnumExtensionMethods  
    {  
        public static string GetEnumDescription(this Enum enumValue)  
        {  
            var fieldInfo = enumValue.GetType().GetField(enumValue.ToString());  
  
            var descriptionAttributes = (DescriptionAttribute[])fieldInfo!.GetCustomAttributes(typeof(DescriptionAttribute), false);  
  
            return descriptionAttributes.Length > 0 ? descriptionAttributes[0].Description : enumValue.ToString();  
        }  
    }  
}
