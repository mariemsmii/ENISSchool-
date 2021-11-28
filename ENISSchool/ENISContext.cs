using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENISSchool
{
    class ENISContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer  (@"Server=DESKTOP-GIIG0S5\MSSQLSERVER01;Database=SchoolDB12;Trusted_Connection=True;");
        }protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Grade>()
                .HasMany<Student>(g => g.Students)
                .WithOne(s => s.Grade)
                .OnDelete(DeleteBehavior.SetNull);
        }

    }
}
