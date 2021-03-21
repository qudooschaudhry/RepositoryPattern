using LMS.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Infrastructure.DataContext
{
    public class LMSContext : DbContext
    {
        public DbSet<Course> Courses { get; set; }
        public DbSet<Chapter> Chapter { get; set; }
        public DbSet<Page> Pages { get; set; }
        public DbSet<Section> Sections { get; set; }
        public DbSet<Content> Contents { get; set; }
        public DbSet<Student> Students { get; set; }

        public LMSContext() { }
        public LMSContext(DbContextOptions<LMSContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
