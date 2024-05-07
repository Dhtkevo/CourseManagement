using CourseManagement.Controllers;
using CourseManagement.Data;
using CourseManagement.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Moq;
using Moq.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagementTests.ControllerTests
{
    public class CourseControllerTest
    {
        [Fact]
        public async Task Index_Test()
        {
            // Arange
            CourseManagement.Models.Course course1 = new CourseManagement.Models.Course()
            {
                Id = 1,
                Name = "Calculus",
                Description = "Hard",
                Subject = "Math"
            };
            CourseManagement.Models.Course course2 = new CourseManagement.Models.Course()
            {
                Id = 2,
                Name = "Biology",
                Description = "Fun",
                Subject = "Science"
            };
            var courses = new List<Course>();
            courses.Add(course1);
            courses.Add(course2);

            var dbMock = new Mock<CourseManagementContext>();

            if (course1 != null) dbMock.Setup<DbSet<Course>>(x => x.Course).ReturnsDbSet(courses);

            var courseController = new CoursesController(dbMock.Object);
            var courseID = 1;
            var searchString = "Biology";
            var searchSubject = "Science";

            // Act
            var result = (await courseController.Index(searchString, searchSubject));

            // Assert
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public async Task Details_Test()
        {
            // Arange
            CourseManagement.Models.Course course1 = new CourseManagement.Models.Course()
            {
                Id = 1,
                Name = "Calculus",
                Description = "Hard",
                Subject = "Math"
            };
            CourseManagement.Models.Course course2 = new CourseManagement.Models.Course()
            {
                Id = 2,
                Name = "Biology",
                Description = "Fun",
                Subject = "Science"
            };
            var courses = new List<Course>();
            courses.Add(course1);
            courses.Add(course2);

            var dbMock = new Mock<CourseManagementContext>();

            if (course1 != null) dbMock.Setup<DbSet<Course>>(x => x.Course).ReturnsDbSet(courses);

            var courseController = new CoursesController(dbMock.Object);
            var courseID = 1;

            // Act
            var result = (await courseController.Details(courseID));

            // Assert
            Assert.IsType<ViewResult>(result);
        }
    }
}
