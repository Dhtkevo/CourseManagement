using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace CourseManagement.Models;

public class CourseSubjectViewModel
{
    public List<Course>? Courses { get; set; }
    public SelectList? Subjects { get; set; }
    public string? CourseSubject { get; set; }
    public string? SearchString { get; set; }
}