using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CourseRegistration.Data.Interfaces;

namespace CourseRegistration.Controllers
{
    public class InstructorController : Controller
    {
        private IInstructorRepo _instructorRepo;

        public InstructorController(IInstructorRepo instructorRepo)
        {
            _instructorRepo = instructorRepo;
        }
        public IActionResult Index()
        {
            return View(_instructorRepo.GetAllInstructors());
        }
    }
}
