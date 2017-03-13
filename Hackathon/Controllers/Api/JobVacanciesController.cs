using System.Linq;
using System.Web.Http;
using Hackathon.Web.Models;

namespace Hackathon.Web.Controllers.Api
{
    [RoutePrefix("api/jobVacancies")]
    public class JobVacanciesController : ApiController
    {
        private readonly JobVacancy[] _jobs = new[]
        {
            new JobVacancy()
            {
                Title = "Job 1",
                MatchPercentage = 45
            },
            new JobVacancy()
            {
                Title = "Job 2",
                MatchPercentage = 13

            },
            new JobVacancy()
            {
                Title = "Job 3",
                MatchPercentage = 98
            },
            new JobVacancy()
            {
                Title = "Job 4",
                MatchPercentage = 14
            },
            new JobVacancy()
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