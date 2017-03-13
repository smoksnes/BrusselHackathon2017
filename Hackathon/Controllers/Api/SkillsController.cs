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
                Title = "Skill 1",
                Description = "Description 1. Enter some more texte here..."
            },
            new Skill()
            {
                Title = "Skill 2",
                Description = "Description 1. Enter some more texte here..."
            },
            new Skill()
            {
                Title = "Skill 3",
                Description = "Description 1. Enter some more texte here..."
            },
            new Skill()
            {
                Title = "Skill 4",
                Description = "Description 1. Enter some more texte here..."
            },
            new Skill()
            {
                Title = "Skill 5",
                Description = "Description 1. Enter some more texte here..."
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