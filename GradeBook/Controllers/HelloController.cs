using System;
using System.Linq;
using System.Security.Cryptography;
using Microsoft.AspNetCore.Mvc;

namespace iitu.web.example.Controllers
{
    public class HelloController : Controller
    {
        public IActionResult Index()
        {
            if (Student.students.Count == 0)
            {
                string firstName = "Afdsfds";
                string lastName = " Ajuhgb";
                string[] names = new[]
                {
                    "Eniki Beniki",
                    "Eli Vareniki",
                    "Dva Gusya",
                    "Tri Gusya",
                    "Zayac Pgodi",
                    "Nabor Slov",
                    "Nebo Slonov",
                    "Nash Snegovik",
                    "Nastya Snegurochka",
                    "Nasha RAWA",
                    "Ninety Seven",
                };
                for (int i = 0; i < names.Length; i++)
                {
                    Student student = new Student(names[i], DateTime.Now.AddDays(i), i/3);
                    string code = new string(new[] {student.Name.Split()[0].First(), student.Name.Split()[1].First()}) +
                                  (student.DOB.Year / 100) +
                                  student.GroupNumber;
                    int colls = 0;

                    foreach (var dbStudent in Student.students)
                    {
                        string antiCollCode = code + colls;
                        if (antiCollCode.Equals(dbStudent.code))
                        {
                            colls += 1;
                        }

                        if (colls >= 10000)
                        {
                            throw new InvalidCastException("Mapping error");
                        }
                    }

                    student.code = code + colls;
                    Student.students.Add(student);
                }
            }

            ViewData["students"] = Student.students;

            return View();
        }
    }
}