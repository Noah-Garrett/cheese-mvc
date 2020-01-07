using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using CheeseMVC.ViewModels;
using CheeseMVC.Models;
using Microsoft.AspNetCore.Mvc.Rendering;



namespace CheeseMVC.ViewModels
{
    public class AddCheeseViewModel
    {
        [Required]
        [Display(Name = "Cheese Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "DAM DOOD GOTTA LABEL EET")]
        public string Description { get; set; }

        public CheeseType Type { get; set; }

        public List<SelectListItem> CheeseTypes { get; set; }

        [Range(1,5)]
        public int Rating { get; set; }

        public AddCheeseViewModel()
        {
            CheeseTypes = new List<SelectListItem>
            {

                //<option value="0">hard</option>
                new SelectListItem()
                {
                    Value = ((int)CheeseType.Fake).ToString(),
                    Text = CheeseType.Fake.ToString()
                },

                new SelectListItem()
                {
                    Value = ((int)CheeseType.Soft).ToString(),
                    Text = CheeseType.Soft.ToString()
                },

                new SelectListItem()
                {
                    Value = ((int)CheeseType.Hard).ToString(),
                    Text = CheeseType.Hard.ToString()
                }
            };
        }

        public Cheese CreateCheese()
        {
            return new Cheese
            {
                
                Name = this.Name,
                Description = this.Description,
                Type = this.Type,
                Rating = this.Rating
             };
        
        }

    }

}
