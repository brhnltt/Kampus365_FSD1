using Microsoft.AspNetCore.Mvc;
using NETCore.Encrypt.Extensions;
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
            List<StudentViewModel> students =
                _databaseContext.Students.Select(x => new StudentViewModel
                {
                    Id = x.Id,
                    NameSurname = x.NameSurname,
                    Username = x.Username
                }).ToList();

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
                if (_databaseContext.Students.Any(x => x.Username.ToLower() == model.Username.ToLower()))
                {
                    ModelState.AddModelError(nameof(StudentCreateViewModel.Username), "Bu kullanıcı adı zaten kullanılıyor.");
                }
                else
                {
                    Student student = new Student()
                    {
                        NameSurname = model.NameSurname,
                        Username = model.Username,
                        Password = model.Password.MD5()
                    };

                    _databaseContext.Students.Add(student);
                    _databaseContext.SaveChanges();

                    return RedirectToAction(nameof(Index));
                }
            }

            return View(model);
        }


        public IActionResult Edit(int id)
        {
            Student student = _databaseContext.Students.Find(id);

            if (student == null)
            {
                return RedirectToAction(nameof(Index));
            }

            StudentEditViewModel model = new StudentEditViewModel
            {
                NameSurname = student.NameSurname,
                Username = student.Username
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(int id, StudentEditViewModel model)
        {
            if (ModelState.IsValid)
            {
                Student student = _databaseContext.Students.Find(id);

                if (student == null)
                {
                    return RedirectToAction(nameof(Index));
                }

                if (_databaseContext.Students.Any(x => x.Username.ToLower() == model.Username.ToLower() && x.Id != id))
                {
                    ModelState.AddModelError(nameof(StudentEditViewModel.Username), "Bu kullanıcı adı zaten kullanılıyor.");
                }
                else
                {
                    student.NameSurname = model.NameSurname;
                    student.Username = model.Username;

                    _databaseContext.SaveChanges();

                    return RedirectToAction(nameof(Index));
                }
            }

            return View(model);
        }

        public IActionResult Delete(int id)
        {
            Student student = _databaseContext.Students.Find(id);

            if (student == null)
            {
                return RedirectToAction(nameof(Index));
            }

            StudentViewModel model = new StudentViewModel
            {
                Id = student.Id,
                NameSurname = student.NameSurname,
                Username = student.Username
            };

            return View(model);
        }


        [HttpPost]
        public IActionResult Delete(int id, StudentViewModel model)
        {
            Student student = _databaseContext.Students.Find(id);

            if (student != null)
            {
                _databaseContext.Students.Remove(student);
                _databaseContext.SaveChanges();
            }

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Details(int id)
        {
            Student student = _databaseContext.Students.Find(id);

            if (student == null)
            {
                return RedirectToAction(nameof(Index));
            }

            StudentViewModel model = new StudentViewModel
            {
                Id = student.Id,
                NameSurname = student.NameSurname,
                Username = student.Username
            };

            return View(model);
        }

        public IActionResult GetDetailsPartial(int id)
        {
            Student student = _databaseContext.Students.Find(id);

            if (student == null)
            {
                return RedirectToAction(nameof(Index));
            }

            StudentViewModel model = new StudentViewModel
            {
                Id = student.Id,
                NameSurname = student.NameSurname,
                Username = student.Username
            };

            return PartialView("_StudentViewPartial", model);
        }


        public IActionResult GetChangePassPartial(int id)
        {
            StudentChangePassViewModel model = new StudentChangePassViewModel
            {
                Id = id
            };

            return PartialView("_StudentChangePassPartial", model);
        }

        [HttpPost]
        public IActionResult ChangePassword(int id, StudentChangePassViewModel model)
        {
            if (ModelState.IsValid)
            {
                Student student = _databaseContext.Students.Find(id);

                if (student != null)
                {
                    student.Password = model.Password.MD5();

                    _databaseContext.SaveChanges();
                }
            }

            return RedirectToAction(nameof(Index));
        }
    }
}
