using System;
using System.Collections.Generic;

namespace Domain.Model.NonAlcoholic
{
    [Serializable]
    public class MineralWater : NonAlcoholic
    {
        public string WaterSource { get; set; }

        public float Mineralization { get; set; }

        public override Dictionary<string, string> GetDrinkInfo()
        {
            var drinkInfo = new Dictionary<string, string>
            {
                { "Name", Name },
                { "Cost", Cost.ToString() },
                { "Sugar content", SugarContent.ToString() },
                { "Water source", WaterSource},
                { "Mineralization", Mineralization.ToString() },
                { "Bottle volume", Bottle.Volume.ToString() },
                { "Bottle color", Bottle.Color }
            };

            return drinkInfo;
        }
    }
}
