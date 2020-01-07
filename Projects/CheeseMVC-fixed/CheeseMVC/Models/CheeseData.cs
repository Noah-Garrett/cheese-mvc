using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace CheeseMVC.Models
{
    public class CheeseData
    {
         static private List<Cheese> Cheeses = new List<Cheese>();
            
        //GetAll at some point
        public static List<cheese> GetAll()
        {
            return cheeses;
        }

        //Add method
        public static void Add(Cheese newCheese)
        {
            Cheeses.Add(newCheese);
        }

        //Remove method

        //GetById
            
        
    }
}
