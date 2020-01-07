using System;
using System.Collections.Generic;

namespace CheeseMVC.Models
{
    public class Cheese
    {

        public string Name { get; set; }
        public string Description { get; set; }
        public int CheeseId { get; set; }

        private static int nextId = 1; 

        public Cheese()
        {
            CheeseId = nextId;
            nextId++;
        } 

      
    }
}
