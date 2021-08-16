
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CourseRegistration.Data.Interfaces;

namespace CourseRegistration.Controllers
{
    public class CourseController : Controller
    {
        private  ICourseRepo _courseRepo;

        public CourseController(ICourseRepo courseRepo)
        {
            _courseRepo = courseRepo;
        }
        public IActionResult Index()
        {
            return View(_courseRepo.GetAllCourses());
        }
    }
}
