using LexiconUniversity.Core.Entities;
using LexiconUniversity.Persistance.Configurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace LexiconUniversity.Persistance.Data
{
    public class LexiconUniversityContext : DbContext
    {
        public LexiconUniversityContext(DbContextOptions options) : base(options)
        {
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }

        public DbSet<Student> Students { get; set; } = default!;

        public DbSet<Address> Addresses { get; set; } = default!;

        public DbSet<Course> Courses { get; set; } = default!; 

        public DbSet<Enrollment> Enrollments { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new StudentConfigurations());

            //foreach (var entity in modelBuilder.Model.GetEntityTypes())
            //{
            //    entity.AddProperty("Edited", typeof(DateTime)); 
            //}
        }
    }
}
