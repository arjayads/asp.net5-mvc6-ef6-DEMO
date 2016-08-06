using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Track1.Models;

namespace Track1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //using (var c1 = new SchoolContext())
            //{
            //    Student s1 = new Student() { Name = "Arjay" };

            //    c1.Student.Add(s1);
            //    c1.SaveChanges();
            //}

            //using (var c2 = new SchoolContext())
            //{
            //    Student s2 = c2.Student.Where(b => b.Name == "Arjay").FirstOrDefault();

            //    if (object.ReferenceEquals(null, s2))
            //    {
            //        System.Diagnostics.Debug.WriteLine("Not Found");
            //    }
            //    else
            //    {
            //        System.Diagnostics.Debug.WriteLine("Student Found");
            //    }

            //    System.Diagnostics.Debug.WriteLine("Loading view");
            //}

            //var ctx = new SchoolContext();
            //Student stud = ctx.Student.Where(b => b.Name == "Arjay").FirstOrDefault();

            return View();
        }   

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}