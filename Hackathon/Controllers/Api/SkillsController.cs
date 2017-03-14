using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using Hackathon.Web.Models;
using Hackathon.Web.Models.Data;

namespace Hackathon.Web.Controllers.Api
{
    [RoutePrefix("api/skills")]
    public class SkillsController : ApiController
    {
        private readonly SqlContext _dbContext;

        private readonly Skill[] _skills = new[]
        {
            new Skill()
            {
                Id   = 1,
                Title = "Skill 1",
                Description = "Description 1. Enter some more texte here..."
            },
            new Skill()
            {
                Id   = 2,
                Title = "Skill 2",
                Description = "Description 1. Enter some more texte here..."
            },
            new Skill()
            {
                Id   = 3,
                Title = "Skill 3",
                Description = "Description 1. Enter some more texte here..."
            },
            new Skill()
            {
                Id   = 4,
                Title = "Skill 4",
                Description = "Description 1. Enter some more texte here..."
            },
            new Skill()
            {
                Id   = 5,
                Title = "Skill 5",
                Description = "Description 1. Enter some more texte here..."
            },
        };

        public SkillsController(SqlContext dbContext)
        {
            _dbContext = dbContext;
        }

        [Route("{jobId:int}")]
        [HttpGet]
        public IHttpActionResult Get(int jobId)
        {
            return Ok(_skills);
        }

        [Route("")]
        [HttpPost]
        public async Task<IHttpActionResult> Post(SkillTracking skillTracking)
        {
            var location = GetLocation();
            skillTracking.Latitude = location.Latitude;
            skillTracking.Longitude = location.Longitude;
            skillTracking.Date = DateTime.Now;
            await _dbContext.SkillTrackings.AddAsync(skillTracking);
            await _dbContext.SaveChangesAsync();
            return Ok();
        }

        private Location GetLocation()
        {
            var locations = new[]
            {
                new Location(50.841445f, 4.377274f),
                new Location(59.329832f, 18.070366f), 
                new Location(59.914074f, 10.750735f), 
                new Location(52.251355f, 21.030974f),
            };

            var index = new Random((int) DateTime.Now.Ticks).Next(locations.Length);
            return locations[index];
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
            _dbContext.Dispose();
        }

        private class Location
        {
            public Location(float latitude, float longitude)
            {
                Latitude = latitude;
                Longitude = longitude;
            }
            public float Latitude { get; set; }
            public float Longitude { get; set; }
        }
    }
}