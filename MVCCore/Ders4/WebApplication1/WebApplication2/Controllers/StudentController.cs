using Microsoft.AspNetCore.Mvc;
using WebApplication2.Entities;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class StudentController : Controller
    {
        private DatabaseContext _databaseContext;

        public StudentController(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public IActionResult Index()
        {
            List<Student> students = _databaseContext.Students.ToList();

            return View(students);
        }

        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Create(StudentCreateViewModel model)
        {
            if (ModelState.IsValid)
            {
                Student student = new Student()
                {
                    NameSurname = model.NameSurname,
                    Username = model.Username,
                    Password = model.Password
                };

                _databaseContext.Students.Add(student);
                _databaseContext.SaveChanges();

                return RedirectToAction(nameof(Index));
            }

            return View(model);
        }
    }
}
