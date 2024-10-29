using Backend.Models;
using Microsoft.EntityFrameworkCore;

namespace Backend.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }
      /*  public DbSet<Course> Courses { get; set; }*/
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           /* modelBuilder.Entity<Course>().HasData(
                new Course
                {
                    Id = 1,
                    Title = "IELTS Preparation",
                    Description = "A comprehensive course designed to prepare students for the IELTS exam.",
                    UrlImg = "",
                    TeacherId = 106,
                    DateCreate = DateTime.Now,
                    DateStart = new DateTime(2024, 11, 1),
                    DateUpdate = DateTime.Now,
                    Price = 99.99,
                    Status = true
                },
                new Course
                {
                    Id = 2,
                    Title = "TOEIC Mastery",
                    Description = "Achieve your desired TOEIC score with in-depth lessons and practice tests.",
                    UrlImg = "",
                    TeacherId = 107,
                    DateCreate = DateTime.Now,
                    DateStart = new DateTime(2024, 11, 5),
                    DateUpdate = DateTime.Now,
                    Price = 89.99,
                    Status = true
                },
                new Course
                {
                    Id = 3,
                    Title = "TOEFL Success",
                    Description = "Prepare for the TOEFL exam with strategies and practice exams.",
                    UrlImg = "",
                    TeacherId = 108,
                    DateCreate = DateTime.Now,
                    DateStart = new DateTime(2024, 11, 10),
                    DateUpdate = DateTime.Now,
                    Price = 95.99,
                    Status = true
                }
            );
*/
        }

    }
}
