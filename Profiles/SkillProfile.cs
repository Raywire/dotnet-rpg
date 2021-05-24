using AutoMapper;
using dotnet_rpg.Dtos.Skill;
using dotnet_rpg.Models;

namespace dotnet_rpg.Profiles
{
    public class SkillProfile : Profile
    {
        public SkillProfile()
        {
            CreateMap<Skill, GetSkillDto>();
        }
    }
}