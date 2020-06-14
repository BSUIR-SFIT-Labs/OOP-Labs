using System;
using System.Collections.Generic;

namespace Domain.Model.NonAlcoholic
{
    [Serializable]
    public class Juice : NonAlcoholic
    {
        public string Fruit { get; set; }

        public float JuiceContent { get; set; }

        public float PulpContent { get; set; }

        public override Dictionary<string, string> GetDrinkInfo()
        {
            var drinkInfo = new Dictionary<string, string>
            {
                { "Name", Name },
                { "Cost", Cost.ToString() },
                { "Sugar content", SugarContent.ToString() },
                { "Fruit", Fruit},
                { "Juice content", JuiceContent.ToString() },
                { "Pulp content", PulpContent.ToString() },
                { "Bottle volume", Bottle.Volume.ToString() },
                { "Bottle color", Bottle.Color }
            };

            return drinkInfo;
        }
    }
}
