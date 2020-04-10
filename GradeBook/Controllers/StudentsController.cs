using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace iitu.web.example.Controllers
{
    public class Student
    {
        public string Name;
        public DateTime DOB;
        public int GroupNumber;
        public static List<Student> students = new List<Student>();
        public string code = new string("--");

        public Student(string name, DateTime dob, int groupNumber)
        {
            Name = name;
            DOB = dob;
            GroupNumber = groupNumber;
        }

        public string GetCode()
        {
            return code;
        }
    }

    [Route("students/[action]")]
    public class StudentsController : Controller
    {
        [Route("{code:minlength(6}")]
        public IActionResult GetStudent(string code)
        {
            ViewData["code"] = code;
            char[] codeBase = code.ToCharArray();
            char firstNameStarts = codeBase[0];
            char lastNameStarts = codeBase[1];
            int dobLasts = Int32.Parse(new string(new[] {codeBase[2], codeBase[3]}));
            int groupNumber = Int32.Parse(new string(new[] {codeBase[4]}));
            if (dobLasts <= 21)
            {
                dobLasts += 2000;
            }
            else
            {
                dobLasts += 1900;
            }

            int colls = Int32.Parse(new string(codeBase.Skip(5).ToArray()));
            Console.WriteLine(colls);
            Console.WriteLine(code);
            Console.WriteLine(groupNumber);
            int iter = 0;
            Student hitStudent = null;
            foreach (var student in Student.students)
            {
                if (
                    student.Name.Split()[0].StartsWith(firstNameStarts) &&
                    student.Name.Split()[1].StartsWith(lastNameStarts) &&
                    student.DOB.Year == dobLasts &&
                    student.GroupNumber == groupNumber
                )
                {
                    if (colls == iter)
                    {
                        hitStudent = student;
                        Console.WriteLine(hitStudent.code);
                        break;
                    }

                    iter += 1;
                }
            }
            ViewData["student"] = hitStudent;
            return View("Result");
        }
    }
}