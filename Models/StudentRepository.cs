// File: Models/StudentRepository.cs

using SpringFramework.Models;
using System.Collections.Generic;
using System.Linq;

namespace SpringFramework
{
    public class StudentRepository
    {
        private readonly SchoolDbContext _context;

        public StudentRepository(SchoolDbContext context)
        {
            _context = context;
        }

        public List<Student> GetAllStudents()
        {
            return _context.Students.ToList();
        }
    }
}
