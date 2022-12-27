using Microsoft.AspNetCore.Mvc;
using WorkingBees.Core.Interfaces;
using WorkingBees.Core.Models;

namespace workingBeesAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Consumes("application/json")]
    [Produces("application/json")]
    public class WorkingBeesController : ControllerBase
    {
        private readonly IService<Skill> _skillService;

        public WorkingBeesController(IService<Skill> skillService)
        {
            _skillService = skillService;
        }

        [HttpGet("/Skills")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<List<Skill>> ListAllSkills()
        {
            return Ok(_skillService.ListAll());
        }
    }
}