using System.Linq;
using System.Web.Http;
using Hackathon.Web.Models;

namespace Hackathon.Web.Controllers.Api
{
    [RoutePrefix("api/occupation")]
    public class OccupationController : ApiController
    {
        private Job[] _jobs = new[]
        {
            new Job()
            {
                Title = "Job 1"
            },
            new Job()
            {
                Title = "Job 2"
            },
            new Job()
            {
                Title = "Job 3"
            },
            new Job()
            {
                Title = "Job 4"
            },
            new Job()
            {
                Title = "Job 5"
            },
        };

        [Route("")]
        [HttpGet]
        public IHttpActionResult Get()
        {

            return Ok(_jobs);
        }

        [Route("{title}")]
        [HttpGet]
        public IHttpActionResult Get(string title)
        {
            return Ok(_jobs.Where(x => x.Title.ToLower().Contains(title.ToLower())));
        }
    }
}