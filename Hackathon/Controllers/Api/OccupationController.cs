using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using Hackathon.Web.Models.Data;
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

        [Route("")]
        [HttpGet]
        public async Task<IHttpActionResult> Get()
        {
            var jobs =
                await _dbContext.Occupations
                    .Take(10)
                    .ToListAsync();
            return Ok(jobs);
        }

        [Route("{title}")]
        [HttpGet]
        public async Task<IHttpActionResult> Get(string title)
        {
            var query =
                 _dbContext.Occupations
                    .Where(x => x.Title.Contains(title))
                    .Take(10);

            var jobs = await query.ToListAsync();
            return Ok(jobs);
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
            _dbContext.Dispose();
        }
    }
}