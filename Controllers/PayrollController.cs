using JwrightWebsite.Models;
using JwrightWebsite.Models.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace JwrightWebsite.Controllers
{
    public class PayrollController : Controller
    {
        private JwrightCareModels db = new JwrightCareModels();

        // GET: Payroll
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Students()
        {
            List<Student> students = db.Students.ToList();
            return View(students);
        }

        public ActionResult Instructors()
        {
            List<Instructor> instructors = db.Instructors.ToList();
            return View(instructors);
        }

        public ActionResult Attendances()
        {
            List<Attendance> attendances = db.GetAttendanceByDate().ToList();
            return View(attendances);
        }

    }
}