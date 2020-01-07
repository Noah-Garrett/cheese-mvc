using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Usersignup2.Models;
using Usersignup2.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Usersignup2.Controllers
{
    public class UserController : Controller
    {
        // GET: /User/Index
        public IActionResult Index(string username = "User")
        {
        ViewBag.username = username;
            return View();
        }



        //GET /user/Add
        public IActionResult Add()
        {
            AddUserViewModel vm = new AddUserViewModel();


            return View(vm);
        }



        //POST /user/Add
        [HttpPost]
        public IActionResult Add(AddUserViewModel vm)
        {


            //if AddUserViewModel.ModelState.IsValid
            if (ModelState.IsValid)
            {
                return Redirect("Index?username="+vm.Username);
            }

            return View(vm);
        }


    }
}

    

