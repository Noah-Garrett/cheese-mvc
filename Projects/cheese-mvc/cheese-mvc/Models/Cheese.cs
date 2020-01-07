using System;
namespace cheese_mvc.Models
{
    public class Cheese
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public Cheese(string Name, string Description)
        {
            this.Name = Name;
            this.Description = Description;

        }
    }
}