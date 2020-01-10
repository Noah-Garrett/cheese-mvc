using System;
using System.Collections.Generic;
using CheeseMVC.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CheeseMVC.ViewModels
{
    public class AddMenuItemViewModel
    {
        public int CheeseID { get; set; }
        public int MenuID { get; set; }

        public Menu Menu { get; set; }
        public List<SelectListItem> Cheeses { get; set; }


        public AddMenuItemViewModel()
        {
        }

        public AddMenuItemViewModel(Menu menu, IEnumerable<Cheese> cheeseItems)
        {
            Menu = menu;

            Cheeses = new List<SelectListItem>();

            foreach (Cheese cheese in cheeseItems)
            {
                Cheeses.Add(new SelectListItem
                {
                    Value = cheese.ID.ToString(),
                    Text = cheese.Name
                });
            }
          
        }
    }
}
