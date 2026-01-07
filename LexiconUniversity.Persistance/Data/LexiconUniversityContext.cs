using LexiconUniversity.Core.Entities;
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
        }

        public DbSet<Student> Students { get; set; } = default!;

        public DbSet<Address> Addresses { get; set; } = default!; 
    }
}
