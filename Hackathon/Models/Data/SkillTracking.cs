using System;

namespace Hackathon.Web.Models.Data
{
    public class SkillTracking
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public float Latitude { get; set; }
        public float Longitude { get; set; }
        public bool GotSkill { get; set; }
    }
}