using System;
using CheeseMVC.Models;
namespace CheeseMVC.ViewModels
{
    public class EditAddCheeseViewModel : AddCheeseViewModel
    {
        public int CheeseId { get; set; }

        public EditAddCheeseViewModel()
        {
        }
        public EditAddCheeseViewModel(Cheese ch)
        {
            CheeseId = ch.CheeseId;
            Name = ch.Name;
            Description = ch.Description;
            Type = ch.Type;
            Rating = ch.Rating;
        }
    }
}
