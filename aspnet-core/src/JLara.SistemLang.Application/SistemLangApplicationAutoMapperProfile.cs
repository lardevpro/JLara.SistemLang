using JLaraSystemLeng.Exercise;
using JLaraSystemLeng.Exercise.Dtos;
using AutoMapper;

namespace JLara.SistemLang;

public class SistemLangApplicationAutoMapperProfile : Profile
{
    public SistemLangApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
        CreateMap<Exercise, ExerciseDto>();
        CreateMap<CreateUpdateExerciseDto, Exercise>(MemberList.Source);
    }
}
