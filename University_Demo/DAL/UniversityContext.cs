using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using University_Demo.Models;
using System.Web;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace University_Demo.DAL
{
    public class UniversityContext : DbContext
    {
        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}