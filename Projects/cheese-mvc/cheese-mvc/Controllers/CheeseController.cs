 using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using cheese_mvc.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860
namespace CheeseMVC.Controllers
{
    public class CheeseController : Controller
    {

        static private List<Cheese> Cheeses = new List<Cheese>();


        // GET: /<controller>/
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.cheeses = Cheeses;
            return View();
        }



        [HttpPost]
        public IActionResult Index(string[] antiCheese)
        {
            for (int i = Cheeses.Count-1; i>-1; i--)
            {
                foreach (string cheeseName in antiCheese)
                {
                    if (cheeseName == Cheeses[i].Name)
                    {
                        Cheeses.RemoveAt(i);
                        break;
                    }

                }
              
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
            Cheese new_cheese = new Cheese(name, description);
            Cheeses.Add (new_cheese);

            return Redirect("/Cheese");
        }
   
    }
}