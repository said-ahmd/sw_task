using Microsoft.AspNetCore.Mvc;
using SE2.Models;

namespace SE2.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            List<Student> students = new List<Student>
            {
                new Student{Id=1 ,Name="sadi",Department="cs" },
                new Student{Id=2 ,Name="Ahmd" ,Department="it"},
                new Student{Id=3 ,Name="khaled" ,Department="is"},
                new Student{Id=4 ,Name="mhmd" ,Department="cs"},
                new Student{Id=5 ,Name = "Amgad" ,Department="is"}
            };
            return View(students);
        }
    }
}
