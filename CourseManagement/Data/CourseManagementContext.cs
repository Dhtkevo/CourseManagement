using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CourseManagement.Models;

namespace CourseManagement.Data
{
    public class CourseManagementContext : DbContext
    {
        public CourseManagementContext (DbContextOptions<CourseManagementContext> options)
            : base(options)
        {
        }

        public CourseManagementContext()
        {

        }

        public virtual DbSet<CourseManagement.Models.Course> Course { get; set; } = default!;
    }
}
