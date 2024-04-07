using Microsoft.AspNetCore.Mvc;
using SpringFramework;

public class StudentController : Controller
{
    private readonly StudentRepository _studentRepository;

    public StudentController(StudentRepository studentRepository)
    {
        _studentRepository = studentRepository;
    }

    public IActionResult Index()
    {
        var students = _studentRepository.GetAllStudents();
        return View(students);
    }
}
