using Microsoft.AspNetCore.Mvc;
using WorkingBees.Core.Interfaces;
using WorkingBees.Core.Models;

namespace workingBeesAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Consumes("application/json")]
    [Produces("application/json")]
    public class SkillsController : ControllerBase
    {
        private readonly IService<Skill> _skillService;

        public SkillsController(IService<Skill> skillService)
        {
            _skillService = skillService;
        }

        [HttpGet("/Skills")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<List<Skill>> ListAllSkills()
        {
            return Ok(_skillService.ListAll());
        }

        [HttpGet("/Skills/{userId}/id")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<List<Skill>> ListSkillsByUserId(long userId)
        {
            var skillsList = _skillService.Listallbyuserid(userId);
            if (skillsList == null) return NotFound();
            return Ok(skillsList);
        }

        [HttpPost("/Skill")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status409Conflict)]
        //[ServiceFilter(typeof(CheckIfSkillExistsActionFilter))]
        public ActionResult<bool> InsertSkill(Skill skill)
        {
            //CityEvent cityEventMapped = _mapper.Map<CityEvent>(cityEvent);
            var result = _skillService.Insert(skill);
            return CreatedAtAction(nameof(InsertSkill), result);
        }

        [HttpPut("/Skill/{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        //[ServiceFilter(typeof(CheckIfEventIdRegisteredActionFilter))]
        public IActionResult UpdateSkill(long id, Skill skill)
        {
            //CityEvent cityEventMapped = _mapper.Map<CityEvent>(cityEvent);
            _skillService.Update(id, skill);
            return NoContent();
        }

        [HttpDelete("/Skill/{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult DeleteSkill(long id)
        {
            if (!_skillService.Delete(id))
            {
                return NotFound();
            }
            return NoContent();
        }
    }
}