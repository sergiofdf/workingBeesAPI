using WorkingBees.Core.Interfaces;
using WorkingBees.Core.Models;

namespace WorkingBees.Core.Services
{
    public class SkillService : IService<Skill>
    {
        public readonly IRepository<Skill> _skillRepository;
        public SkillService(IRepository<Skill> skillRepository)
        {
            _skillRepository = skillRepository;
        }
        public List<Skill> ListAll()
        {
            return _skillRepository.ListAll();
        }
    }
}
