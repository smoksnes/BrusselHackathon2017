using System.Configuration;
using Microsoft.EntityFrameworkCore;

namespace Hackathon.Web.Models.Data
{
    public partial class SqlContext : DbContext
    {
        public DbSet<JobVacancySkill> JobVacancySkills { get; set; }
        public DbSet<Occupation> Occupations { get; set; }
        public DbSet<JobVacancy> JobVacancies { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<GenericSkill> GenericSkills { get; set; }
        public DbSet<SkillTracking> SkillTrackings { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["azureSql"];
            optionsBuilder.UseSqlServer(connectionString.ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Occupation>()
                .ToTable("swe.occupations")
                .HasKey(x => x.Id);

            modelBuilder.Entity<JobVacancySkill>()
                .ToTable("swe.job_vancancies_skills")
                .HasKey(x => new { x.JobVancancyId, x.SkillId });


            modelBuilder.Entity<JobVacancy>()
                .ToTable("swe.job_vacancies")
                .HasMany(x => x.JobVacancySkills).WithOne(x => x.JobVacancy).HasForeignKey(x => x.JobVancancyId);


            modelBuilder.Entity<SkillTracking>()
                .ToTable("swe.skill_tracking")
                .HasKey(x => x.Id);

            modelBuilder.Entity<Skill>()
                .ToTable("swe.skills")
                                .HasMany(x => x.JobVacancySkills).WithOne(x => x.Skill).HasForeignKey(x => x.SkillId);


            modelBuilder.Entity<GenericSkill>()
                .ToTable("swe.generic_skills")
                .HasKey(x => x.Id);
        }
    }
}