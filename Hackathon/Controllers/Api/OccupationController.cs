using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using Hackathon.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace Hackathon.Web.Controllers.Api
{
    [RoutePrefix("api/occupation")]
    public class OccupationController : ApiController
    {
        private readonly SqlContext _dbContext;

        public OccupationController(SqlContext dbContext)
        {
            _dbContext = dbContext;
        }

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
        public async Task<IHttpActionResult> Get()
        {
            var jobs =
                await _dbContext.SkillProfessions
                   .GroupBy(x => new Job { Id = x.GeneralId, Title = x.Esco_Level_4 })
                    .Select(g => g.First())
                    .Take(10)
                    .ToListAsync();
            return Ok(jobs);
        }

        [Route("{title}")]
        [HttpGet]
        public async Task<IHttpActionResult> Get(string title)
        {
            var query =
                 _dbContext.SkillProfessions
                    .Where(x => x.Esco_Level_4.Contains(title))
                    .Select(g => g.Esco_Level_4)
                    .Distinct()
                    .Take(10);

            var jobs = await query.ToListAsync();
            return Ok(jobs.Select(x => new Job() { Title = x }));
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
            _dbContext.Dispose();
        }
    }
}