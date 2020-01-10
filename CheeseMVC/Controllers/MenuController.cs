using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CheeseMVC.Data;
using CheeseMVC.Models;
using CheeseMVC.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CheeseMVC.Controllers
{
    public class MenuController : Controller
    {
        private CheeseDbContext context;

        public MenuController(CheeseDbContext dbcontext)
        {
            context = dbcontext;
        }


        // GET: /<controller>/
        public IActionResult Index()
        {
            return View(context.Menus.ToList());
        }

        // GET add
        public IActionResult Add()
        {
            AddMenuViewModel vm = new AddMenuViewModel();
            return View(vm);
        }
        //POST add
        [HttpPost]
        public IActionResult Add(AddMenuViewModel vm)
        {
            if (ModelState.IsValid)
            {
                Menu newMenu = new Menu
                {
                    Name = vm.Name
                };

                context.Menus.Add(newMenu);
                context.SaveChanges();

                return Redirect("/Menu/ViewMenu/" + newMenu.ID);

            }
            return View(vm);
        }

        //GET
        public IActionResult ViewMenu(int id)
        {
            Menu menu = context.Menus.Single(m => m.ID == id);

            List<CheeseMenu> items = context
            .CheeseMenus
            .Include(item => item.Cheese)
            .Where(cm => cm.MenuID == id)
            .ToList();

            ViewMenuViewModel vm = new ViewMenuViewModel
            {
                Menu = menu,
                Items = items
            };

            return View(vm);
        }

        public IActionResult AddItem(int id)
        {
            Menu menu = context.Menus.Single(m => m.ID == id);

            List<Cheese> cheeses = context.Cheeses.ToList();

            AddMenuItemViewModel amvm = new AddMenuItemViewModel(menu, cheeses);

            return View(amvm);

        }
    }
}
