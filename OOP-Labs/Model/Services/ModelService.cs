using Domain.Helpers;
using Domain.Model;
using Domain.Serializer;
using System;
using System.Collections.Generic;

namespace Domain.Services
{
    [Serializable]
    public class ModelService
    {
        public List<Drink> Drinks { get; private set; }

        public List<SerializerHelper> Filters { get; set; }

        public SerializerHelper LastFilter { get; set; }

        public string LastFile { get; set; }

        public ModelService()
        {
            Drinks = new List<Drink>();

            Filters = new List<SerializerHelper>()
            {
                new SerializerHelper("Binary file (*.bin)|*.bin", new BinarySerializer())
            };
        }

        public void AddDrink(Drink drink)
        {
            Drinks.Add(drink);
        }

        public void AddDrinks(List<Drink> drinks)
        {
            foreach (var drink in drinks)
            {
                Drinks.Add(drink);
            }
        }
    }
}
