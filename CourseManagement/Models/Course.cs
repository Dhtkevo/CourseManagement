using System.ComponentModel.DataAnnotations;

namespace CourseManagement.Models
{
    public class Course
    {
        public int Id { get; set; }
        [Display(Name = "Course Name")]
        [StringLength(30, MinimumLength = 10)]
        [Required]
        public string? Name { get; set; }

        [StringLength(20, MinimumLength = 4)]
        [Required]
        public string? Subject { get; set; }
       
        public string? Description { get; set; }
    }
}
