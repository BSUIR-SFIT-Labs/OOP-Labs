using Domain.Model;
using System.Collections.Generic;

namespace Domain.Services
{
    public class ModelService
    {
        public List<Drink> Drinks { get; private set; }

        public ModelService()
        {
            Drinks = new List<Drink>();
        }

        public void AddDrink(Drink drink)
        {
            Drinks.Add(drink);
        }
    }
}
