﻿using System.Configuration;
using Microsoft.EntityFrameworkCore;

namespace Hackathon.Web.Models.Data
{
    public partial class SqlContext : DbContext
    {
        public DbSet<Occupation> Occupations { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<GenericSkill> GenericSkills { get; set; }
        public DbSet<SkillTracking> SkillTrackings { get; set; }
        // Unable to generate entity type for table 'dbo.ft_skill_profession_cz'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.out1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ft_skill_profession_de'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ft_skill_profession_en'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ft_document_cz'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ft_skill_profession_experience_cz'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ft_skill_profession_experience_de'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ft_document_cz_test'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ft_skill_profession_experience_en'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ft_skill_profession_experience_it'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ft_skill_profession_it'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ft_document_de'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ft_skill_profession_new_cz'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ft_skill_profession_new_de'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ft_skill_profession_new_en'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ft_document_en'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ft_skill_profession_new_it'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ft_skill_profession_requirement_cz'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ft_skill_profession_requirement_de'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ft_document_it'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ft_skill_profession_requirement_en'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ft_skill_profession_requirement_it'. Please see the warning messages.

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

            modelBuilder.Entity<SkillTracking>()
                .ToTable("swe.skill_tracking")
                .HasKey(x => x.Id);

            modelBuilder.Entity<Skill>()
                .ToTable("swe.skills")
                .HasKey(x => x.Id);

            modelBuilder.Entity<GenericSkill>()
                .ToTable("swe.generic_skills")
                .HasKey(x => x.Id);
        }
    }
}