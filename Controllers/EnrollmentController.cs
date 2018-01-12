using JwrightWebsite.Models;
using JwrightWebsite.Models.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace JwrightWebsite.Controllers
{
    public class EnrollmentController : Controller
    {
        private JwrightCareModels db = new JwrightCareModels();

        // GET: Enrollment
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Enroll()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Enroll(Student student)
        {
            if (string.IsNullOrEmpty(student.FirstName))
                ModelState.AddModelError("FirstName", "The name field is required.");            
            if (string.IsNullOrEmpty(student.LastName))
                ModelState.AddModelError("LastName", "The name field is required.");
           
            if (ModelState.IsValid)
            {
                db.Add(student);
                return RedirectToAction("Index");
            }
            return View(student);
        }
    }
}