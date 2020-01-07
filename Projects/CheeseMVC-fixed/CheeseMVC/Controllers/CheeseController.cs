using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CheeseMVC.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CheeseMVC.Controllers
{
    public class CheeseController : Controller
    { 
        // GET: /<controller>/
        [Route("/Cheese")]
        [Route("/Cheese/Index")]
        [HttpPost] 
        public IActionResult Remove (int[] cheeseIds) 
        {
            foreach (int cheeseId in cheeseIds)
            {
                Cheeses.RemoveAll(x => x.CheeseId == cheeseId);
            }
            
            return Redirect("/Cheese"); 
        }

        public IActionResult Add()
        {
            return View();
        }

        [Route("/Cheese/Add")]
        [HttpPost]
        public IActionResult NewCheese(string name, string description)
        {
            //Add the new cheese to my existing cheeses

            Cheese ch = new Cheese{
                Name = name,
                Description = description
            };
            Cheeses.Add(ch);
            return Redirect("/Cheese");
        }


        
      
    }

    
}


