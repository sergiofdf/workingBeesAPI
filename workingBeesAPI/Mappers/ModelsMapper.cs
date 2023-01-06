using AutoMapper;
using WorkingBees.Core.Models;

namespace workingBeesAPI.Mappers
{
    public class ModelsMapper : Profile
    {
        public ModelsMapper()
        {
            CreateMap<SkillDto, Skill>();
        }
    }
}
