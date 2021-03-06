﻿using System.Collections.Generic;

namespace Hackathon.Web.Models.Data
{
    public class JobVacancy
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Isco { get; set; }
        public virtual ICollection<JobVacancySkill> JobVacancySkills { get; set; }
    }
}