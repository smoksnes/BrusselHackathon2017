using System.ComponentModel.DataAnnotations;

namespace Hackathon.Web.Models.Data
{
    public class JobVacancySkill
    {
        [Key]
        public int JobVancancyId { get; set; }
        [Key]
        public int SkillId { get; set; }
        public virtual JobVacancy JobVacancy { get; set; }
        public virtual Skill Skill { get; set; }
    }
}