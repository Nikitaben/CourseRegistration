using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CourseRegistration.Data.Interfaces;

namespace CourseRegistration.Controllers
{
    public class StudentController : Controller
    {
        private IStudentRepo _studentRepo;

        public StudentController(IStudentRepo studentRepo)
        {
            _studentRepo = studentRepo;
        }
        public IActionResult Index()
        {
            return View(_studentRepo.GetAllStudents());
        }
    }
}
