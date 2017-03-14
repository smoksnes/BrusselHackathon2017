using System.Collections.Generic;

namespace Hackathon.Web.Models.Data
{
    public class Skill
    {
        public int Isco { get; set; }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ReUseLevel { get; set; }
        public ICollection<JobVacancySkill> JobVacancySkills { get; set; }
    }

    public class GenericSkill
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}