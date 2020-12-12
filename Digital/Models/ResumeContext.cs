using System;
using Microsoft.EntityFrameworkCore;

namespace Digital.Models
{
    public class ResumeContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }
        public DbSet<Resume> Resumes { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<WorkExperience> WorkExperiences { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Response> Responses { get; set; }
        //public DbSet<User> Users { get; set; }

        public ResumeContext(DbContextOptions<ResumeContext> options) : base(options)
        {
        }

        public ResumeContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Education>()
    .HasKey(p => p.IDEdu);

            modelBuilder.Entity<Language>()
   .HasKey(p => p.IDLanguage);

   //         modelBuilder.Entity<User>()
   //.HasKey(p => p.Id);

           modelBuilder.Entity<Skill>()
   .HasKey(p => p.IDSkill);

            modelBuilder.Entity<WorkExperience>()
  .HasKey(p => p.ExperienceID);

            modelBuilder.Entity<Response>()
    .HasKey(bc => new { bc.ResumeID, bc.CompanyID });
            modelBuilder.Entity<Response>()
                .HasOne(bc => bc.Resume)
                .WithMany(b => b.Responces)
                .HasForeignKey(bc => bc.ResumeID);
            modelBuilder.Entity<Response>()
                .HasOne(bc => bc.Company)
                .WithMany(c => c.Responces)
                .HasForeignKey(bc => bc.CompanyID);

            modelBuilder.Entity<Person>()
        .HasMany(c => c.Resumes)
        .WithOne(e => e.Person);

            modelBuilder.Entity<Resume>()
        .HasMany(c => c.Skills)
        .WithOne(e => e.Resume);

            modelBuilder.Entity<Resume>()
        .HasMany(c => c.Educations)
        .WithOne(e => e.Resume);

            modelBuilder.Entity<Resume>()
        .HasMany(c => c.Languages)
        .WithOne(e => e.Resume);

            modelBuilder.Entity<Resume>()
        .HasMany(c => c.WorkExperiences)
        .WithOne(e => e.Resume);


        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Database=QwertyDb;Username=postgres;Password=shikamaru");
        }
    }


    

}
