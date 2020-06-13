using System.Collections.Generic;

namespace Domain.Model
{
    public abstract class Drink
    {
        public string Name { get; set; }

        public decimal Cost { get; set; }

        public Bottle Bottle { get; set; }

        public abstract Dictionary<string, string> GetDrinkInfo();
    }
}
