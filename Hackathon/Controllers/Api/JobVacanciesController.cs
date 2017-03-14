using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using Hackathon.Web.Models;
using Hackathon.Web.Models.Data;

namespace Hackathon.Web.Controllers.Api
{
    [RoutePrefix("api/jobvacancies")]
    public class JobVacanciesController : ApiController
    {
        private readonly SqlContext _dbContext;

        public JobVacanciesController(SqlContext dbContext)
        {
            _dbContext = dbContext;
        }

        [Route("")]
        [HttpPost]
        public async Task<IHttpActionResult> Post(JobVacancy job)
        {
            await _dbContext.AddAsync(job);
            await _dbContext.SaveChangesAsync();
            return Ok(job);
        }

        [Route("{jobId:int}/{skillId:int}")]
        [HttpPost]
        public async Task<IHttpActionResult> Post(int jobId, int skillId)
        {
            var jobVacancySkill = new JobVacancySkill
            {
                JobVancancyId = jobId,
                SkillId = skillId
            };
            await _dbContext.AddAsync(jobVacancySkill);
            await _dbContext.SaveChangesAsync();
            return Ok();
        }
    }
}