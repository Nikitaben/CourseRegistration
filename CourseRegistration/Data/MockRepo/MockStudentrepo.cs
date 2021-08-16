using CourseRegistration.Data.Interfaces;
using CourseRegistration.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseRegistration.Data.MockRepo
{
    public class MockStudentrepo : IStudentRepo
    {
        private readonly static List<Student> _students = new List<Student>
        {
            new Student {StudentId = 001, FirstName = "Danial", LastName = "Para", EmailAddress = "danialpara@gmail.com", PhoneNumber = 5879207077, CourseId = 1001 },
            new Student {StudentId = 002, FirstName = "Parker", LastName = "James", EmailAddress = "parkerjames@gmail.com", PhoneNumber = 7809304545, CourseId = 1002},
            new Student {StudentId = 003, FirstName = "Robinhood", LastName = "Smith", EmailAddress = "robinhoodsmith@gmail.com",PhoneNumber = 6785674564, CourseId = 1003},

        };
        public IEnumerable<Student> GetAllStudents()
        {
            return _students;
        }
    }
}
