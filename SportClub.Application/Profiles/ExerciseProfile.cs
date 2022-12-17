using AutoMapper;
using SportClub.Application.CQRS.Exercise.Command;
using SportClub.Domain.Entity;
using SportClub.Infrastructure.Models;

namespace SportClub.Application.Profiles;

public class ExerciseProfile: Profile
{
    public ExerciseProfile()
    {
        CreateMap<Exercise, ExerciseListModel>().ReverseMap();
        CreateMap<Exercise, AddExerciseCommand>().ReverseMap();
        CreateMap<GroupExercise, ExerciseGroupListModel>()
            .ForMember(dest => dest.GroupName, opt => opt.MapFrom(src => src.Group.Name))
            .ForMember(dest => dest.GroupId, opt => opt.MapFrom(src => src.GroupId)).ReverseMap();
    }

}