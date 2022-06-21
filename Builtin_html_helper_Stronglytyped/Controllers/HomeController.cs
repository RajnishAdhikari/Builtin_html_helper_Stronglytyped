using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Builtin_html_helper_Stronglytyped.Models;

namespace Builtin_html_helper_Stronglytyped.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        { 
            Student s1 = new Student()
            {
                Id = 10000,
                Name = "ram",
                Age = 20,
                Address = "Nayabazar",
                IsPass = true,
            };
          return View(s1);

        }

    }
}