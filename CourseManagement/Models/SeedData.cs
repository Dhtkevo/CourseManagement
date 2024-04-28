using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using CourseManagement.Data;
using System;
using System.Linq;

namespace CourseManagement.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new CourseManagementContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<CourseManagementContext>>()))
        {
            // Look for any courses.
            if (context.Course.Any())
            {
                return;   // DB has been seeded
            }
            context.Course.AddRange(
                new Course
                {
                    Name = "Software Engineering I",
                    Subject = "Computer Science",
                    Description = "Students will work together on teams to build a medium-scale project using Java",
                },
                new Course
                {
                    Name = "Elementary Statistics",
                    Subject = "Math",
                    Description = "Students will learn about probability",
                },
                new Course
                {
                    Name = "American Government",
                    Subject = "History",
                    Description = "Students will learn about the history of American government",
                },
                new Course
                {
                    Name = "Biology I",
                    Subject = "Science",
                    Description = "Students will learn about the basics of biology",
                }
            );
            context.SaveChanges();
        }
    }
}