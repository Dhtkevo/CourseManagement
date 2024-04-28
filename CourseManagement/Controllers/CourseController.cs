using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace CourseManagement.Controllers
{
    public class CourseController : Controller
    {
       public IActionResult Index()
        {
            return View();
        }
    }
}
