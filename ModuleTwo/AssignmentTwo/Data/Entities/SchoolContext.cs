using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssignmentTwo {

	public class SchoolContext : DbContext {

		public virtual DbSet<Student> Students {
			get; set;
		}
		public virtual DbSet<Instructor> Instructors {
			get; set;
		}
		public virtual DbSet<Course> Courses {
			get; set;
		}
		public virtual DbSet<StudentCourse> StudentCourses {
			get; set;
		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
			if (!optionsBuilder.IsConfigured) {
				optionsBuilder.UseLazyLoadingProxies()
					.UseSqlServer("Data Source=localhost;Database=NorthWind;Trusted_Connection=True;");
			}
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder) {

			// Seed Instructors
			modelBuilder.Entity<Instructor>().HasData(
				new Instructor {
					Id = 1,
					FirstName = "Albert",
					LastName = "Einstein",
					Email = "emc2@pub.edu",
					CourseId = 1
				});
			modelBuilder.Entity<Instructor>().HasData(
				new Instructor {
					Id = 2,
					FirstName = "Marie",
					LastName = "Curie",
					Email = "rad@nobel.fr",
					CourseId = 2
				});
			modelBuilder.Entity<Instructor>().HasData(
				new Instructor {
					Id = 3,
					FirstName = "Galileo",
					LastName = "Galilei",
					Email = "stars@science.it",
					CourseId = 3
				});

			// Seed Courses
			modelBuilder.Entity<Course>().HasData(
				new Course {
					Id = 1,
					Name = "Physics 101",
					Number = "P101",
					Description = "Learn all about the theory of relativity!"
				});
			modelBuilder.Entity<Course>().HasData(
				new Course {
					Id = 2,
					Name = "Radiology In War",
					Number = "R204",
					Description = "An examination of lifespan in the context of radiation exposure."
				});
			modelBuilder.Entity<Course>().HasData(
				new Course {
					Id = 3,
					Name = "Advanced Astronomy",
					Number = "A4000",
					Description = "Discover which moves more: the earth or the sun?"
				});

			// Seed Students
			modelBuilder.Entity<Student>().HasData(
				new Student {
					Id = 1,
					FirstName = "Chicken",
					LastName = "Little",
					Email = "theskyisfalling@panic.now",
					Phone = "204-111-1111"
				});
			modelBuilder.Entity<Student>().HasData(
				new Student {
					Id = 2,
					FirstName = "Bo",
					LastName = "Peep",
					Email = "comebacksheep@my.flock",
					Phone = "204-222-2222"
				});
			modelBuilder.Entity<Student>().HasData(
				new Student {
					Id = 3,
					FirstName = "Itsy",
					LastName = "Bitsy",
					Email = "spidersareyourfriend@nook.cranny",
					Phone = "204-333-3333"
				});
			modelBuilder.Entity<Student>().HasData(
				new Student {
					Id = 4,
					FirstName = "Black",
					LastName = "Sheep",
					Email = "baa@baa.com",
					Phone = "204-444-4444"
				});
			modelBuilder.Entity<Student>().HasData(
				new Student {
					Id = 5,
					FirstName = "Humpty",
					LastName = "Dumpty",
					Email = "helpmeup@kingdom.come",
					Phone = "204-555-5555"
				});
			modelBuilder.Entity<Student>().HasData(
				new Student {
					Id = 6,
					FirstName = "Jack",
					LastName = "Nimble",
					Email = "ouchthatshot@candle.stick",
					Phone = "204-666-6666"
				});

			// Seed StudentCourses
			modelBuilder.Entity<StudentCourse>().HasData(
				new StudentCourse { Id = 1, CourseId = 1, StudentId = 1 });
			modelBuilder.Entity<StudentCourse>().HasData(
				new StudentCourse { Id = 2, CourseId = 1, StudentId = 2 });
			modelBuilder.Entity<StudentCourse>().HasData(
				new StudentCourse { Id = 3, CourseId = 1, StudentId = 3 });
			modelBuilder.Entity<StudentCourse>().HasData(
				new StudentCourse { Id = 4, CourseId = 2, StudentId = 4 });
			modelBuilder.Entity<StudentCourse>().HasData(
				new StudentCourse { Id = 5, CourseId = 2, StudentId = 5 });
			modelBuilder.Entity<StudentCourse>().HasData(
				new StudentCourse { Id = 6, CourseId = 3, StudentId = 6 });
			modelBuilder.Entity<StudentCourse>().HasData(
				new StudentCourse { Id = 7, CourseId = 3, StudentId = 1 });
			modelBuilder.Entity<StudentCourse>().HasData(
				new StudentCourse { Id = 8, CourseId = 3, StudentId = 2 });
			modelBuilder.Entity<StudentCourse>().HasData(
				new StudentCourse { Id = 9, CourseId = 3, StudentId = 3 });
			modelBuilder.Entity<StudentCourse>().HasData(
				new StudentCourse { Id = 10, CourseId = 3, StudentId = 4 });
		}
	}
}
