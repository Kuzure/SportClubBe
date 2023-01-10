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
            CreateMap<Competitor, CompetitorModel>()
                .ForMember(dest => dest.FirstName, opt => opt.MapFrom(src => src.Identity.FirstName))
                .ForMember(dest => dest.LastName, opt => opt.MapFrom(src => src.Identity.LastName))
                .ForMember(dest => dest.DateOfBirth, opt => opt.MapFrom(src => src.Identity.DateOfBirth))
                .ForMember(dest => dest.Degree, opt => opt.MapFrom(src => src.Identity.Degree.ToString()))
                .ForMember(dest => dest.PhoneNumber, opt => opt.MapFrom(src => src.Identity.PhoneNumber))
                .ForMember(dest => dest.Gender, opt => opt.MapFrom(src => src.Identity.Gender.GetEnumDescription())).ReverseMap();
            CreateMap<Competitor, CompetitorDetail>()
                .ForMember(dest => dest.CompetitorData.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.CompetitorData.IsPaid, opt => opt.MapFrom(src => src.IsPaid))
                .ForMember(dest => dest.CompetitorData.MedicalExaminationExpiryDate, opt => opt.MapFrom(src => src.MedicalExaminationExpiryDate))
                .ForMember(dest => dest.IdentityData.FirstName, opt => opt.MapFrom(src => src.Identity.FirstName))
                .ForMember(dest => dest.IdentityData.LastName, opt => opt.MapFrom(src => src.Identity.LastName))
                .ForMember(dest => dest.IdentityData.DateOfBirth, opt => opt.MapFrom(src => src.Identity.DateOfBirth))
                .ForMember(dest => dest.IdentityData.Degree, opt => opt.MapFrom(src => src.Identity.Degree.ToString()))
                .ForMember(dest => dest.IdentityData.PhoneNumber, opt => opt.MapFrom(src => src.Identity.PhoneNumber))
                .ForMember(dest => dest.IdentityData.Gender, opt => opt.MapFrom(src => src.Identity.Gender.GetEnumDescription()))
                .ForMember(dest => dest.GroupData.GroupId, opt => opt.MapFrom(src => src.Group. Id))
                .ForMember(dest => dest.GroupData.GroupName, opt => opt.MapFrom(src => src.Group.Name)).ReverseMap();
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
