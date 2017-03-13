using System.Web.Http;
using Hackathon.Web.Models;

namespace Hackathon.Web.Controllers.Api
{
    [RoutePrefix("api/skills")]
    public class SkillsController : ApiController
    {
        private readonly Skill[] _skills = new[]
        {
            new Skill()
            {
                Title = "Skill 1"
            },
            new Skill()
            {
                Title = "Skill 2"
            },
            new Skill()
            {
                Title = "Skill 3"
            },
            new Skill()
            {
                Title = "Skill 4"
            },
            new Skill()
            {
                Title = "Skill 5"
            },
        };

        [Route("{jobId:int}")]
        [HttpGet]
        public IHttpActionResult Get(int jobId)
        {
            return Ok(_skills);
        }
    }
}