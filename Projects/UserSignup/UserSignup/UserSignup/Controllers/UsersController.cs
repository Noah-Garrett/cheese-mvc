using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace UserSignup.Controllers
{
    public class UsersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(User user, string verify)
        {
            if (user.Password.Equals(verify))
            {
                return Redirect("User");

            }
            ViewBag.user = user;
            ViewBag.verify = verify;
            return View();
        }
        public ActionResult Index()
        {
            return View ();
        }
    }
}
