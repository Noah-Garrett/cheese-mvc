using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace UserSignup.Controllers
{
    public class UserController : Controller
    {
        //i got no idea why IActionResult is red. like, not a fuggin clew. derp.
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
                return Redirect ("Index");

            }
            ViewBag.user = user;
            ViewBag.verify = verify;
            return View();
        }
        

    }
}
