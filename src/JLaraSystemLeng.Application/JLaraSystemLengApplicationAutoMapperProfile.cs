using JLaraSystemLeng.Exercise;
using JLaraSystemLeng.Exercise.Dtos;
using JLaraSystemLeng.Progress;
using JLaraSystemLeng.Progress.Dtos;
using JLaraSystemLeng.Sugesstions;
using JLaraSystemLeng.Sugesstions.Dtos;
using AutoMapper;

namespace JLaraSystemLeng;

public class JLaraSystemLengApplicationAutoMapperProfile : Profile
{
    public JLaraSystemLengApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
        CreateMap<Exercise.Exercise, ExerciseDto>();
        CreateMap<CreateUpdateExerciseDto, Exercise.Exercise>(MemberList.Source);
        CreateMap<Progres, ProgresDto>();
        CreateMap<CreateUpdateProgresDto, Progres>(MemberList.Source);
        CreateMap<Sugesstion, SugesstionDto>();
        CreateMap<CreateUpdateSugesstionDto, Sugesstion>(MemberList.Source);
    }
}
