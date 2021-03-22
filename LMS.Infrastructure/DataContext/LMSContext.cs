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
            SetupCourses(modelBuilder);
            SetupChapters(modelBuilder);
            SetupPages(modelBuilder);
            SetupSections(modelBuilder);
            SetupStudents(modelBuilder);
            base.OnModelCreating(modelBuilder);
        }

        private static void SetupCourses(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>().Property(p => p.Name).HasMaxLength(256).IsRequired();
        }
        private static void SetupChapters(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Chapter>().Property(p => p.CourseId).IsRequired();
            modelBuilder.Entity<Chapter>().Property(p => p.Title).HasMaxLength(256).IsRequired();
        }
        private static void SetupPages(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Page>().Property(p => p.ChapterId).IsRequired();
        }
        private static void SetupSections(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Section>().Property(p => p.PageId).IsRequired();
        }

        private static void SetupStudents(ModelBuilder modelBuilder)
        { 

        }
    }
}
