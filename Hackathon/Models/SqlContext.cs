﻿using Microsoft.EntityFrameworkCore;

namespace Hackathon.Web.Models
{
    public partial class SqlContext : DbContext
    {

        public DbSet<SkillProfession> SkillProfessions { get; set; }
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
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-2UTMK54;Initial Catalog=cedefop_presentation;Persist Security Info=False;Integrated Security=True;MultipleActiveResultSets=False;Connection Timeout=30;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SkillProfession>()
                .ToTable("ft_skill_profession_en")
                .HasKey(x => x.GeneralId);
        }
    }
}