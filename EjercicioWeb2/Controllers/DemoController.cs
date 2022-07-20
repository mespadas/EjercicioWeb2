using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EjercicioWeb2.Controllers
{
    public class DemoController : BaseController
    {
        // GET: Demo
        public ActionResult Index()
        {
            return View();
        }

        public string Index2()
        {
            return "Hola Index2";
        }

        public IList<Student> Index3()
        {
            IList<Student> studentList = new List<Student>() {
                    new Student(){ StudentID=1, StudentName="Steve", Age = 21 },
                    new Student(){ StudentID=2, StudentName="Bill", Age = 25 },
                    new Student(){ StudentID=3, StudentName="Ram", Age = 20 },
                    new Student(){ StudentID=4, StudentName="Ron", Age = 31 },
                    new Student(){ StudentID=5, StudentName="Rob", Age = 19 }
                };
            return studentList;
        }

        public JsonResult Index4()
        {
            return Json(Index3(), JsonRequestBehavior.AllowGet);
        }

        public class Student
        {
            public int StudentID { set; get; }
            public String StudentName { set; get; }
            public int Age { set; get; }
        }

    }
}