using System.ComponentModel.DataAnnotations;

namespace CourseManagement.Models
{
    public class Course
    {
        public int Id { get; set; }
        [Display(Name = "Course Name")]
        public string? Name { get; set; }

        public string? Subject { get; set; }
       
        public string? Description { get; set; }
    }
}
