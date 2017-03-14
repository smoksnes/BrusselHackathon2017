using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using Hackathon.Web.Models;
using Hackathon.Web.Models.Data;
using Microsoft.EntityFrameworkCore;

namespace Hackathon.Web.Controllers.Api
{
    [RoutePrefix("api/jobmatches")]
    public class JobMatchesController : ApiController
    {
        private readonly SqlContext _dbContext;

        public JobMatchesController(SqlContext dbContext)
        {
            _dbContext = dbContext;
        }
        [Route("")]
        [HttpPost]
        public async Task<IHttpActionResult> Post(JobMatchForm form)
        {
            //var jobMatches = from jv in _dbContext.JobVacancies
            //                 join jvs in _dbContext.JobVacancySkills on jv.Id equals jvs.JobVancancyId
            //                 where jv.Isco == form.Isco
            //                 //group jvs by jvs.JobVancancyId into grouped
            //                 //select new { Id = grouped.Key, Skills = j.ToList(), Count = j. };
            //                 select new {jv.Title, jv.Description, jv.Isco, jvs.SkillId, jv.Id };

            //var result = await jobMatches.ToListAsync();
            //result.GroupBy(x => new {x.Id, x.Title, x.Description}).Select(x => new JobMatch(){Id = x.Key.Id, Title = x.Key.Title, Description = x.Key.Description, Skills = x.})

            var result = await _dbContext.JobVacancies.Include(x => x.JobVacancySkills).Where(x => x.Isco == form.Isco).ToListAsync();
            var matches = new List<JobMatch>();
            foreach (var job in result)
            {
                double percentage = (double)job.JobVacancySkills.Count(x => form.Skills.Contains(x.SkillId)) /
                                 (double)job.JobVacancySkills.Count;
                var match = new JobMatch()
                {
                    Title = job.Title,
                    Description = job.Description,
                    Id = job.Id,
                    MatchPercentage = (int)Math.Round(percentage * 100)
                };
                matches.Add(match);
            }

            return Ok(matches.OrderByDescending(x => x.MatchPercentage));
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
            _dbContext.Dispose();
        }
    }
}