using System.Linq;
using System.Web.Http;
using Hackathon.Web.Models;

namespace Hackathon.Web.Controllers.Api
{
    [RoutePrefix("api/jobmatches")]
    public class JobMatchesController : ApiController
    {
        private readonly JobMatch[] _jobs = new[]
        {
            new JobMatch()
            {
                Title = "Job 1",
                MatchPercentage = 45
            },
            new JobMatch()
            {
                Title = "Job 2",
                MatchPercentage = 13

            },
            new JobMatch()
            {
                Title = "Job 3",
                MatchPercentage = 98
            },
            new JobMatch()
            {
                Title = "Job 4",
                MatchPercentage = 14
            },
            new JobMatch()
            {
                Title = "Job 5",
                MatchPercentage = 87
            },
        };

        [Route("")]
        [HttpPost]
        public IHttpActionResult Post(JobForm form)
        {
            return Ok(_jobs.OrderByDescending(x => x.MatchPercentage));
        }
    }
}