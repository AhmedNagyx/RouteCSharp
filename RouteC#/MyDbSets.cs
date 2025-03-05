using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouteC_
{
    public class MyDbSets : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Stud_Course> Stud_Courses { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Course_Inst> Course_Instructors { get; set; }
        public DbSet<Instructor> Instructors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-6IC2DFK;Database=EF3;trusted_connection=true;trustServerCertificate=true;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Stud_Course>()
                .HasOne(sc => sc.Student)
                .WithMany(s => s.Stud_Courses)
                .HasForeignKey(sc => sc.Stud_ID);

            modelBuilder.Entity<Stud_Course>()
                .HasOne(sc => sc.Course)
                .WithMany(c => c.Stud_Courses)
                .HasForeignKey(sc => sc.Course_ID);

            modelBuilder.Entity<Course_Inst>()
                .HasOne(ci => ci.Instructor)
                .WithMany(i => i.Course_Instructors)
                .HasForeignKey(ci => ci.Inst_ID);

            modelBuilder.Entity<Course_Inst>()
                .HasOne(ci => ci.Course)
                .WithMany(c => c.Course_Instructors)
                .HasForeignKey(ci => ci.Course_ID);

            modelBuilder.Entity<Student>()
                .HasOne(s => s.Department)
                .WithMany(d => d.Students)
                .HasForeignKey(s => s.Dep_Id);

            modelBuilder.Entity<Department>()
                .HasOne(d => d.Instructor)
                .WithOne()
                .HasForeignKey<Department>(d => d.Ins_ID)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Instructor>()
                .HasOne(i => i.Department)
                .WithMany()
                .HasForeignKey(i => i.Dept_ID);

            modelBuilder.Entity<Course>()
                .HasOne(c => c.Topic)
                .WithMany()
                .HasForeignKey(c => c.Top_ID);
        }
    }
}
