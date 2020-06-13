using System.Collections.Generic;

namespace Domain.Model.Alcoholic
{
    public class Cognac : Alcoholic
    {
        public string Class { get; set; }

        public string BarrelMaterial { get; set; }

        public override Dictionary<string, string> GetDrinkInfo()
        {
            var drinkInfo = new Dictionary<string, string>
            {
                { "Name", Name },
                { "Cost", Cost.ToString() },
                { "Alcohol content", AlcoholContent.ToString() },
                { "Date of bottling", DateOfBottling.ToString()},
                { "Class", Class },
                { "Barrel material", BarrelMaterial },
                { "Bottle volume", Bottle.Volume.ToString() },
                { "Bottle color", Bottle.Color }
            };

            return drinkInfo;
        }
    }
}
